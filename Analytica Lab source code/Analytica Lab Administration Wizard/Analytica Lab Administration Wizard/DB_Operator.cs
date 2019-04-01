using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Analytica_Lab_Administration_Wizard
{
    class DB_Operator:IDisposable
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        DataTable dt;

        public DB_Operator() 
        {


            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "University of Colombo\\Analytica Lab\\Analytica_Lab.mdf");

            string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + filePath + ";Integrated Security=True;Connect Timeout=30;User Instance=True";

            con = new SqlConnection(connectionString);           
        }

        public virtual void Dispose()
        {

           con.Dispose();
        }

        //Returns all elements items in a requested table...
        public DataTable GetTable(string tableName) {

            con.Open();
            cmd = new SqlCommand("SELECT * FROM " + tableName, con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            dt = ds.Tables[0];

            return dt;
        }

        //Returns all elements items in a requested table...
        public DataTable GetTable(string tableName,SqlConnection cnctn)
        {
           
            cnctn.Open();
            cmd = new SqlCommand("SELECT * FROM " + tableName, cnctn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            cnctn.Close();
            dt = ds.Tables[0];

            return dt;
        }

        public DataRow GetRecord(string tableName, int id) {
            
 
            con.Open();
            cmd = new SqlCommand("SELECT * FROM " + tableName + " WHERE Compound_ID ='" + id + "'", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            
            con.Close();
            DataRow dr = ds.Tables[0].Rows[0];

            return dr;

        
        }

        public void InsertReagentOrOperation(string tableName,string Column_Code,string Column_Name,string Image_Link, string reagentOrOpCode, string reagentOrOpName,string imageLink) {

            con.Open();
            cmd = new SqlCommand("INSERT INTO " + tableName + "(" + Column_Code + "," + Column_Name + "," + Image_Link + " ) VALUES ('" + reagentOrOpCode + "','" + reagentOrOpName + "','" + imageLink + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            InsertReagentColumn(reagentOrOpCode);
        
        }

        public void InsertReagentOrOperation(string tableName, string Column_Code, string Column_Name, string reagentOrOpCode, string reagentOrOpName)
        {

            con.Open();
            cmd = new SqlCommand("INSERT INTO " + tableName + "(" + Column_Code + "," + Column_Name +  " ) VALUES ('" + reagentOrOpCode + "','" + reagentOrOpName + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            InsertReagentColumn(reagentOrOpCode);

        }


        private void InsertReagentColumn(string columnName) {

            con.Open();
            cmd = new SqlCommand("ALTER TABLE Chemical_Compounds ADD " + columnName + " INT NOT NULL DEFAULT 0 WITH VALUES", con);
            cmd.ExecuteNonQuery();
            con.Close();
        
        }


        public void RemoveReagentOrOperation(string tableName,string Column_Code, string reagentOrOpCode)
        {


            con.Open();
            cmd = new SqlCommand("DELETE FROM "+tableName+" WHERE "+Column_Code+" = '" + reagentOrOpCode + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            RemoveReagentColumn(reagentOrOpCode);
        
        } 


        private void RemoveReagentColumn(string columnName)
        {

            //con.Open();

            //cmd = new SqlCommand("UPDATE Chemical_Compounds SET " + columnName + " = NULL", con);
            //cmd.ExecuteNonQuery();

            //cmd = new SqlCommand("ALTER TABLE Chemical_Compounds DROP COLUMN " + columnName, con);
            //cmd.ExecuteNonQuery();
            //con.Close();
        
        }

        public void UpdateReagentOrOperation(string tableName,string Column_Code, string Column_Name,string Image_Link, string reagentOrOpCode, string reagentOrOpName,string imageLink)
        {

            con.Open();
            cmd = new SqlCommand("UPDATE " + tableName + " SET " + Column_Name + "='" + reagentOrOpName + "," + Image_Link + "='" + imageLink + "' WHERE " + Column_Code + "='" + reagentOrOpCode + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void UpdateReagentOrOperation(string tableName, string Column_Code, string Column_Name, string reagentOrOpCode, string reagentOrOpName)
        {

            con.Open();
            cmd = new SqlCommand("UPDATE " + tableName + " SET " + Column_Name + "='" + reagentOrOpName + "' WHERE " + Column_Code + "='" + reagentOrOpCode + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void InsertChemicalCompound(string compoundName,List<string> lstColumnCodes, List<int> lstColumnValues,string state,string colorCode, string colorName, string odor)
        {

            con.Open();
            cmd = new SqlCommand("INSERT INTO Compound_Data (Compound_Name) VALUES ('" + compoundName + "'); SELECT SCOPE_IDENTITY();", con);
            var id = cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO Physical_Properties (Compound_ID, State, Color_Code,Color_Name, Odor) VALUES ('" + id + "','" + state + "','" + colorCode + "','" + colorName + "','" + odor + "')", con);          
            
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(BuildInsertCommand(Convert.ToInt32(id), lstColumnCodes, lstColumnValues), con);

            cmd.ExecuteNonQuery();

            con.Close();
        
        }

        public void UpdateChemicalCompound(int compoundID, string compoundName, List<string> lstColumnCodes, List<int> lstColumnValues, string state, string colorCode, string colorName, string odor)
        
        {

            con.Open();
            cmd = new SqlCommand("UPDATE Compound_Data SET Compound_Name = '" + compoundName + "' WHERE Compound_ID = '"+compoundID+"'", con);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("UPDATE Physical_Properties SET State = '" + state + "', Color_Code = '" + colorCode + "', Color_Name = '" + colorName + "',Odor = '" + odor + "' WHERE Compound_ID = '" + compoundID + "'", con);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(BuildUpdateCommand(compoundID, lstColumnCodes, lstColumnValues), con);
            cmd.ExecuteNonQuery();

            con.Close();

        } 


        public string BuildInsertCommand(int compoundCode, List<string> lstColumnNames, List<int> lstValues)
            {

            string command="INSERT INTO Chemical_Compounds (Compound_ID";

            foreach (string sn in lstColumnNames) {

                command += ","+sn;
            
            }

            command += ") VALUES('" + compoundCode.ToString() + "'";

            foreach (int sv in lstValues) {

                command += ",'" + sv.ToString() + "'";
            
            }

            command += ")";
            return command;
            
        
        }

        public string BuildUpdateCommand(int compoundID, List<string> lstColumnNames, List<int> lstValues)
        {

            string command = "UPDATE Chemical_Compounds SET ";

            int a = 0;
            for (int i = 0; i < lstColumnNames.Count-1; i++) {

                command += lstColumnNames[a] + "=" + "'" + lstValues[a].ToString() + "',";

                a += 1;
            }
            command += lstColumnNames[a] + "= '" + lstValues[a].ToString() + "' WHERE Compound_ID = '" + compoundID + "'";

            return command;
        }


        //public void LoadOldData()
        //{

        //    SqlConnection oldCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database_Project.Properties.Settings.Analytica_Lab_OldConnectionString"].ConnectionString);

        //    DataTable dt = GetOldDataTable("Physical_Properties",oldCon);

        //    DataTable dt_Reagent_Names = GetTable("Reagent_Data");
        //    DataTable dt_Operation_Names = GetTable("Operation_Data");

        //    List<string> lst_ColumnNames = new List<string>();
        //    List<int> lst_ColumnValues = new List<int>();

        //    foreach (DataRow dr in dt_Reagent_Names.Rows)
        //    {

        //        var columnName = Convert.ToString(dr.ItemArray[1]);
        //        lst_ColumnNames.Add(columnName);

        //        lst_ColumnValues.Add(0);
        //    }

        //    foreach (DataRow dr in dt_Operation_Names.Rows)
        //    {

        //        var columnName = Convert.ToString(dr.ItemArray[1]);
        //        lst_ColumnNames.Add(columnName);
        //        lst_ColumnValues.Add(0);

        //    }


        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        var compoundName=Convert.ToString(dr.ItemArray[1]);
        //         var compoundState=Convert.ToString(dr.ItemArray[2]);
        //        var colorCode=Convert.ToString(dr.ItemArray[3]);

        //        InsertChemicalCompound(compoundName, lst_ColumnNames, lst_ColumnValues, compoundState, colorCode, "", "");

        //    }

            
        
        //}


        private DataTable GetOldDataTable(string tableName, SqlConnection oldCon)
        {

            oldCon.Open();
            cmd = new SqlCommand("SELECT * FROM " + tableName, oldCon);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            oldCon.Close();
            dt = ds.Tables[0];

            return dt;
        }


        public void UpdateOldData() {

            SqlConnection oldCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database_Project.Properties.Settings.Analytica_Lab_OldConnectionString"].ConnectionString);
            dt = GetOldDataTable("Chemical_Compounds", oldCon);

        
        }



        //Checks whether an existing database is compatible with analytica lab...
        public bool TestDataBase()
        {
            bool isConnectionSuccessful = false;

            //Get the path of the application folder.. 
            string currentPath = Directory.GetCurrentDirectory();
            //define a path to create a new directory "temp"...
             string filePath = Path.Combine(currentPath, "temp");

            SqlConnectionStringBuilder scsc = new SqlConnectionStringBuilder();
        
            scsc.DataSource = ".\\SQLEXPRESS";
            scsc.AttachDBFilename = filePath + "\\Analytica_Lab.mdf";
            scsc.IntegratedSecurity = true;
            scsc.ConnectTimeout = 30;
            scsc.UserInstance = true;

            SqlConnection cnctn = new SqlConnection(scsc.ConnectionString);
            try
            {
               
                dt = GetTable("Compound_Data",cnctn);
                dt = GetTable("Physical_Properties", cnctn);
                dt = GetTable("Chemical_Compounds", cnctn);
                dt = GetTable("Reagent_Data", cnctn);
                dt = GetTable("Operation_Data", cnctn);
                

                isConnectionSuccessful = true;
            }
            catch
            {

            }

            return isConnectionSuccessful;
        
        }



    }
}
