namespace Analytica_Lab_Administration_Wizard
{
    partial class frmDBWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBWizard));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpBoxSelectTask = new System.Windows.Forms.GroupBox();
            this.radioBtnRestoreDB = new System.Windows.Forms.RadioButton();
            this.lblRestoreDB = new System.Windows.Forms.Label();
            this.radioBtnBckUp = new System.Windows.Forms.RadioButton();
            this.lblBckUp = new System.Windows.Forms.Label();
            this.radioBtnViewData = new System.Windows.Forms.RadioButton();
            this.lblViewDataBase = new System.Windows.Forms.Label();
            this.radioBtnEditChemicalCompound = new System.Windows.Forms.RadioButton();
            this.lblEditChemicalCompound = new System.Windows.Forms.Label();
            this.radioBtnAddNewOperation = new System.Windows.Forms.RadioButton();
            this.lblAddNewOperation = new System.Windows.Forms.Label();
            this.radioBtnAddNewReagent = new System.Windows.Forms.RadioButton();
            this.lblAddNewReagent = new System.Windows.Forms.Label();
            this.radioBtnAddNewCompound = new System.Windows.Forms.RadioButton();
            this.lblAddNewCompound = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpBoxSelectTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(116, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(372, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Database Administration Wizard";
            // 
            // grpBoxSelectTask
            // 
            this.grpBoxSelectTask.Controls.Add(this.radioBtnRestoreDB);
            this.grpBoxSelectTask.Controls.Add(this.lblRestoreDB);
            this.grpBoxSelectTask.Controls.Add(this.radioBtnBckUp);
            this.grpBoxSelectTask.Controls.Add(this.lblBckUp);
            this.grpBoxSelectTask.Controls.Add(this.radioBtnViewData);
            this.grpBoxSelectTask.Controls.Add(this.lblViewDataBase);
            this.grpBoxSelectTask.Controls.Add(this.radioBtnEditChemicalCompound);
            this.grpBoxSelectTask.Controls.Add(this.lblEditChemicalCompound);
            this.grpBoxSelectTask.Controls.Add(this.radioBtnAddNewOperation);
            this.grpBoxSelectTask.Controls.Add(this.lblAddNewOperation);
            this.grpBoxSelectTask.Controls.Add(this.radioBtnAddNewReagent);
            this.grpBoxSelectTask.Controls.Add(this.lblAddNewReagent);
            this.grpBoxSelectTask.Controls.Add(this.radioBtnAddNewCompound);
            this.grpBoxSelectTask.Controls.Add(this.lblAddNewCompound);
            this.grpBoxSelectTask.Location = new System.Drawing.Point(54, 69);
            this.grpBoxSelectTask.Name = "grpBoxSelectTask";
            this.grpBoxSelectTask.Size = new System.Drawing.Size(502, 311);
            this.grpBoxSelectTask.TabIndex = 1;
            this.grpBoxSelectTask.TabStop = false;
            // 
            // radioBtnRestoreDB
            // 
            this.radioBtnRestoreDB.AutoSize = true;
            this.radioBtnRestoreDB.Location = new System.Drawing.Point(420, 277);
            this.radioBtnRestoreDB.Name = "radioBtnRestoreDB";
            this.radioBtnRestoreDB.Size = new System.Drawing.Size(14, 13);
            this.radioBtnRestoreDB.TabIndex = 13;
            this.radioBtnRestoreDB.TabStop = true;
            this.radioBtnRestoreDB.UseVisualStyleBackColor = true;
            // 
            // lblRestoreDB
            // 
            this.lblRestoreDB.AutoSize = true;
            this.lblRestoreDB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestoreDB.Location = new System.Drawing.Point(57, 273);
            this.lblRestoreDB.Name = "lblRestoreDB";
            this.lblRestoreDB.Size = new System.Drawing.Size(129, 19);
            this.lblRestoreDB.TabIndex = 12;
            this.lblRestoreDB.Text = "Restore database";
            // 
            // radioBtnBckUp
            // 
            this.radioBtnBckUp.AutoSize = true;
            this.radioBtnBckUp.Location = new System.Drawing.Point(420, 241);
            this.radioBtnBckUp.Name = "radioBtnBckUp";
            this.radioBtnBckUp.Size = new System.Drawing.Size(14, 13);
            this.radioBtnBckUp.TabIndex = 11;
            this.radioBtnBckUp.TabStop = true;
            this.radioBtnBckUp.UseVisualStyleBackColor = true;
            // 
            // lblBckUp
            // 
            this.lblBckUp.AutoSize = true;
            this.lblBckUp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBckUp.Location = new System.Drawing.Point(57, 237);
            this.lblBckUp.Name = "lblBckUp";
            this.lblBckUp.Size = new System.Drawing.Size(130, 19);
            this.lblBckUp.TabIndex = 10;
            this.lblBckUp.Text = "Back up database";
            // 
            // radioBtnViewData
            // 
            this.radioBtnViewData.AutoSize = true;
            this.radioBtnViewData.Checked = true;
            this.radioBtnViewData.Location = new System.Drawing.Point(420, 204);
            this.radioBtnViewData.Name = "radioBtnViewData";
            this.radioBtnViewData.Size = new System.Drawing.Size(14, 13);
            this.radioBtnViewData.TabIndex = 9;
            this.radioBtnViewData.TabStop = true;
            this.radioBtnViewData.UseVisualStyleBackColor = true;
            // 
            // lblViewDataBase
            // 
            this.lblViewDataBase.AutoSize = true;
            this.lblViewDataBase.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDataBase.Location = new System.Drawing.Point(57, 200);
            this.lblViewDataBase.Name = "lblViewDataBase";
            this.lblViewDataBase.Size = new System.Drawing.Size(271, 19);
            this.lblViewDataBase.TabIndex = 8;
            this.lblViewDataBase.Text = "View data in the database in grid view";
            // 
            // radioBtnEditChemicalCompound
            // 
            this.radioBtnEditChemicalCompound.AutoSize = true;
            this.radioBtnEditChemicalCompound.Location = new System.Drawing.Point(420, 167);
            this.radioBtnEditChemicalCompound.Name = "radioBtnEditChemicalCompound";
            this.radioBtnEditChemicalCompound.Size = new System.Drawing.Size(14, 13);
            this.radioBtnEditChemicalCompound.TabIndex = 7;
            this.radioBtnEditChemicalCompound.TabStop = true;
            this.radioBtnEditChemicalCompound.UseVisualStyleBackColor = true;
            // 
            // lblEditChemicalCompound
            // 
            this.lblEditChemicalCompound.AutoSize = true;
            this.lblEditChemicalCompound.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditChemicalCompound.Location = new System.Drawing.Point(57, 163);
            this.lblEditChemicalCompound.Name = "lblEditChemicalCompound";
            this.lblEditChemicalCompound.Size = new System.Drawing.Size(291, 19);
            this.lblEditChemicalCompound.TabIndex = 6;
            this.lblEditChemicalCompound.Text = "Edit already existing chemical compound";
            // 
            // radioBtnAddNewOperation
            // 
            this.radioBtnAddNewOperation.AutoSize = true;
            this.radioBtnAddNewOperation.Location = new System.Drawing.Point(420, 129);
            this.radioBtnAddNewOperation.Name = "radioBtnAddNewOperation";
            this.radioBtnAddNewOperation.Size = new System.Drawing.Size(14, 13);
            this.radioBtnAddNewOperation.TabIndex = 5;
            this.radioBtnAddNewOperation.TabStop = true;
            this.radioBtnAddNewOperation.UseVisualStyleBackColor = true;
            // 
            // lblAddNewOperation
            // 
            this.lblAddNewOperation.AutoSize = true;
            this.lblAddNewOperation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewOperation.Location = new System.Drawing.Point(57, 125);
            this.lblAddNewOperation.Name = "lblAddNewOperation";
            this.lblAddNewOperation.Size = new System.Drawing.Size(264, 19);
            this.lblAddNewOperation.TabIndex = 4;
            this.lblAddNewOperation.Text = "Add a new operation to the database";
            // 
            // radioBtnAddNewReagent
            // 
            this.radioBtnAddNewReagent.AutoSize = true;
            this.radioBtnAddNewReagent.Location = new System.Drawing.Point(420, 87);
            this.radioBtnAddNewReagent.Name = "radioBtnAddNewReagent";
            this.radioBtnAddNewReagent.Size = new System.Drawing.Size(14, 13);
            this.radioBtnAddNewReagent.TabIndex = 3;
            this.radioBtnAddNewReagent.TabStop = true;
            this.radioBtnAddNewReagent.UseVisualStyleBackColor = true;
            // 
            // lblAddNewReagent
            // 
            this.lblAddNewReagent.AutoSize = true;
            this.lblAddNewReagent.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewReagent.Location = new System.Drawing.Point(57, 83);
            this.lblAddNewReagent.Name = "lblAddNewReagent";
            this.lblAddNewReagent.Size = new System.Drawing.Size(249, 19);
            this.lblAddNewReagent.TabIndex = 2;
            this.lblAddNewReagent.Text = "Add a new reagent to the database";
            // 
            // radioBtnAddNewCompound
            // 
            this.radioBtnAddNewCompound.AutoSize = true;
            this.radioBtnAddNewCompound.Location = new System.Drawing.Point(420, 44);
            this.radioBtnAddNewCompound.Name = "radioBtnAddNewCompound";
            this.radioBtnAddNewCompound.Size = new System.Drawing.Size(14, 13);
            this.radioBtnAddNewCompound.TabIndex = 1;
            this.radioBtnAddNewCompound.TabStop = true;
            this.radioBtnAddNewCompound.UseVisualStyleBackColor = true;
            // 
            // lblAddNewCompound
            // 
            this.lblAddNewCompound.AutoSize = true;
            this.lblAddNewCompound.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewCompound.Location = new System.Drawing.Point(57, 40);
            this.lblAddNewCompound.Name = "lblAddNewCompound";
            this.lblAddNewCompound.Size = new System.Drawing.Size(334, 19);
            this.lblAddNewCompound.TabIndex = 0;
            this.lblAddNewCompound.Text = "Add a new chemical compound to the database";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(244, 397);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmDBWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 432);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpBoxSelectTask);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDBWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpBoxSelectTask.ResumeLayout(false);
            this.grpBoxSelectTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpBoxSelectTask;
        private System.Windows.Forms.RadioButton radioBtnViewData;
        private System.Windows.Forms.Label lblViewDataBase;
        private System.Windows.Forms.RadioButton radioBtnEditChemicalCompound;
        private System.Windows.Forms.Label lblEditChemicalCompound;
        private System.Windows.Forms.RadioButton radioBtnAddNewOperation;
        private System.Windows.Forms.Label lblAddNewOperation;
        private System.Windows.Forms.RadioButton radioBtnAddNewReagent;
        private System.Windows.Forms.Label lblAddNewReagent;
        private System.Windows.Forms.RadioButton radioBtnAddNewCompound;
        private System.Windows.Forms.Label lblAddNewCompound;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton radioBtnBckUp;
        private System.Windows.Forms.Label lblBckUp;
        private System.Windows.Forms.RadioButton radioBtnRestoreDB;
        private System.Windows.Forms.Label lblRestoreDB;
    }
}