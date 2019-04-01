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
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        #region ~Class level variables~

        private static int numOfSpeciesInRndmSmlng = 4;

        #endregion

        public static int NumberOfSpeciesInRandomSample {
        
            get {return numOfSpeciesInRndmSmlng;}
            set { numOfSpeciesInRndmSmlng = value; }

        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            try 
            { 
                validateOptions();
                this.Close();
            }
            catch {
                
            }
        }

        private void validateOptions() {

            try
            {

                FileOperator fo = new FileOperator();
                fo.ModifyXML("Settings.xml", "NumOfSpeciesInRndmSmple",numericUpDownRndSmplng.Value.ToString());
                NumberOfSpeciesInRandomSample = Convert.ToInt32(numericUpDownRndSmplng.Value);
                
            }
            catch
            {

                throw new Exception("Oops.. Something went wrong with saving your settings...!");
            }
        
        }


        private void frmOptions_Load(object sender, EventArgs e)
        {
            numericUpDownRndSmplng.Value = NumberOfSpeciesInRandomSample;
        }
    }
}
