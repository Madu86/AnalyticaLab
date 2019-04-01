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
    public partial class frmSampling : Form
    {
        frmMain mainForm;

        public frmSampling(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public frmSampling(string sampleName,frmMain mainForm)
        {
            InitializeComponent();
         
            this.txtBoxSampleName.Text = sampleName;
            this.mainForm = mainForm;

        }

        private void btnSampleName_Click(object sender, EventArgs e)
        {
            try
            {
                CreateNewSample();
                this.Close();

            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
              
            }


           
        }

        //Creates nodes in sampleTreeView...~ When sample name is entered through UI...

        private void CreateNewSample() {

            if (txtBoxSampleName.Text == "")
            {

                throw new Exception("Please enter a name for the sample...!");
            }
            else
            {
                Sample smpl = new Sample(mainForm);
                smpl.CreateNewSample(txtBoxSampleName.Text);
               

            }
        }


    }


    //Define an inherited tree node class which can store reference indices to sample list.. 
    public class CustomTreeNode:TreeNode
    {

        private int sampleIndex;

        public int SampleIndex {

            get { return sampleIndex; }
            set { sampleIndex = value; }
        
        }
    
    }


}
