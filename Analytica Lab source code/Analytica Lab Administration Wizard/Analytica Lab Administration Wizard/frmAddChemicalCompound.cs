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
    public partial class frmAddChemicalCompound : Form
    {
        public frmAddChemicalCompound()
        {
            InitializeComponent();
        }




        private void frmAddChemicalCompound_Load(object sender, EventArgs e)
        {
            //DB_Operator dbo = new DB_Operator();
            //dbo.LoadOldData();
            
            LoadControls();
        }

        List<string> lstColumnCodes = new List<string>();
        List<string> lstColumnNames = new List<string>();


        private void LoadControls() {

            DB_Operator dbo = new DB_Operator();
            DataTable dt1 = dbo.GetTable("Reagent_Data");
            DataTable dt2 = dbo.GetTable("Operation_Data");
            DataTable dt3 = dbo.GetTable("Compound_Data");

            foreach (DataRow dr in dt1.Rows) {

                lstColumnCodes.Add(dr.ItemArray[1] as string);
                lstColumnNames.Add(dr.ItemArray[2] as string);
            
            }

            foreach (DataRow dr in dt2.Rows) {

                lstColumnCodes.Add(dr.ItemArray[1] as string);
                lstColumnNames.Add(dr.ItemArray[2] as string);
            
            }


            Point lblPosition = new Point(40, 63);
            Point txtBoxPosition = new Point(237, 60);

            for (int i = 0; i < lstColumnCodes.Count; i++) {


                Label lblReagent = new Label();
                lblReagent.Size = new System.Drawing.Size(194, 15);
                
                lblReagent.Name = "lblReagent_" + i.ToString();               
                lblReagent.Location = lblPosition;
                this.pnlChemicalCompound.Controls.Add(lblReagent);

                lblReagent.Text = lstColumnNames[i];

                ComboBox cmbBoxCompound=new ComboBox();
                cmbBoxCompound.Name = i.ToString();
                cmbBoxCompound.Location=txtBoxPosition;
                this.pnlChemicalCompound.Controls.Add(cmbBoxCompound);

                for (int j = 0; j < dt3.Rows.Count; j++) {

                    cmbBoxCompound.Items.Add(dt3.Rows[j].ItemArray[1]);
                
                }

                lblPosition.Y += 37;
                txtBoxPosition.Y += 37;
            }


        }



        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK) {

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
            else {
                btnColor.Enabled = true;
                txtBoxColorName.Clear();
                colorCode = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                ValidateControls();
                MessageBox.Show("Compound added to database successfully...!");

                this.Close();

            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
            
            }
        }

        string nameOftheChemicalCompound;
        string state;
        string colorCode = "###,###,###";
        string ColorName;
        string odor;
        List<string> lstCompoundsOnReagent = new List<string>();
            
            private void ValidateControls() {

            if (Convert.ToBoolean((txtBoxChemicalCompound.Text).Trim() != ""))
            {

                nameOftheChemicalCompound = txtBoxChemicalCompound.Text;

            }
            else
            {

                throw new Exception("Please insert a valid name for the name of the chemical compound...!");
            }

            if (Convert.ToBoolean(cmbBoxState.SelectedItem !=null))
            {

                state = cmbBoxState.SelectedItem as string;

            }
            else {

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


            InsertData();

        }

            private void InsertData() {

                DB_Operator dbo = new DB_Operator();

                List<int> lstCompoundsOnReagentID = CreateCompoundIDList();
                dbo.InsertChemicalCompound(nameOftheChemicalCompound,lstColumnCodes,lstCompoundsOnReagentID, state, colorCode, ColorName, odor);

            }

            

            private List<int> CreateCompoundIDList() 
            {
                List<int> lstCompoundsOnReagentID = new List<int>();

                DB_Operator dbo=new DB_Operator();
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

    }
}
