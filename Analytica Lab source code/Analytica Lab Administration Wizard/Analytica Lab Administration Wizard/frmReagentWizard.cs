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
    public partial class frmReagentWizard : Form
    {
        public frmReagentWizard()
        {
            InitializeComponent();
            grpBoxAddReagent.Hide();
            this.Size = new Size(392, 300);
        }

        List<string> lstReagentCodes = new List<string>();
        DB_Operator dbo = new DB_Operator();
        bool isNewReagent = true;

        private void LoadReagentData()
        {

            if (lstBoxReagents.Items.Count != 0)
            {

                for (int i = 0; i < lstBoxReagents.Items.Count; i++)
                {

                    lstBoxReagents.Items.RemoveAt(i);
                }

                lstReagentCodes.Clear();
            }


            DataTable dt = dbo.GetTable("Reagent_Data");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                lstBoxReagents.Items.Add(dt.Rows[i].ItemArray[2]);
                lstReagentCodes.Add(dt.Rows[i].ItemArray[1] as string);

            }
            lstBoxReagents.Refresh();

        }

        private void btnRemoveReagent_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove the selected Reagent from the database?", "", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                int index = lstBoxReagents.SelectedIndex;
                dbo.RemoveReagentOrOperation("Reagent_Data", "Reagent_Code", lstReagentCodes[index]);
                lstBoxReagents.Items.RemoveAt(index);
                lstReagentCodes.RemoveAt(index);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grpBoxAddReagent.Location = new Point(34, 242);
            grpBoxAddReagent.Show();
            try
            {
                string selectedText = lstBoxReagents.SelectedItem as string;

                this.Size = new System.Drawing.Size(392, 445);

                this.txtBoxReagentName.Text = selectedText;

                isNewReagent = false;

            }
            catch
            {

            }
        }

        private void ValidateInput()
        {

            if (this.txtBoxReagentName.Text.Trim() == null)
            {

                throw new Exception("Please insert a proper reagent name...!");

            }
            else
            {

                if (isNewReagent == true)
                {
                    
                    bool isExisting = false;
                    string reagentCode = "";

                    do
                    {
                        reagentCode = GenerateCode(6);
                        foreach (string s in lstReagentCodes)
                        {

                            if (s.Trim() == reagentCode.Trim())
                            {
                                isExisting = true;
                                break;
                            }

                        }
                        
                    } while (isExisting == true);



                    dbo.InsertReagentOrOperation("Reagent_Data", "Reagent_Code", "Reagent_Name", "R_"+reagentCode, txtBoxReagentName.Text);
                    txtBoxReagentName.Clear();
                    grpBoxAddReagent.Hide();
                    this.Size = new Size(392, 300);
                    //throw new Exception("Reagent added to the database successfully...!");
                }
                else
                {

                    int index = lstBoxReagents.SelectedIndex;

                    dbo.UpdateReagentOrOperation("Reagent_Data", "Reagent_Code", "Reagent_Name", lstReagentCodes[index], txtBoxReagentName.Text);
                    txtBoxReagentName.Clear();
                    grpBoxAddReagent.Hide();
                    this.Size = new Size(392, 300);


                    //throw new Exception("Reagent name changed successfully...!");
                }

            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();
                LoadReagentData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddReagent_Click(object sender, EventArgs e)
        {
            grpBoxAddReagent.Location = new Point(34, 242);
            grpBoxAddReagent.Show();

            try
            {

                this.Size = new System.Drawing.Size(392, 445);

                isNewReagent = true;
            }
            catch
            {

            }


            
        }

        private void frmReagentWizard_Load(object sender, EventArgs e)
        {
            LoadReagentData();
        }

        private static readonly string allowedCharacters = "abcdefghijklmnopqrstuvwxyz0123456789";

        public static string GenerateCode(int length) 
        {

            const int from = 0;
            int to = allowedCharacters.Length;
            Random r = new Random();

            StringBuilder qs = new StringBuilder();
            for (int i = 0; i < length; i++) {

                qs.Append(allowedCharacters.Substring(r.Next(from, to), 1));
            
            }
            return qs.ToString();

        }

    }
}
