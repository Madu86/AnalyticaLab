using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Analytica_Lab_Administration_Wizard
{
    public partial class frmBackUpDB : Form
    {
        public frmBackUpDB()
        {
            InitializeComponent();
        }

        private void btnOpenLocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK) 
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "University of Colombo\\Analytica Lab\\");
      
                txtBoxLocation.Text = sfd.FileName;
                try{
                
                  
                    File.Copy(filePath+"Analytica_Lab.mdf", sfd.FileName + ".mdf");
                    File.Copy(filePath+"Analytica_Lab_log.ldf", sfd.FileName + ".ldf");
                    MessageBox.Show("Database backup process completed successfully...!");
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                
                }

                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
