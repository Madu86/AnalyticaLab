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
    public partial class frmDBWizard : Form
    {
        public frmDBWizard()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (radioBtnAddNewCompound.Checked == true) {

                frmAddChemicalCompound frmAddCC = new frmAddChemicalCompound();
                frmAddCC.ShowDialog();

            }
            else if (radioBtnAddNewReagent.Checked == true) {

                frmReagentWizard frmRW = new frmReagentWizard();
                frmRW.ShowDialog();

            }
            else if (radioBtnAddNewOperation.Checked == true) {

                frmOperations frmOp = new frmOperations();
                frmOp.ShowDialog();

            }
            else if (radioBtnEditChemicalCompound.Checked == true)
            {

                editChemicalCompound frmECC = new editChemicalCompound();
                frmECC.ShowDialog();

            }
            else if (radioBtnBckUp.Checked == true) {

                frmBackUpDB frmbckup = new frmBackUpDB();
                frmbckup.ShowDialog();

            }
            else if (radioBtnRestoreDB.Checked == true) {

                frmRestoreDB frmrestoreDB = new frmRestoreDB();
                frmrestoreDB.ShowDialog();
            
            }

            else
            {

                frmViewChemical_CompoundsDT frmViewCC = new frmViewChemical_CompoundsDT();
                frmViewCC.ShowDialog();

            }
        }
    }
}
