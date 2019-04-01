using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;

namespace Analytica_Lab
{
    public partial class frmCustomSample : Form
    {
        frmMain mainForm;
        public frmCustomSample(frmMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        DB_Operator dbo = new DB_Operator();

        private void frmCustomSample_Load(object sender, EventArgs e)
        {



            DataTable dt = dbo.GetTable("Compound_Data");

            //Load all the cations into the list box..

            for (int i = 0; i < dt.Rows.Count; i++) {

                var compound = (string)dt.Rows[i].ItemArray[1];
                if (!compound.Contains('_'))
                {
                    lstBoxCationsFromDB.Items.Add(compound);
                 }
                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {

                lstBoxCationsSelected.Items.Add(lstBoxCationsFromDB.SelectedItem);
                lstBoxCationsFromDB.Items.Remove(lstBoxCationsFromDB.SelectedItem);
                lstBoxCationsFromDB.Refresh();
                lstBoxCationsSelected.Refresh();
            
            }
            catch { }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            try {
                lstBoxCationsFromDB.Items.Add(lstBoxCationsSelected.SelectedItem);
                lstBoxCationsSelected.Items.Remove(lstBoxCationsSelected.SelectedItem);
                lstBoxCationsFromDB.Refresh();
                lstBoxCationsSelected.Refresh();
          
            }
            catch {}

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Create a new list and add selected custom cations... 

            List<string> lstOriginalSample = new List<string>();            

            foreach (object o in lstBoxCationsSelected.Items) {
            
            lstOriginalSample.Add((string)o);
            
            }

            Sample.lst_Samples.Add(lstOriginalSample);

            PopulateAesthetics(lstOriginalSample);

            this.Close();
        }

        //populate color, state & image lists... 
        public void PopulateAesthetics(List<string> lstOriginalSample) {


            List<string> lstColors = new List<string>();
            List<string> lstState = new List<string>();


            DataTable dt1 = dbo.GetTable("Compound_Data");
            DataTable dt = dbo.GetTable("Physical_Properties");
           

            foreach (string s in lstOriginalSample)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {

                    if (Convert.ToBoolean(s.Trim() == (Convert.ToString(dt1.Rows[i].ItemArray[1])).Trim())) 
                    {

                        int index = Convert.ToInt32(dt1.Rows[i].ItemArray[0]);
                        DataRow dr = dbo.GetRecord("Physical_Properties", index);

                        lstState.Add(Convert.ToString(dr.ItemArray[1]));
                        lstColors.Add(Convert.ToString(dr.ItemArray[2]));
                        break;
                    }

                }

            }



            Sample.lst_Colors.Add(lstColors);
            Sample.lst_State.Add(lstState);

            //Populate the image list...
            MediaOperator mop = new MediaOperator(mainForm);

            Sample.lst_Images.Add(mop.GetImage(lstOriginalSample, lstState, lstColors));

        }



    }
}
