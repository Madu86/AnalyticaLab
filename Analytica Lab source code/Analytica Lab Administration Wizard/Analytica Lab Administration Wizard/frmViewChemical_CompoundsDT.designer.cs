namespace Analytica_Lab_Administration_Wizard
{
    partial class frmViewChemical_CompoundsDT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewChemical_CompoundsDT));
            this.pnlDGView = new System.Windows.Forms.Panel();
            this.toolStripDGView = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCmbBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip_BtnDGView = new System.Windows.Forms.ToolStripButton();
            this.pnlDGView_2 = new System.Windows.Forms.Panel();
            this.toolTipDGView = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDGView.SuspendLayout();
            this.toolStripDGView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDGView
            // 
            this.pnlDGView.Controls.Add(this.toolStripDGView);
            this.pnlDGView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDGView.Location = new System.Drawing.Point(0, 0);
            this.pnlDGView.Name = "pnlDGView";
            this.pnlDGView.Size = new System.Drawing.Size(736, 68);
            this.pnlDGView.TabIndex = 3;
            // 
            // toolStripDGView
            // 
            this.toolStripDGView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripCmbBox,
            this.toolStrip_BtnDGView});
            this.toolStripDGView.Location = new System.Drawing.Point(0, 0);
            this.toolStripDGView.Name = "toolStripDGView";
            this.toolStripDGView.Size = new System.Drawing.Size(736, 55);
            this.toolStripDGView.TabIndex = 0;
            this.toolStripDGView.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(125, 52);
            this.toolStripLabel1.Text = "Select table to view :  ";
            // 
            // toolStripCmbBox
            // 
            this.toolStripCmbBox.Items.AddRange(new object[] {
            "Compund Data",
            "Reagent Data",
            "Operation Data",
            "Chemical Compounds",
            "Physical Properties"});
            this.toolStripCmbBox.Name = "toolStripCmbBox";
            this.toolStripCmbBox.Size = new System.Drawing.Size(121, 55);
            this.toolStripCmbBox.ToolTipText = "Select table to view";
            // 
            // toolStrip_BtnDGView
            // 
            this.toolStrip_BtnDGView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_BtnDGView.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_BtnDGView.Image")));
            this.toolStrip_BtnDGView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStrip_BtnDGView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_BtnDGView.Name = "toolStrip_BtnDGView";
            this.toolStrip_BtnDGView.Size = new System.Drawing.Size(52, 52);
            this.toolStrip_BtnDGView.Text = "Click to view selected table";
            this.toolStrip_BtnDGView.Click += new System.EventHandler(this.toolStrip_BtnDGView_Click);
            // 
            // pnlDGView_2
            // 
            this.pnlDGView_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDGView_2.Location = new System.Drawing.Point(0, 68);
            this.pnlDGView_2.Name = "pnlDGView_2";
            this.pnlDGView_2.Size = new System.Drawing.Size(736, 463);
            this.pnlDGView_2.TabIndex = 4;
            // 
            // frmViewChemical_CompoundsDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 531);
            this.Controls.Add(this.pnlDGView_2);
            this.Controls.Add(this.pnlDGView);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmViewChemical_CompoundsDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View data tables in grid view";
            this.Load += new System.EventHandler(this.frmViewChemical_CompoundsDT_Load);
            this.pnlDGView.ResumeLayout(false);
            this.pnlDGView.PerformLayout();
            this.toolStripDGView.ResumeLayout(false);
            this.toolStripDGView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDGView;
        private System.Windows.Forms.ToolStrip toolStripDGView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripCmbBox;
        private System.Windows.Forms.ToolStripButton toolStrip_BtnDGView;
        private System.Windows.Forms.Panel pnlDGView_2;
        private System.Windows.Forms.ToolTip toolTipDGView;




    }
}