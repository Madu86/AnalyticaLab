namespace Analytica_Lab_Administration_Wizard
{
    partial class editChemicalCompound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editChemicalCompound));
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
            this.btnSave = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblSelectChemicalCompound = new System.Windows.Forms.Label();
            this.cmbBoxSelector = new System.Windows.Forms.ComboBox();
            this.grpBoxAddChemicalCompound.SuspendLayout();
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
            this.grpBoxAddChemicalCompound.Location = new System.Drawing.Point(25, 86);
            this.grpBoxAddChemicalCompound.Name = "grpBoxAddChemicalCompound";
            this.grpBoxAddChemicalCompound.Size = new System.Drawing.Size(453, 234);
            this.grpBoxAddChemicalCompound.TabIndex = 1;
            this.grpBoxAddChemicalCompound.TabStop = false;
            // 
            // txtBoxColorName
            // 
            this.txtBoxColorName.Location = new System.Drawing.Point(250, 154);
            this.txtBoxColorName.Name = "txtBoxColorName";
            this.txtBoxColorName.Size = new System.Drawing.Size(132, 20);
            this.txtBoxColorName.TabIndex = 11;
            this.txtBoxColorName.Text = "Colorless";
            // 
            // lblColorName
            // 
            this.lblColorName.AutoSize = true;
            this.lblColorName.Location = new System.Drawing.Point(24, 157);
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.Size = new System.Drawing.Size(98, 13);
            this.lblColorName.TabIndex = 10;
            this.lblColorName.Text = "Name of the Color :";
            // 
            // txtBoxOdor
            // 
            this.txtBoxOdor.Location = new System.Drawing.Point(249, 193);
            this.txtBoxOdor.Name = "txtBoxOdor";
            this.txtBoxOdor.Size = new System.Drawing.Size(132, 20);
            this.txtBoxOdor.TabIndex = 9;
            // 
            // lblOdor
            // 
            this.lblOdor.AutoSize = true;
            this.lblOdor.Location = new System.Drawing.Point(24, 196);
            this.lblOdor.Name = "lblOdor";
            this.lblOdor.Size = new System.Drawing.Size(36, 13);
            this.lblOdor.TabIndex = 8;
            this.lblOdor.Text = "Odor :";
            // 
            // lblIsColorless
            // 
            this.lblIsColorless.AutoSize = true;
            this.lblIsColorless.Location = new System.Drawing.Point(338, 113);
            this.lblIsColorless.Name = "lblIsColorless";
            this.lblIsColorless.Size = new System.Drawing.Size(55, 13);
            this.lblIsColorless.TabIndex = 7;
            this.lblIsColorless.Text = "Colorless :";
            // 
            // chkBoxColorless
            // 
            this.chkBoxColorless.AutoSize = true;
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
            this.lblColorCode.Size = new System.Drawing.Size(120, 13);
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
            this.cmbBoxState.Size = new System.Drawing.Size(133, 21);
            this.cmbBoxState.TabIndex = 3;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(24, 80);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "State :";
            // 
            // txtBoxChemicalCompound
            // 
            this.txtBoxChemicalCompound.Location = new System.Drawing.Point(249, 35);
            this.txtBoxChemicalCompound.Name = "txtBoxChemicalCompound";
            this.txtBoxChemicalCompound.Size = new System.Drawing.Size(132, 20);
            this.txtBoxChemicalCompound.TabIndex = 1;
            // 
            // lblNameOfTheChemicalCompound
            // 
            this.lblNameOfTheChemicalCompound.AutoSize = true;
            this.lblNameOfTheChemicalCompound.Location = new System.Drawing.Point(24, 38);
            this.lblNameOfTheChemicalCompound.Name = "lblNameOfTheChemicalCompound";
            this.lblNameOfTheChemicalCompound.Size = new System.Drawing.Size(169, 13);
            this.lblNameOfTheChemicalCompound.TabIndex = 0;
            this.lblNameOfTheChemicalCompound.Text = "Name of the chemical compound :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Ok";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSelectChemicalCompound
            // 
            this.lblSelectChemicalCompound.AutoSize = true;
            this.lblSelectChemicalCompound.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectChemicalCompound.Location = new System.Drawing.Point(37, 43);
            this.lblSelectChemicalCompound.Name = "lblSelectChemicalCompound";
            this.lblSelectChemicalCompound.Size = new System.Drawing.Size(181, 17);
            this.lblSelectChemicalCompound.TabIndex = 4;
            this.lblSelectChemicalCompound.Text = "Select chemical compound :";
            // 
            // cmbBoxSelector
            // 
            this.cmbBoxSelector.FormattingEnabled = true;
            this.cmbBoxSelector.Location = new System.Drawing.Point(252, 43);
            this.cmbBoxSelector.Name = "cmbBoxSelector";
            this.cmbBoxSelector.Size = new System.Drawing.Size(154, 21);
            this.cmbBoxSelector.Sorted = true;
            this.cmbBoxSelector.TabIndex = 5;
            this.cmbBoxSelector.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSelector_SelectedIndexChanged);
            // 
            // editChemicalCompound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 653);
            this.Controls.Add(this.cmbBoxSelector);
            this.Controls.Add(this.lblSelectChemicalCompound);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpBoxAddChemicalCompound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editChemicalCompound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Chemical Compound";
            this.Load += new System.EventHandler(this.editChemicalCompound_Load);
            this.grpBoxAddChemicalCompound.ResumeLayout(false);
            this.grpBoxAddChemicalCompound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAddChemicalCompound;
        private System.Windows.Forms.TextBox txtBoxColorName;
        private System.Windows.Forms.Label lblColorName;
        private System.Windows.Forms.TextBox txtBoxOdor;
        private System.Windows.Forms.Label lblOdor;
        private System.Windows.Forms.Label lblIsColorless;
        private System.Windows.Forms.CheckBox chkBoxColorless;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.ComboBox cmbBoxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNameOfTheChemicalCompound;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox txtBoxChemicalCompound;
        private System.Windows.Forms.Label lblSelectChemicalCompound;
        private System.Windows.Forms.ComboBox cmbBoxSelector;
    }
}