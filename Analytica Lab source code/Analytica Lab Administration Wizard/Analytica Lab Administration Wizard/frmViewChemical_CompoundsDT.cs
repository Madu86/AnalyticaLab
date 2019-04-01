using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Analytica_Lab_Administration_Wizard
{
    public partial class frmViewChemical_CompoundsDT : Form
    {
        int columnWidth;
        public frmViewChemical_CompoundsDT()
        {
            InitializeComponent();
        }

        DataGrid dg = new DataGrid();
        DB_Operator db = new DB_Operator();

        private void frmViewChemical_CompoundsDT_Load(object sender, EventArgs e)
        {

            this.pnlDGView_2.Controls.Add(dg);
            dg.Dock = DockStyle.Fill;
            columnWidth = dg.PreferredColumnWidth;
            dg.Font = DefaultFont;
        }
        



        private void toolStrip_BtnDGView_Click(object sender, EventArgs e)
        {

            try
            {
                if (toolStripCmbBox.SelectedIndex == 0)
                {

                    DataTable dt = db.GetTable("Compound_Data");
                    dg.PreferredColumnWidth = columnWidth * 2;
                    dg.DataSource = dt;

                    dg.Refresh();
                }
                else if (toolStripCmbBox.SelectedIndex == 1)
                {

                    DataTable dt = db.GetTable("Reagent_Data");
                    dg.PreferredColumnWidth = columnWidth * 2;
                    dg.DataSource = dt;

                    dg.Refresh();
                }
                else if (toolStripCmbBox.SelectedIndex == 2)
                {

                    DataTable dt = db.GetTable("Operation_Data");
                    dg.PreferredColumnWidth = columnWidth * 2;
                    dg.DataSource = dt;

                    dg.Refresh();
                }
                else if (toolStripCmbBox.SelectedIndex == 3)
                {

                    DataTable dt = db.GetTable("Chemical_Compounds");
                    dg.PreferredColumnWidth = columnWidth;
                    dg.DataSource = dt;

                    dg.Refresh();

                }
                else if (toolStripCmbBox.SelectedIndex == 4)
                {

                    DataTable dt = db.GetTable("Physical_Properties");
                    dg.PreferredColumnWidth = columnWidth * 2;
                    dg.DataSource = dt;

                    dg.Refresh();

                }

            }
            catch
            {


            }
        }
        

    }
}
