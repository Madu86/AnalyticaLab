using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analytica_Lab_Administration_Wizard
{
    public partial class editChemicalCompound : Form
    {
        public editChemicalCompound()
        {
            InitializeComponent();
        }

        DB_Operator dbo = new DB_Operator();

        List<string> lstColumnCodes = new List<string>();
        List<string> lstColumnNames = new List<string>();

        List<int> lstCompoundCodes = new List<int>();
        List<string> lstCompoundNames = new List<string>();

        int compound_ID;

        Panel pnlChemicalCompound;
        Label lblRgnt;
        Label lblCmpnds;

        string nameOftheChemicalCompound;
        string state;
        string colorCode = "###,###,###";
        string ColorName;
        string odor;
        List<string> lstCompoundsOnReagent = new List<string>();


        private void CreateChemicalCompoundPanel() {

            pnlChemicalCompound = new Panel();
            pnlChemicalCompound.BackColor = Color.White;
            pnlChemicalCompound.Size = new Size(453, 261);
            pnlChemicalCompound.Location = new Point(25, 339);
            pnlChemicalCompound.AutoScroll = true;
            this.Controls.Add(pnlChemicalCompound);

            lblRgnt = new Label();
            lblRgnt.Text = "Reagent or Operation";
            lblRgnt.Font = new Font("Cambria", 11.25f, FontStyle.Underline);       
            lblRgnt.Location=new Point(40, 20);
            lblRgnt.Size = new Size(141, 17);
            this.pnlChemicalCompound.Controls.Add(lblRgnt);

            lblCmpnds = new Label();
            lblCmpnds.Text = "Compound formed";
            lblCmpnds.Font = lblRgnt.Font;
            lblCmpnds.Location = new Point(228, 20);
            lblCmpnds.Size = new Size(125, 17);
            this.pnlChemicalCompound.Controls.Add(lblCmpnds);
        
        }


        private void editChemicalCompound_Load(object sender, EventArgs e)
        {
            PopulateSelector();

        }


        private void PopulateSelector() {

            cmbBoxSelector.Items.Clear();
            DataTable dt = dbo.GetTable("Compound_Data");
            for (int i = 0; i < dt.Rows.Count; i++) {

                cmbBoxSelector.Items.Add(dt.Rows[i].ItemArray[1]);
                      
            }

            grpBoxAddChemicalCompound.Hide();
            btnSave.Hide();

            this.Size = new Size(511, 147);
        
        }

        private void LoadDataIntoControls(string compoundName)
        {

            int index = lstCompoundNames.IndexOf(compoundName);
            compound_ID = lstCompoundCodes[index];

            var rwPhysicalProperties = dbo.GetRecord("Physical_Properties", compound_ID);
            var rwChemicalCompounds = dbo.GetRecord("Chemical_Compounds", compound_ID);

            //Set values into the controls... 

            txtBoxChemicalCompound.Text = compoundName;
            cmbBoxState.SelectedItem = rwPhysicalProperties[1];

            string colorString = (Convert.ToString(rwPhysicalProperties[2])).Trim();

            if (Convert.ToBoolean(colorString != "###,###,###"))
            {
                chkBoxColorless.Checked = false;
                string[] colorArray = colorString.Split(',');
                try
                {
                    colorCode = colorString;
                    Color c = Color.FromArgb(Convert.ToInt32(colorArray[0]), Convert.ToInt32(colorArray[1]), Convert.ToInt32(colorArray[2]));
                    colorDialog.Color = c;
                    btnColor.BackColor = c;
                }
                catch 
                {
                }
                
                txtBoxColorName.Text = Convert.ToString(rwPhysicalProperties[3]);
            }
            else 
            {
                btnColor.BackColor = Control.DefaultBackColor;
                chkBoxColorless.Checked = true;
                txtBoxColorName.Text = Convert.ToString(rwPhysicalProperties[3]);
            }

            txtBoxOdor.Text = Convert.ToString(rwPhysicalProperties[4]);

            List<string> lstCompoundNamesOnReagent = new List<string>();

            for (int i = 1; i < lstColumnCodes.Count+1; i++) {

                int columnValue = Convert.ToInt32(rwChemicalCompounds.ItemArray[i]);

                if (columnValue != 0)
                {

                    int p = lstCompoundCodes.IndexOf(columnValue);
                    lstCompoundNamesOnReagent.Add(lstCompoundNames[p]);

                }
                else {

                    lstCompoundNamesOnReagent.Add("");
                }
            }

            int a = 0;

            foreach (ComboBox cb in this.pnlChemicalCompound.Controls.OfType<ComboBox>())
            {
                string tmp = cb.Name;

                if (Convert.ToBoolean(lstCompoundNamesOnReagent[a].Trim() == "".Trim()))
                {

                    cb.Text = "";

                }
                else {

                    cb.SelectedItem = lstCompoundNamesOnReagent[a];
                
                }

                a += 1;
            }

        }



        private void LoadControls(string compoundName)
        {
            this.Size = new System.Drawing.Size(511, 692);
            grpBoxAddChemicalCompound.Show();
            btnSave.Show();
            CreateChemicalCompoundPanel();
           
            DataTable dt1 = dbo.GetTable("Reagent_Data");
            DataTable dt2 = dbo.GetTable("Operation_Data");
            DataTable dt3 = dbo.GetTable("Compound_Data");

            foreach (DataRow dr in dt1.Rows)
            {

                lstColumnCodes.Add(dr.ItemArray[1] as string);
                lstColumnNames.Add(dr.ItemArray[2] as string);

            }

            foreach (DataRow dr in dt2.Rows)
            {

                lstColumnCodes.Add(dr.ItemArray[1] as string);
                lstColumnNames.Add(dr.ItemArray[2] as string);

            }

            foreach (DataRow dr in dt3.Rows) {

                lstCompoundCodes.Add(Convert.ToInt32(dr.ItemArray[0]));
                lstCompoundNames.Add(Convert.ToString(dr.ItemArray[1]));
            
            }


            Point lblPosition = new Point(40, 63);
            Point txtBoxPosition = new Point(237, 60);

            for (int i = 0; i < lstColumnCodes.Count; i++)
            {


                Label lblReagent = new Label();
                lblReagent.Size = new System.Drawing.Size(194, 15);

                lblReagent.Name = "lblReagent_" + i.ToString();
                lblReagent.Location = lblPosition;
                this.pnlChemicalCompound.Controls.Add(lblReagent);

                lblReagent.Text = lstColumnNames[i];

                ComboBox cmbBoxCompound = new ComboBox();
                cmbBoxCompound.Name = i.ToString();
                cmbBoxCompound.Location = txtBoxPosition;
                this.pnlChemicalCompound.Controls.Add(cmbBoxCompound);

                for (int j = 0; j < dt3.Rows.Count; j++)
                {

                    cmbBoxCompound.Items.Add(lstCompoundNames[j]);

                }

                lblPosition.Y += 37;
                txtBoxPosition.Y += 37;
            }

            LoadDataIntoControls(compoundName);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (chkBoxColorless.Checked == true) {

                    chkBoxColorless.Checked = false;
                
                }
                btnColor.BackColor = colorDialog.Color;
                txtBoxColorName.Text = colorDialog.Color.Name;
                colorCode = colorDialog.Color.R + "," + colorDialog.Color.G + "," + colorDialog.Color.B;
            }
        }

        private void chkBoxColorless_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxColorless.CheckState == CheckState.Checked)
            {

                btnColor.Enabled = false;
                txtBoxColorName.Text = "Colorless";
                colorCode = "###,###,###";

            }
            else
            {
                btnColor.Enabled = true;
                txtBoxColorName.Clear();
                colorCode = Convert.ToString(colorDialog.Color.R) + "," + Convert.ToString(colorDialog.Color.G) + "," + Convert.ToString(colorDialog.Color.B);
                btnColor.BackColor = colorDialog.Color;
            }
        }



        private void ValidateControls()
        {

            if (Convert.ToBoolean((txtBoxChemicalCompound.Text).Trim() != ""))
            {

                nameOftheChemicalCompound = txtBoxChemicalCompound.Text;

            }
            else
            {

                throw new Exception("Please insert a valid name for the name of the chemical compound...!");
            }

            if (Convert.ToBoolean(cmbBoxState.SelectedItem != null))
            {

                state = cmbBoxState.SelectedItem as string;

            }
            else
            {

                throw new Exception("Please select the state of the compound...!");
            }

            ColorName = txtBoxColorName.Text;
            odor = txtBoxOdor.Text;


            for (int i = 0; i < lstColumnCodes.Count; i++)
            {
                foreach (ComboBox cb in this.pnlChemicalCompound.Controls.OfType<ComboBox>())
                {
                    if (Convert.ToBoolean(cb.Name == i.ToString()))
                    {

                        lstCompoundsOnReagent.Add(cb.Text);

                    }


                }
            }


            UpdateData();
            ResetControls();
            PopulateSelector();

        }

        private void ResetControls() 
        {
            cmbBoxSelector.Enabled = true;
            PopulateSelector();
            txtBoxChemicalCompound.Clear();
            txtBoxColorName.Clear();
            txtBoxOdor.Clear();
            pnlChemicalCompound.Dispose();
            lstColumnCodes.Clear();
            lstColumnNames.Clear();
            lstCompoundCodes.Clear();
            lstCompoundNames.Clear();
            lstCompoundsOnReagent.Clear();
       
        }


        private void UpdateData()
        {
           
            List<int> lstCompoundsOnReagentID = CreateCompoundIDList();
        
            dbo.UpdateChemicalCompound(compound_ID, nameOftheChemicalCompound, lstColumnCodes, lstCompoundsOnReagentID, state, colorCode, ColorName, odor);
        }

        private List<int> CreateCompoundIDList()
        {
            List<int> lstCompoundsOnReagentID = new List<int>();

            
            DataTable dt3 = dbo.GetTable("Compound_Data");

            List<int> lstCompoundCodes = new List<int>();
            List<string> lstCompoundNames = new List<string>();

            for (int i = 0; i < dt3.Rows.Count; i++)
            {

                lstCompoundCodes.Add(Convert.ToInt32(dt3.Rows[i].ItemArray[0]));
                lstCompoundNames.Add(Convert.ToString(dt3.Rows[i].ItemArray[1]));

            }

            for (int i = 0; i < lstCompoundsOnReagent.Count; i++)
            {

                if (lstCompoundsOnReagent[i].Trim() == "")
                {

                    lstCompoundsOnReagentID.Add(0000);

                }
                else
                {

                    int index = lstCompoundNames.IndexOf(lstCompoundsOnReagent[i]);
                    lstCompoundsOnReagentID.Add(lstCompoundCodes[index]);

                }

            }

            return lstCompoundsOnReagentID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                ValidateControls();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }


        private void cmbBoxSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cmbBoxSelector.SelectedItem.ToString();
            LoadControls(s);
            cmbBoxSelector.Enabled = false;
        }


    }
}
