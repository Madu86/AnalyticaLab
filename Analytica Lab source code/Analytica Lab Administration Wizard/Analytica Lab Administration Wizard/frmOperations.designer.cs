namespace Analytica_Lab_Administration_Wizard
{
    partial class frmOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperations));
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemoveOperation = new System.Windows.Forms.Button();
            this.lstBoxOperations = new System.Windows.Forms.ListBox();
            this.grpBoxAddOperation = new System.Windows.Forms.GroupBox();
            this.txtBoxOperationName = new System.Windows.Forms.TextBox();
            this.lblAddOperation = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpBoxAddOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddOperation.BackgroundImage")));
            this.btnAddOperation.Location = new System.Drawing.Point(327, 155);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(29, 29);
            this.btnAddOperation.TabIndex = 10;
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(327, 111);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 29);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemoveOperation
            // 
            this.btnRemoveOperation.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveOperation.Image")));
            this.btnRemoveOperation.Location = new System.Drawing.Point(327, 64);
            this.btnRemoveOperation.Name = "btnRemoveOperation";
            this.btnRemoveOperation.Size = new System.Drawing.Size(29, 29);
            this.btnRemoveOperation.TabIndex = 8;
            this.btnRemoveOperation.UseVisualStyleBackColor = true;
            this.btnRemoveOperation.Click += new System.EventHandler(this.btnRemoveOperation_Click);
            // 
            // lstBoxOperations
            // 
            this.lstBoxOperations.FormattingEnabled = true;
            this.lstBoxOperations.Location = new System.Drawing.Point(26, 26);
            this.lstBoxOperations.Name = "lstBoxOperations";
            this.lstBoxOperations.Size = new System.Drawing.Size(290, 199);
            this.lstBoxOperations.TabIndex = 7;
            // 
            // grpBoxAddOperation
            // 
            this.grpBoxAddOperation.Controls.Add(this.txtBoxOperationName);
            this.grpBoxAddOperation.Controls.Add(this.lblAddOperation);
            this.grpBoxAddOperation.Controls.Add(this.btnOk);
            this.grpBoxAddOperation.Location = new System.Drawing.Point(26, 245);
            this.grpBoxAddOperation.Name = "grpBoxAddOperation";
            this.grpBoxAddOperation.Size = new System.Drawing.Size(330, 117);
            this.grpBoxAddOperation.TabIndex = 6;
            this.grpBoxAddOperation.TabStop = false;
            // 
            // txtBoxOperationName
            // 
            this.txtBoxOperationName.Location = new System.Drawing.Point(161, 34);
            this.txtBoxOperationName.Name = "txtBoxOperationName";
            this.txtBoxOperationName.Size = new System.Drawing.Size(116, 20);
            this.txtBoxOperationName.TabIndex = 1;
            // 
            // lblAddOperation
            // 
            this.lblAddOperation.AutoSize = true;
            this.lblAddOperation.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOperation.Location = new System.Drawing.Point(18, 36);
            this.lblAddOperation.Name = "lblAddOperation";
            this.lblAddOperation.Size = new System.Drawing.Size(137, 15);
            this.lblAddOperation.TabIndex = 0;
            this.lblAddOperation.Text = "Name of the Operation :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(100, 70);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 385);
            this.Controls.Add(this.btnAddOperation);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemoveOperation);
            this.Controls.Add(this.lstBoxOperations);
            this.Controls.Add(this.grpBoxAddOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operation Wizard";
            this.Load += new System.EventHandler(this.frmOperations_Load);
            this.grpBoxAddOperation.ResumeLayout(false);
            this.grpBoxAddOperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemoveOperation;
        private System.Windows.Forms.ListBox lstBoxOperations;
        private System.Windows.Forms.GroupBox grpBoxAddOperation;
        private System.Windows.Forms.TextBox txtBoxOperationName;
        private System.Windows.Forms.Label lblAddOperation;
        private System.Windows.Forms.Button btnOk;
    }
}