namespace Analytica_Lab
{
    partial class frmCustomSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomSample));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpBoxCustomSample = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstBoxCationsSelected = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBoxCationsFromDB = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpBoxCustomSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(156, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Please select your cations..";
            // 
            // grpBoxCustomSample
            // 
            this.grpBoxCustomSample.Controls.Add(this.btnRemove);
            this.grpBoxCustomSample.Controls.Add(this.lstBoxCationsSelected);
            this.grpBoxCustomSample.Controls.Add(this.btnAdd);
            this.grpBoxCustomSample.Controls.Add(this.lstBoxCationsFromDB);
            this.grpBoxCustomSample.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCustomSample.Location = new System.Drawing.Point(33, 65);
            this.grpBoxCustomSample.Name = "grpBoxCustomSample";
            this.grpBoxCustomSample.Size = new System.Drawing.Size(515, 244);
            this.grpBoxCustomSample.TabIndex = 2;
            this.grpBoxCustomSample.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.Location = new System.Drawing.Point(231, 130);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 48);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstBoxCationsSelected
            // 
            this.lstBoxCationsSelected.FormattingEnabled = true;
            this.lstBoxCationsSelected.ItemHeight = 14;
            this.lstBoxCationsSelected.Location = new System.Drawing.Point(295, 21);
            this.lstBoxCationsSelected.Name = "lstBoxCationsSelected";
            this.lstBoxCationsSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxCationsSelected.Size = new System.Drawing.Size(203, 214);
            this.lstBoxCationsSelected.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Location = new System.Drawing.Point(231, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBoxCationsFromDB
            // 
            this.lstBoxCationsFromDB.FormattingEnabled = true;
            this.lstBoxCationsFromDB.ItemHeight = 14;
            this.lstBoxCationsFromDB.Location = new System.Drawing.Point(18, 21);
            this.lstBoxCationsFromDB.Name = "lstBoxCationsFromDB";
            this.lstBoxCationsFromDB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxCationsFromDB.Size = new System.Drawing.Size(203, 214);
            this.lstBoxCationsFromDB.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(457, 315);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 36);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmCustomSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 354);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpBoxCustomSample);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomSample";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCustomSample_Load);
            this.grpBoxCustomSample.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpBoxCustomSample;
        private System.Windows.Forms.ListBox lstBoxCationsFromDB;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstBoxCationsSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
    }
}