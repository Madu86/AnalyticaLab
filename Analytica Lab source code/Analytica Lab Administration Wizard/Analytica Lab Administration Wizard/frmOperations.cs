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
    public partial class frmOperations : Form
    {
        public frmOperations()
        {
            InitializeComponent();

            grpBoxAddOperation.Hide();
            this.Size = new Size(392, 300);
        }

        List<string> lstOperationCodes = new List<string>();
        List<string> lstImageLinks = new List<string>();

       
        bool isNewOperation = true;

        private void frmOperations_Load(object sender, EventArgs e)
        {
            LoadOperationData();
        }

        private void LoadOperationData()
        {

            if (lstBoxOperations.Items.Count != 0)
            {

                lstBoxOperations.Items.Clear();
                lstOperationCodes.Clear();
                lstImageLinks.Clear();
            }

            lstBoxOperations.Refresh();
            DB_Operator dbo = new DB_Operator();
            DataTable dt = dbo.GetTable("Operation_Data");

            for (int i = 0; i < dt.Rows.Count; i++)
            {


                lstBoxOperations.Items.Add(dt.Rows[i].ItemArray[2] as string);
                lstOperationCodes.Add(dt.Rows[i].ItemArray[1] as string);
                lstImageLinks.Add(dt.Rows[i].ItemArray[3] as string);

            }
            lstBoxOperations.Refresh();

        }



        private void btnRemoveOperation_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove the selected operation from the database?", "", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                int index = lstBoxOperations.SelectedIndex;
                DB_Operator dbo = new DB_Operator();
                dbo.RemoveReagentOrOperation("Operation_Data", "Operation_Code", lstOperationCodes[index]);
                lstBoxOperations.Items.RemoveAt(index);
                lstOperationCodes.RemoveAt(index);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grpBoxAddOperation.Location = new Point(34, 242);

            grpBoxAddOperation.Show();

            this.Size = new System.Drawing.Size(382, 414);

            string selectedText = lstBoxOperations.SelectedItem as string;

            this.txtBoxOperationName.Text = selectedText;

            isNewOperation = false;

        }

        private void ValidateInput()
        {

            if (this.txtBoxOperationName.Text.Trim() == null)
            {

                throw new Exception("Please insert a proper reagent name...!");

            }
            else
            {

                if (isNewOperation == true)
                {

                    bool isExisting = false;
                    string operationCode = "";

                    do
                    {
                        operationCode = frmReagentWizard.GenerateCode(6);
                        foreach (string s in lstOperationCodes)
                        {

                            if (s.Trim() == operationCode.Trim())
                            {
                                isExisting = true;
                                break;
                            }

                        }

                    }
                    while (isExisting == true);


                    DB_Operator dbo = new DB_Operator();
                    dbo.InsertReagentOrOperation("Operation_Data", "Operation_Code", "Operation_Name","Image_Link", "Op_" + operationCode, txtBoxOperationName.Text,"operation.png");
                    txtBoxOperationName.Clear();
                    grpBoxAddOperation.Hide();
                    this.Size = new Size(392, 300);

                }
                else
                {

                    int index = lstBoxOperations.SelectedIndex;
                    DB_Operator dbo = new DB_Operator();
                    dbo.UpdateReagentOrOperation("Operation_Data", "Operation_Code", "Operation_Name",  lstOperationCodes[index], txtBoxOperationName.Text);
                    txtBoxOperationName.Clear();
                    grpBoxAddOperation.Hide();
                    this.Size = new Size(392, 300);

                }

            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

                ValidateInput();
                LoadOperationData();

        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            grpBoxAddOperation.Location = new Point(34, 242);
            grpBoxAddOperation.Show();
            try
            {

                this.Size = new System.Drawing.Size(382, 414);

                isNewOperation = true;
            }
            catch
            {

            }
        }


    }



}
