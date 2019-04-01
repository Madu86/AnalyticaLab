namespace Analytica_Lab_Administration_Wizard
{
    partial class frmReagentWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReagentWizard));
            this.btnAddReagent = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemoveReagent = new System.Windows.Forms.Button();
            this.lstBoxReagents = new System.Windows.Forms.ListBox();
            this.grpBoxAddReagent = new System.Windows.Forms.GroupBox();
            this.txtBoxReagentName = new System.Windows.Forms.TextBox();
            this.lblAddReagent = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpBoxAddReagent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddReagent
            // 
            this.btnAddReagent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddReagent.BackgroundImage")));
            this.btnAddReagent.Location = new System.Drawing.Point(324, 157);
            this.btnAddReagent.Name = "btnAddReagent";
            this.btnAddReagent.Size = new System.Drawing.Size(29, 29);
            this.btnAddReagent.TabIndex = 15;
            this.btnAddReagent.UseVisualStyleBackColor = true;
            this.btnAddReagent.Click += new System.EventHandler(this.btnAddReagent_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(324, 113);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 29);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemoveReagent
            // 
            this.btnRemoveReagent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveReagent.BackgroundImage")));
            this.btnRemoveReagent.Location = new System.Drawing.Point(324, 66);
            this.btnRemoveReagent.Name = "btnRemoveReagent";
            this.btnRemoveReagent.Size = new System.Drawing.Size(29, 29);
            this.btnRemoveReagent.TabIndex = 13;
            this.btnRemoveReagent.UseVisualStyleBackColor = true;
            this.btnRemoveReagent.Click += new System.EventHandler(this.btnRemoveReagent_Click);
            // 
            // lstBoxReagents
            // 
            this.lstBoxReagents.FormattingEnabled = true;
            this.lstBoxReagents.ItemHeight = 15;
            this.lstBoxReagents.Location = new System.Drawing.Point(23, 28);
            this.lstBoxReagents.Name = "lstBoxReagents";
            this.lstBoxReagents.Size = new System.Drawing.Size(290, 199);
            this.lstBoxReagents.TabIndex = 12;
            // 
            // grpBoxAddReagent
            // 
            this.grpBoxAddReagent.Controls.Add(this.txtBoxReagentName);
            this.grpBoxAddReagent.Controls.Add(this.lblAddReagent);
            this.grpBoxAddReagent.Controls.Add(this.btnOk);
            this.grpBoxAddReagent.Location = new System.Drawing.Point(23, 247);
            this.grpBoxAddReagent.Name = "grpBoxAddReagent";
            this.grpBoxAddReagent.Size = new System.Drawing.Size(290, 118);
            this.grpBoxAddReagent.TabIndex = 11;
            this.grpBoxAddReagent.TabStop = false;
            // 
            // txtBoxReagentName
            // 
            this.txtBoxReagentName.Location = new System.Drawing.Point(161, 34);
            this.txtBoxReagentName.Name = "txtBoxReagentName";
            this.txtBoxReagentName.Size = new System.Drawing.Size(116, 23);
            this.txtBoxReagentName.TabIndex = 1;
            // 
            // lblAddReagent
            // 
            this.lblAddReagent.AutoSize = true;
            this.lblAddReagent.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddReagent.Location = new System.Drawing.Point(18, 36);
            this.lblAddReagent.Name = "lblAddReagent";
            this.lblAddReagent.Size = new System.Drawing.Size(125, 15);
            this.lblAddReagent.TabIndex = 0;
            this.lblAddReagent.Text = "Name of the Reagent :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(82, 71);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 30);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmReagentWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 392);
            this.Controls.Add(this.btnAddReagent);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemoveReagent);
            this.Controls.Add(this.lstBoxReagents);
            this.Controls.Add(this.grpBoxAddReagent);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReagentWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reagent Wizard";
            this.Load += new System.EventHandler(this.frmReagentWizard_Load);
            this.grpBoxAddReagent.ResumeLayout(false);
            this.grpBoxAddReagent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddReagent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemoveReagent;
        private System.Windows.Forms.ListBox lstBoxReagents;
        private System.Windows.Forms.GroupBox grpBoxAddReagent;
        private System.Windows.Forms.TextBox txtBoxReagentName;
        private System.Windows.Forms.Label lblAddReagent;
        private System.Windows.Forms.Button btnOk;
    }
}