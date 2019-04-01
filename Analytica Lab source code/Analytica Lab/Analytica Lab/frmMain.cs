using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Threading;
using Analytica_Lab_Administration_Wizard;
using System.Diagnostics;

namespace Analytica_Lab
{
    public partial class frmMain : Form
    {
        public frmMain()
        {


            InitializeComponent();
            frmSplash splashForm = new frmSplash();
            splashForm.Show();

            splashForm.UpdateSplashForm("Initializing components...");
            splashForm.Update();
            Thread.Sleep(1000);

            splashForm.UpdateSplashForm("Configuring user interface...");
            splashForm.Update();

            Thread.Sleep(1500);

            splashForm.UpdateSplashForm("Initialization completed...");
            splashForm.Update();
            Thread.Sleep(1500);
            splashForm.Close();
        }

        #region ~Class level variable declarations~

        //variable to hold a welcome form instance... 
        frmWelcome formWelcome;
        DB_Operator dbo = new DB_Operator();

        #endregion

        #region ~ User Interface Operations~

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeProgram();
        
        }


        private void takeAPortionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSampling newPortionForm = new frmSampling(this);
            newPortionForm.ShowDialog();
        }

        private void treeViewSample_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var p = treeViewSample.PointToScreen(e.Location);
                
                cntxtMenuMainForm.Show(p);
            }

            int sampleIndex = (e.Node as CustomTreeNode).SampleIndex;
            UpdateImageBox(sampleIndex);

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to quit Analytica Lab?", "Exit Analytica Lab", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {

                e.Cancel = true;

            }

        }
        
        #endregion


        #region ~Tool Strip Button Operations~

        private void toolStripBtnSeperate_Click(object sender, EventArgs e)
        {
            if (treeViewSample.SelectedNode == null)
            {

                MessageBox.Show("You must select a sample to seperate...!");

            }
            else {

                Sample smpl = new Sample(this);
                try
                {
                    smpl.CentrifugeAndSeperateSample(treeViewSample.SelectedNode);
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                
                }
            }

        }

        private void toolStripBtnOptions_Click(object sender, EventArgs e)
        {
            frmOptions options = new frmOptions();
            options.ShowDialog();
        }

        private void toolStripBtnDB_Click(object sender, EventArgs e)
        {
            Process.Start("Analytica Lab Administration Wizard.exe");
            Application.ExitThread();
        }

        private void toolStripBtnSubSample_Click(object sender, EventArgs e)
        {
            frmSampling frmSubSample = new frmSampling(this);
            frmSubSample.ShowDialog();
        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Do you want to discrad the current samples and start with a new one?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) {

                InitializeProgram();
            
            }
            
        }

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.OverwritePrompt = true;
            sfd.Filter = "Analytica Lab files(*.al)|*.al";
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {

                WriteToFile(sfd.FileName);
                MessageBox.Show("File saved...!");

            }


            
 
        }

        #endregion

        #region ~Custom Methods~



        //Sets the intial environment of the program...
        private void InitializeProgram()
        {
            LoadControls();

            if (treeViewSample.Nodes.Count != 0)
            {

                treeViewSample.Nodes.Clear();
                Sample.lst_Samples.Clear();
                Sample.lst_Colors.Clear();
                Sample.lst_State.Clear();
                richTxtBoxStatus.Clear();

            }

            //create a welcome form object & show it up..

            formWelcome = new frmWelcome(this);
            formWelcome.ShowDialog();

            //Create initial sample in the treview..


            CustomTreeNode treeNode_Sample_Original = new CustomTreeNode();
            treeNode_Sample_Original.SampleIndex = 0;
            treeNode_Sample_Original.Text = "Original_Sample";
            treeNode_Sample_Original.ForeColor = Color.Black;
            treeNode_Sample_Original.BackColor = Color.White;
            treeViewSample.Nodes.Add(treeNode_Sample_Original);
            treeViewSample.ExpandAll();
            treeViewSample.SelectedNode = treeNode_Sample_Original;

            UpdateStatus("Your sample is ready for the analysis...!");

            //Set initial settings for the porgram..

            FileOperator fo = new FileOperator();
            frmOptions.NumberOfSpeciesInRandomSample = Convert.ToInt32(fo.GetXMLValue("Settings.xml", "NumOfSpeciesInRndmSmple"));
            
        }

        //Writes data in lists to .al files...
        private void WriteToFile(string path)
        {

            List<string> sampleNames = new List<string>();

            List<string> treeNodePaths = new List<string>();
            List<string> sampleIndices = new List<string>();

            for (int i = 0; i < Sample.lst_Samples.Count; i++)
            {

                foreach (TreeNode treeNode in GetAllNodes(treeViewSample))
                {

                    if (((CustomTreeNode)treeNode).SampleIndex == i)
                    {


                        sampleNames.Add(treeNode.Text);
                        treeNodePaths.Add(treeNode.FullPath);
                        sampleIndices.Add(Convert.ToString(((CustomTreeNode)treeNode).SampleIndex));

                    }

                }

            }


            FileOperator fo = new FileOperator();
            fo.WriteTextFile(path, sampleNames, Sample.lst_Samples, Sample.lst_Colors, Sample.lst_State, treeNodePaths, sampleIndices);

        }

        //Treeview control does not have a proper method to return all of its nodes.. This method returns all nodes as a collection..
        public IEnumerable<TreeNode> GetAllNodes(TreeView treeview)
        {
            LinkedList<TreeNodeCollection> collections =
                new LinkedList<TreeNodeCollection>();

            collections.AddLast(treeview.Nodes);
            while (collections.Count > 0)
            {
                foreach (TreeNode cur in collections.First.Value)
                {
                    collections.AddLast(cur.Nodes);
                    yield return cur;
                }
                collections.RemoveFirst();
            }
        }

        //Gets an image from the image list and sets to picBoxSample...
        public void UpdateImageBox(int ImageIndex)
        {

            Bitmap bmp = Sample.lst_Images[ImageIndex];
            picBoxSample.BackgroundImage = bmp;
            picBoxSample.Update();

        }

        private void PerformOperation(string operationName, string operationCode)
        {
            AddReagent(operationName, operationCode);

        }

        //Fires when a reagent is added...
        private void AddReagent(string reagentName, string reagentCode)
        {

            DataTable dt1 = dbo.GetTable("Compound_Data");
            DataTable dt2 = dbo.GetDataFromChemicalCompoundsTable(reagentCode);

            string message = "";

            if (treeViewSample.SelectedNode != null)
            {

                var sampleIndex = ((CustomTreeNode)treeViewSample.SelectedNode).SampleIndex;

                var sample = Sample.lst_Samples[sampleIndex];
                //List variable that holds chosen compounds from chemical compounds datatable..
                List<string> newSample = new List<string>();

                //list variable that holds the compound IDs of new sample...
                List<int> lstCompoundIDSOfNewSample = new List<int>();

                int indexOfS = 0;

                for (int j = 0; j < sample.Count; j++)
                {
                    string s = sample.ElementAt(j);
                    bool foundSFromTable = false;

                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        int compoundID = Convert.ToInt32(dt1.Rows[i].ItemArray[0]);
                        string compoundName = Convert.ToString(dt1.Rows[i].ItemArray[1]);
                        int pickedCompoundIDFromTable = Convert.ToInt32(dt2.Rows[i].ItemArray[1]);
                        string pickedCompoundName="";



                        if (Convert.ToBoolean(compoundName.Trim() == s.Trim()))
                        {
                            if (pickedCompoundIDFromTable != 0)
                            {
                                //Add compound ID into the new compound ID list...
                                lstCompoundIDSOfNewSample.Add(pickedCompoundIDFromTable);

                                //find the name corresponding to picked compound id... 
                                foreach (DataRow dr in dt1.Rows)
                                {

                                    if (Convert.ToInt32(dr.ItemArray[0]) == pickedCompoundIDFromTable) 
                                    {

                                        pickedCompoundName = Convert.ToString(dr.ItemArray[1]);
                                    
                                    }
                                
                                
                                }

                                newSample.Add(pickedCompoundName);
                                foundSFromTable = true;
                                break;
                            }
                            else
                            {
                                //get the compound id of the current compound (s) and add it to new compound id list... 
                                foreach (DataRow dr in dt1.Rows) {

                                    if (Convert.ToBoolean(Convert.ToString(dr.ItemArray[1]) == s.Trim())) 
                                    {

                                        lstCompoundIDSOfNewSample.Add(Convert.ToInt32(dr.ItemArray[0]));
                                    }
                                
                                }

                                newSample.Add(s);
                                foundSFromTable = true;

                            }
                        }

                    }

                    if (foundSFromTable == false)
                    {

                        newSample.Add(s);

                    }

                    indexOfS += 1;
                }

                Sample.lst_Samples[sampleIndex] = newSample;

                if (reagentCode.Contains("Op_"))
                {
                    message += reagentName + " was performed on the " + treeViewSample.SelectedNode.Text + "...!  ";
                    
                }
                else
                {
                    message += reagentName + " was added to the " + treeViewSample.SelectedNode.Text + "...!  ";
                    
                }
                //determine color and state of the new compounds.. 

                DataTable dt3 = dbo.GetTable("Physical_Properties");
                

                var colorOfEachSpecies = Sample.lst_Colors.ElementAt(sampleIndex);
                var stateOfEachSpecies = Sample.lst_State.ElementAt(sampleIndex);

                List<string> newColorOfEachSpecies = new List<string>();
                List<string> newStateOfEachSpecies = new List<string>();

                indexOfS = 0;

                foreach (int sID in lstCompoundIDSOfNewSample)
                {

                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {


                        if (Convert.ToBoolean(sID == Convert.ToInt32(dt3.Rows[i].ItemArray[0])))
                        {

                            newColorOfEachSpecies.Add((string)dt3.Rows[i].ItemArray[2]);

                            newStateOfEachSpecies.Add((string)dt3.Rows[i].ItemArray[1]);

                            break;
                        }

                    }

                    indexOfS += 1;
                }

                Sample.lst_Colors[sampleIndex] = newColorOfEachSpecies;
                Sample.lst_State[sampleIndex] = newStateOfEachSpecies;


                string newState = DetermineState(newStateOfEachSpecies);
                string newColor = DetermineColor(newColorOfEachSpecies);

                MediaOperator mop = new MediaOperator(this);

                Sample.lst_Images[sampleIndex] = mop.GetImage(newSample, newStateOfEachSpecies, newColorOfEachSpecies);
                CustomColor cc = new CustomColor();

                picBoxSample.Update();

                if (Convert.ToBoolean(newColor.Trim() == "###,###,###"))
                {

                    newColor = "a colorless";
                }
                else
                {
                    var colorArray =newColor.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries);
                    newColor = cc.GetNearestColorName(Color.FromArgb(Convert.ToInt32(colorArray[0]), Convert.ToInt32(colorArray[1]), Convert.ToInt32(colorArray[2])));
                                
                }

                
                message += "You have obtained " + newColor + " " + newState + " in " + treeViewSample.SelectedNode.Text + "...";
                UpdateStatus(message);
            }
            else
            {

                throw new Exception("You can't add a reagent or perform an operation without selecting a sample...!");

            }


        }



        public string DetermineColor(List<string> lstColors) {

            CustomColor col = new CustomColor();

            List<Color> lstTempColors = new List<Color>();

            for (int i = 0; i < lstColors.Count; i++)
            {

                if (Convert.ToBoolean(lstColors.ElementAt(i) != "###,###,###"))
                {

                    string s = lstColors[i];
                    List<string> lstS = s.Split(',').ToList();
                    Color c = Color.FromArgb(Convert.ToInt32(lstS[0]), Convert.ToInt32(lstS[1]), Convert.ToInt32(lstS[2]));
                    lstTempColors.Add(c);
                }

            }


            if (lstTempColors.Count != 0)
            {

                Color color = col.DetermineMixedColor(lstTempColors);
                string newColor = Convert.ToString(color.R) + "," + Convert.ToString(color.G) + "," + Convert.ToString(color.B);
                return newColor;
            }
            else {

                return "###,###,###";
            }
        
        }

        private string DetermineState(List<string> statesOfSpeciesInSample)
        {

            string state = "solution";

            foreach (string s in statesOfSpeciesInSample)
            {

                if (s.Trim() == "precipitate")
                {
                    state = "precipitate";
                    break;
                }
                else if (s.Trim() == "geletinous precipitate")
                {
                    state = "geletinous precipitate";

                }
                else if (s.Trim() == "salt")
                {
                    state = "salt";

                }
                else if (s.Trim() == "crystal")
                {
                    state = "crystal";

                }
            }

            return state;
        }

        public void UpdateStatus(string message)
        {
           
            richTxtBoxStatus.BackColor = Color.White;
            richTxtBoxStatus.ForeColor = Color.Black;
            Color colorOfTheText = richTxtBoxStatus.ForeColor;

            richTxtBoxStatus.SelectionColor = Color.Blue;
            int messageLength = message.Length;

            richTxtBoxStatus.Select(0, 0);           
            richTxtBoxStatus.SelectedText += message + Environment.NewLine;

            richTxtBoxStatus.SelectionStart = 0;
            richTxtBoxStatus.SelectionLength = messageLength;
            richTxtBoxStatus.SelectionBackColor = Color.Yellow;

            richTxtBoxStatus.Select(messageLength, richTxtBoxStatus.TextLength);
            richTxtBoxStatus.SelectionBackColor = Color.White;
            
        }

        private void SetPnlViewerSize() 
        {

            int width = this.Width;
            int height = this.Height;

            pnlViewer.Location = new Point(pnlRgnts_Op.Size.Width, 78);
            int panelWidth = width - pnlInProgress.Size.Width - pnlRgnts_Op.Size.Width-15;
            int panelHeight = height - pnlMsgs.Size.Height-118;
            pnlViewer.Size = new Size(panelWidth, panelHeight);
        
        }

        private void LoadControls() {

            SetPnlViewerSize();
            pdfViewer.LoadFile("manual.pdf");



            pnlRgnts.Controls.Clear();

            DataTable dt1 = dbo.GetTable("Reagent_Data");
            DataTable dt2 = dbo.GetTable("Operation_Data");

            int y = 10;

            List<string> lstTempReagentCode = new List<string>();
            List<string> lstTempReagentName = new List<string>();

            foreach (DataRow dr in dt1.Rows) {

               
                lstTempReagentName.Add(Convert.ToString(dr.ItemArray[2]));
            
            }

            lstTempReagentName.Sort();

            for (int i = 0; i < lstTempReagentName.Count; i++) {

                var rjntName = lstTempReagentName[i];

                for (int j = 0; j < lstTempReagentName.Count; j++) {

                    string reagentNameFromTable = Convert.ToString(dt1.Rows[j].ItemArray[2]);
                      if (reagentNameFromTable == rjntName) 
                    {
                         var rjntCode = Convert.ToString(dt1.Rows[j].ItemArray[1]);
                         lstTempReagentCode.Add(rjntCode);
                         break;
                    } 
                
                }
            
            }


            for (int i = 0; i < lstTempReagentCode.Count; i++) 
            {


                var reagentCode = lstTempReagentCode[i];
                var reagentName = lstTempReagentName[i];

                CustomButton cb = new CustomButton();
                cb.ReagentOrOperationCode = reagentCode;
                cb.ReagentOrOperationName = reagentName;
              

                cb.Size = new Size(236, 32);
                cb.Location = new Point(2, y);

                Font fnt = new System.Drawing.Font("Cambria", 11.25f);
                cb.Font = fnt;
                cb.TextAlign = ContentAlignment.MiddleCenter;
                cb.Text = reagentName;

                cb.Click += new EventHandler(cb_Click);
                pnlRgnts.Controls.Add(cb);

                y += 32;
                

            
            
            }

       



            foreach (DataRow dr in dt2.Rows)
            {

                ToolStripButton tsbToDispose=new ToolStripButton();
                foreach (ToolStripButton toolStripBtn in toolStripMainForm.Items.OfType<ToolStripButton>())
                {
                    if (toolStripBtn.ToolTipText == Convert.ToString(dr.ItemArray[2])) 
                    {
                        tsbToDispose = toolStripBtn;
                        break;
                    }
                
                }

                string imageLink = dr.ItemArray[3] as string;

                tsbToDispose.Dispose();

                CustomToolStripButton tsb = new CustomToolStripButton();
                tsb.OperationCode = Convert.ToString(dr.ItemArray[1]);
                tsb.OperationName = Convert.ToString(dr.ItemArray[2]);

                try
                {
                    tsb.Image = new Bitmap(imageLink);
                }
                catch
                {

                    tsb.Image = new Bitmap("operation.png");
                }
                    
            
                tsb.ImageAlign = ContentAlignment.MiddleCenter;
                tsb.ImageScaling = ToolStripItemImageScaling.None;
                tsb.Size = new System.Drawing.Size(52, 48);
                tsb.Alignment = ToolStripItemAlignment.Left;
                tsb.ToolTipText = tsb.OperationName;
                toolStripMainForm.Items.Add(tsb);

                tsb.Click += new EventHandler(tsb_Click);

            }

        
        }

        void tsb_Click(object sender, EventArgs e)
        {
            string operationCode = ((CustomToolStripButton)sender).OperationCode;
            string operationName = ((CustomToolStripButton)sender).OperationName;

            PerformOperation(operationName, operationCode);
        }

        void cb_Click(object sender, EventArgs e)
        {
            string reagentName = ((CustomButton)sender).ReagentOrOperationName;
            string reagentCode = ((CustomButton)sender).ReagentOrOperationCode;

            AddReagent(reagentName, reagentCode);
            
        }

        #endregion

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewSample.LabelEdit = true;
            treeViewSample.SelectedNode.BeginEdit();
            
        }

        private void treeViewSample_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            treeViewSample.LabelEdit = false;
        }

        private void toolStripBtnAbout_Click(object sender, EventArgs e)
        {
            frmAbout abt = new frmAbout();
            abt.ShowDialog();
        }

        private void pnlRgnts_Op_PanelCollapsing(object sender, BSE.Windows.Forms.XPanderStateChangeEventArgs e)
        {
            pnlRgnts_Op.Text = "Reagents and Operations";
            SetPnlViewerSize();
        }

        private void pnlRgnts_Op_PanelExpanding(object sender, BSE.Windows.Forms.XPanderStateChangeEventArgs e)
        {
            pnlRgnts_Op.Text = "";
            SetPnlViewerSize();
        }



        private void pnlMsgs_PanelCollapsing(object sender, BSE.Windows.Forms.XPanderStateChangeEventArgs e)
        {
            SetPnlViewerSize();
            pnlMsgs.Text = "Analysis in Progress";
        }

        private void pnlMsgs_PanelExpanding(object sender, BSE.Windows.Forms.XPanderStateChangeEventArgs e)
        {
            SetPnlViewerSize();
            pnlMsgs.Text = "";
        }

        private void pnlInProgress_PanelCollapsing(object sender, BSE.Windows.Forms.XPanderStateChangeEventArgs e)
        {
            SetPnlViewerSize();
            pnlInProgress.Text = "Sample Properties";
        }

        private void pnlInProgress_PanelExpanding(object sender, BSE.Windows.Forms.XPanderStateChangeEventArgs e)
        {
            SetPnlViewerSize();
            pnlInProgress.Text = "";
        }

        private void pdfViewer_OnError(object sender, EventArgs e)
        {

        }









    }



    //Extend the button class to hold reagent/operation codes & names...

    public class CustomButton : Button
    {

        private string reagentOrOperationName;
        private string reagentOrOperationCode; 

        public string ReagentOrOperationName
        {

            get { return reagentOrOperationName; }
            set { reagentOrOperationName = value; }

        }

        public string ReagentOrOperationCode 
        {
            get { return reagentOrOperationCode; }
            set { reagentOrOperationCode = value; }
        
        }
    
    }

    public class CustomToolStripButton : ToolStripButton
    {

        private string operationName;
        private string operationCode;

        public string OperationName
        {

            get { return operationName; }
            set { operationName = value; }

        }

        public string OperationCode
        {
            get { return operationCode; }
            set { operationCode = value; }

        }
    }
}
