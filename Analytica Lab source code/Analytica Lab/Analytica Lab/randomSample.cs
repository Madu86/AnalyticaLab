using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace Analytica_Lab
{
    class RandomSample
    {
        frmMain mainForm;
        public RandomSample(frmMain mainForm){

            this.mainForm = mainForm;
        
        }

        public void CreateRandomSample(int numOfCompounds) {



            DB_Operator dbo = new DB_Operator();
            DataTable dt = dbo.GetTable("Compound_Data");
            
            List<string> lstCompounds = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                var compound = (string)dt.Rows[i].ItemArray[1];
                if (!compound.Contains('_'))
                {
                    lstCompounds.Add(compound);
                }

            }


            Random r = new Random();
            List<string> lstSample= new List<string>();

            int j=0;
            while (lstCompounds.Count > 0 && j<numOfCompounds ) {

                int index = r.Next(lstCompounds.Count);
                lstSample.Add(lstCompounds.ElementAt(index));
                lstCompounds.RemoveAt(index);
                j+=1;
            }

            Sample.lst_Samples.Add(lstSample);
            frmCustomSample fc = new frmCustomSample(mainForm);
            fc.PopulateAesthetics(lstSample);

        }

    }
}
