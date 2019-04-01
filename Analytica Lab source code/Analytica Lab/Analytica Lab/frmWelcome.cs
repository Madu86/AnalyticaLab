using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analytica_Lab
{
    public partial class frmWelcome : Form
    {

        #region ~Class Level Variables~

        frmMain mainForm;
        OpenFileDialog ofd = new OpenFileDialog();

        #endregion

        public frmWelcome(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #region ~ User Interface Operations~

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radioBtnOpenSample.Checked == true) 
            {


                DialogResult dr = ofd.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK) 
                {

                    FileOperator fo = new FileOperator();
                    var lstTreeViewData = fo.ReadTextFile(ofd.FileName);

                    OpenFile(lstTreeViewData);
                    this.Close();
                }

                
           
            }
            else if (radioBtnCustomSample.Checked == true)
            {

                frmCustomSample customSample = new frmCustomSample(mainForm);
                customSample.ShowDialog();
                this.Close();

            }
            else {

                RandomSample rndSmple = new RandomSample(mainForm);
                rndSmple.CreateRandomSample(frmOptions.NumberOfSpeciesInRandomSample);
                this.Close();
            
            }

        }

        public void OpenFile(List<List<string>> lstTreeViewData) 
        {
            List<string> treeViewSampleNames = lstTreeViewData[0];
            List<string> treeViewNodePaths = lstTreeViewData[1];
            List<string> treeViewNodeIndices = lstTreeViewData[2];

            PopulateTreeView(mainForm.treeViewSample, treeViewNodePaths, treeViewSampleNames,treeViewNodeIndices);

        
        }


        public void PopulateTreeView(TreeView treeView, List<string> paths, List<string> nodeName, List<string> nodeIndex)
        {
            TreeNode lastNode = null;
            int a=0;

            

            foreach (string path in paths)
            {

                if (lastNode == null)
                {

                CustomTreeNode treeNode = new CustomTreeNode();

                    treeNode.SampleIndex = Convert.ToInt32(nodeIndex[a]);
                    treeNode.Text = nodeName[a];
                    treeView.Nodes.Add(treeNode);
                    lastNode = treeNode;
                    
                }
                else
                {
                    lastNode = lastNode.Nodes.Add(path, nodeName[a]);

                    int index = treeView.Nodes.IndexOf(lastNode);

                    CustomTreeNode treeNode = new CustomTreeNode();

                    treeNode.SampleIndex = Convert.ToInt32(nodeIndex[a]);

                    lastNode.Parent.Nodes.Add(treeNode);

                    treeView.Nodes.RemoveAt(index);

                    lastNode = treeNode;



                }


                a += 1;
            }
            


   

        }


        private void frmWelcome_Load(object sender, EventArgs e)
        {
            this.radioBtnRandomSample.Checked = true;
        }

        #endregion

    }
}
