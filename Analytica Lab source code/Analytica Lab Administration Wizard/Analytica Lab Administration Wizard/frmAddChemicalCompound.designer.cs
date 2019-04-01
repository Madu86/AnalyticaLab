namespace Analytica_Lab_Administration_Wizard
{
    partial class frmAddChemicalCompound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddChemicalCompound));
            this.grpBoxAddChemicalCompound = new System.Windows.Forms.GroupBox();
            this.txtBoxColorName = new System.Windows.Forms.TextBox();
            this.lblColorName = new System.Windows.Forms.Label();
            this.txtBoxOdor = new System.Windows.Forms.TextBox();
            this.lblOdor = new System.Windows.Forms.Label();
            this.lblIsColorless = new System.Windows.Forms.Label();
            this.chkBoxColorless = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColorCode = new System.Windows.Forms.Label();
            this.cmbBoxState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBoxChemicalCompound = new System.Windows.Forms.TextBox();
            this.lblNameOfTheChemicalCompound = new System.Windows.Forms.Label();
            this.lblRgnt = new System.Windows.Forms.Label();
            this.lblCmpnds = new System.Windows.Forms.Label();
            this.pnlChemicalCompound = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBoxAddChemicalCompound.SuspendLayout();
            this.pnlChemicalCompound.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxAddChemicalCompound
            // 
            this.grpBoxAddChemicalCompound.BackColor = System.Drawing.Color.White;
            this.grpBoxAddChemicalCompound.Controls.Add(this.txtBoxColorName);
            this.grpBoxAddChemicalCompound.Controls.Add(this.lblColorName);
            this.grpBoxAddChemicalCompound.Controls.Add(this.txtBoxOdor);
            this.grpBoxAddChemicalCompound.Controls.Add(this.lblOdor);
            this.grpBoxAddChemicalCompound.Controls.Add(this.lblIsColorless);
            this.grpBoxAddChemicalCompound.Controls.Add(this.chkBoxColorless);
            this.grpBoxAddChemicalCompound.Controls.Add(this.btnColor);
            this.grpBoxAddChemicalCompound.Controls.Add(this.lblColorCode);
            this.grpBoxAddChemicalCompound.Controls.Add(this.cmbBoxState);
            this.grpBoxAddChemicalCompound.Controls.Add(this.lblState);
            this.grpBoxAddChemicalCompound.Controls.Add(this.txtBoxChemicalCompound);
            this.grpBoxAddChemicalCompound.Controls.Add(this.lblNameOfTheChemicalCompound);
            this.grpBoxAddChemicalCompound.Location = new System.Drawing.Point(25, 24);
            this.grpBoxAddChemicalCompound.Name = "grpBoxAddChemicalCompound";
            this.grpBoxAddChemicalCompound.Size = new System.Drawing.Size(453, 234);
            this.grpBoxAddChemicalCompound.TabIndex = 0;
            this.grpBoxAddChemicalCompound.TabStop = false;
            // 
            // txtBoxColorName
            // 
            this.txtBoxColorName.Location = new System.Drawing.Point(250, 154);
            this.txtBoxColorName.Name = "txtBoxColorName";
            this.txtBoxColorName.Size = new System.Drawing.Size(132, 23);
            this.txtBoxColorName.TabIndex = 11;
            this.txtBoxColorName.Text = "Colorless";
            this.txtBoxColorName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblColorName
            // 
            this.lblColorName.AutoSize = true;
            this.lblColorName.Location = new System.Drawing.Point(24, 157);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(112, 15);
            this.lblColorName.TabIndex = 10;
            this.lblColorName.Text = "Name of the Color :";
            // 
            // txtBoxOdor
            // 
            this.txtBoxOdor.Location = new System.Drawing.Point(249, 193);
            this.txtBoxOdor.Name = "txtBoxOdor";
            this.txtBoxOdor.Size = new System.Drawing.Size(132, 23);
            this.txtBoxOdor.TabIndex = 9;
            // 
            // lblOdor
            // 
            this.lblOdor.AutoSize = true;
            this.lblOdor.Location = new System.Drawing.Point(24, 196);
            this.lblOdor.Name = "lblOdor";
            this.lblOdor.Size = new System.Drawing.Size(41, 15);
            this.lblOdor.TabIndex = 8;
            this.lblOdor.Text = "Odor :";
            // 
            // lblIsColorless
            // 
            this.lblIsColorless.AutoSize = true;
            this.lblIsColorless.Location = new System.Drawing.Point(338, 113);
            this.lblIsColorless.Name = "lblIsColorless";
            this.lblIsColorless.Size = new System.Drawing.Size(65, 15);
            this.lblIsColorless.TabIndex = 7;
            this.lblIsColorless.Text = "Colorless :";
            // 
            // chkBoxColorless
            // 
            this.chkBoxColorless.AutoSize = true;
            this.chkBoxColorless.Checked = true;
            this.chkBoxColorless.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxColorless.Location = new System.Drawing.Point(409, 114);
            this.chkBoxColorless.Name = "chkBoxColorless";
            this.chkBoxColorless.Size = new System.Drawing.Size(15, 14);
            this.chkBoxColorless.TabIndex = 6;
            this.chkBoxColorless.UseVisualStyleBackColor = true;
            this.chkBoxColorless.CheckedChanged += new System.EventHandler(this.chkBoxColorless_CheckedChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(249, 109);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(62, 23);
            this.btnColor.TabIndex = 5;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColorCode
            // 
            this.lblColorCode.AutoSize = true;
            this.lblColorCode.Location = new System.Drawing.Point(24, 113);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(139, 15);
            this.lblColorCode.TabIndex = 4;
            this.lblColorCode.Text = "Color of the compound :";
            // 
            // cmbBoxState
            // 
            this.cmbBoxState.FormattingEnabled = true;
            this.cmbBoxState.Items.AddRange(new object[] {
            "solution",
            "precipitate",
            "geletinous precipitate",
            "salt",
            "crystal",
            "gas",
            "flame"});
            this.cmbBoxState.Location = new System.Drawing.Point(249, 72);
            this.cmbBoxState.Name = "cmbBoxState";
            this.cmbBoxState.Size = new System.Drawing.Size(133, 23);
            this.cmbBoxState.TabIndex = 3;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(24, 80);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(39, 15);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "State :";
            // 
            // txtBoxChemicalCompound
            // 
            this.txtBoxChemicalCompound.Location = new System.Drawing.Point(249, 35);
            this.txtBoxChemicalCompound.Name = "txtBoxChemicalCompound";
            this.txtBoxChemicalCompound.Size = new System.Drawing.Size(132, 23);
            this.txtBoxChemicalCompound.TabIndex = 1;
            // 
            // lblNameOfTheChemicalCompound
            // 
            this.lblNameOfTheChemicalCompound.AutoSize = true;
            this.lblNameOfTheChemicalCompound.Location = new System.Drawing.Point(24, 38);
            this.lblNameOfTheChemicalCompound.Name = "lblNameOfTheChemicalCompound";
            this.lblNameOfTheChemicalCompound.Size = new System.Drawing.Size(194, 15);
            this.lblNameOfTheChemicalCompound.TabIndex = 0;
            this.lblNameOfTheChemicalCompound.Text = "Name of the chemical compound :";
            // 
            // lblRgnt
            // 
            this.lblRgnt.AutoSize = true;
            this.lblRgnt.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgnt.Location = new System.Drawing.Point(40, 20);
            this.lblRgnt.Name = "lblRgnt";
            this.lblRgnt.Size = new System.Drawing.Size(141, 17);
            this.lblRgnt.TabIndex = 0;
            this.lblRgnt.Text = "Reagent or Operation";
            // 
            // lblCmpnds
            // 
            this.lblCmpnds.AutoSize = true;
            this.lblCmpnds.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmpnds.Location = new System.Drawing.Point(228, 20);
            this.lblCmpnds.Name = "lblCmpnds";
            this.lblCmpnds.Size = new System.Drawing.Size(125, 17);
            this.lblCmpnds.TabIndex = 1;
            this.lblCmpnds.Text = "Compound formed";
            // 
            // pnlChemicalCompound
            // 
            this.pnlChemicalCompound.AutoScroll = true;
            this.pnlChemicalCompound.BackColor = System.Drawing.Color.White;
            this.pnlChemicalCompound.Controls.Add(this.lblCmpnds);
            this.pnlChemicalCompound.Controls.Add(this.lblRgnt);
            this.pnlChemicalCompound.Location = new System.Drawing.Point(25, 285);
            this.pnlChemicalCompound.Name = "pnlChemicalCompound";
            this.pnlChemicalCompound.Size = new System.Drawing.Size(453, 261);
            this.pnlChemicalCompound.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Ok";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddChemicalCompound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 602);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlChemicalCompound);
            this.Controls.Add(this.grpBoxAddChemicalCompound);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddChemicalCompound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add chemical compound";
            this.Load += new System.EventHandler(this.frmAddChemicalCompound_Load);
            this.grpBoxAddChemicalCompound.ResumeLayout(false);
            this.grpBoxAddChemicalCompound.PerformLayout();
            this.pnlChemicalCompound.ResumeLayout(false);
            this.pnlChemicalCompound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAddChemicalCompound;
        private System.Windows.Forms.TextBox txtBoxChemicalCompound;
        private System.Windows.Forms.Label lblNameOfTheChemicalCompound;
        private System.Windows.Forms.Label lblRgnt;
        private System.Windows.Forms.Label lblCmpnds;
        private System.Windows.Forms.Panel pnlChemicalCompound;
        private System.Windows.Forms.ComboBox cmbBoxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblIsColorless;
        private System.Windows.Forms.CheckBox chkBoxColorless;
        private System.Windows.Forms.Label lblOdor;
        private System.Windows.Forms.TextBox txtBoxOdor;
        private System.Windows.Forms.TextBox txtBoxColorName;
        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.Button btnSave;
    }
}