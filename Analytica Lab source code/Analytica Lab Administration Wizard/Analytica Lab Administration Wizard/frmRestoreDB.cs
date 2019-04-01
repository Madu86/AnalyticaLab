using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Analytica_Lab_Administration_Wizard
{
    public partial class frmRestoreDB : Form
    {
        public frmRestoreDB()
        {
            InitializeComponent();
        }


        private void btnOpenMdfLocation_Click(object sender, EventArgs e)
        {

            OpenFile("Sqlserver Data Files (*.mdf)|*.mdf", txtBoxMdfLocation);
        }

        private void btnOpenLdfLocation_Click(object sender, EventArgs e)
        {

            OpenFile("Sqlserver Log Files (*.ldf)|*.ldf", txtBoxLdfLocation);
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                PerformFileOperation();
                MessageBox.Show("Database restored successfully! The Analytica Lab Administration Wizard will now exit...");
                Application.Exit();

                Process.Start("Analytica Lab.exe");
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void OpenFile(string filter, TextBox tb)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;
            DialogResult dr = ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                tb.Text = ofd.FileName;

            }

        }

        private void PerformFileOperation()
        {
            //Get the path of the application folder.. 
            //string currentPath = Directory.GetCurrentDirectory();
            ////define a path to create a new directory "temp"...
      
            string currentPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "University of Colombo\\Analytica Lab\\");
            string filePath = Path.Combine(currentPath, "temp");


            //if the temp folder already exists, delete it.. 
            if (Directory.Exists(filePath))
            {
                Directory.Delete(filePath,true);

            }

            //create temp directory.. 
            Directory.CreateDirectory(filePath);

            //copy restoring datafiles into application folder..
            File.Copy(txtBoxMdfLocation.Text, filePath + "\\Analytica_Lab.mdf");
            File.Copy(txtBoxLdfLocation.Text, filePath + "\\Analytica_Lab_log.ldf");


            //check whether the new database is compatible.. if not, delete new data files and rollback process..
            bool isDatabaseCompatible = true;

      

            using (DB_Operator dbo = new DB_Operator())           
            {
                isDatabaseCompatible = dbo.TestDataBase();
                
            }



            if (isDatabaseCompatible == true) 
            {

                File.Delete(currentPath + "\\Analytica_Lab.mdf");
                File.Delete(currentPath + "\\Analytica_Lab_log.ldf");

                File.Copy(txtBoxMdfLocation.Text, currentPath + "\\Analytica_Lab.mdf");
                File.Copy(txtBoxLdfLocation.Text, currentPath + "\\Analytica_Lab_log.ldf");

            }


        }


    }
}
