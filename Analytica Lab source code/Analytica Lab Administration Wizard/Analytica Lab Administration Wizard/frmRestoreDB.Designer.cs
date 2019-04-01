namespace Analytica_Lab_Administration_Wizard
{
    partial class frmRestoreDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreDB));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpBoxBckUpDB = new System.Windows.Forms.GroupBox();
            this.btnOpenLdfLocation = new System.Windows.Forms.Button();
            this.txtBoxLdfLocation = new System.Windows.Forms.TextBox();
            this.lblSelectLdfLocation = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOpenMdfLocation = new System.Windows.Forms.Button();
            this.txtBoxMdfLocation = new System.Windows.Forms.TextBox();
            this.lblSelectDBLocation = new System.Windows.Forms.Label();
            this.grpBoxBckUpDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(163, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(194, 22);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Restore your data base";
            // 
            // grpBoxBckUpDB
            // 
            this.grpBoxBckUpDB.Controls.Add(this.btnOpenLdfLocation);
            this.grpBoxBckUpDB.Controls.Add(this.txtBoxLdfLocation);
            this.grpBoxBckUpDB.Controls.Add(this.lblSelectLdfLocation);
            this.grpBoxBckUpDB.Controls.Add(this.btnOk);
            this.grpBoxBckUpDB.Controls.Add(this.btnOpenMdfLocation);
            this.grpBoxBckUpDB.Controls.Add(this.txtBoxMdfLocation);
            this.grpBoxBckUpDB.Controls.Add(this.lblSelectDBLocation);
            this.grpBoxBckUpDB.Location = new System.Drawing.Point(37, 74);
            this.grpBoxBckUpDB.Name = "grpBoxBckUpDB";
            this.grpBoxBckUpDB.Size = new System.Drawing.Size(513, 181);
            this.grpBoxBckUpDB.TabIndex = 3;
            this.grpBoxBckUpDB.TabStop = false;
            // 
            // btnOpenLdfLocation
            // 
            this.btnOpenLdfLocation.Location = new System.Drawing.Point(459, 80);
            this.btnOpenLdfLocation.Name = "btnOpenLdfLocation";
            this.btnOpenLdfLocation.Size = new System.Drawing.Size(34, 23);
            this.btnOpenLdfLocation.TabIndex = 6;
            this.btnOpenLdfLocation.UseVisualStyleBackColor = true;
            this.btnOpenLdfLocation.Click += new System.EventHandler(this.btnOpenLdfLocation_Click);
            // 
            // txtBoxLdfLocation
            // 
            this.txtBoxLdfLocation.Location = new System.Drawing.Point(230, 82);
            this.txtBoxLdfLocation.Name = "txtBoxLdfLocation";
            this.txtBoxLdfLocation.ReadOnly = true;
            this.txtBoxLdfLocation.Size = new System.Drawing.Size(214, 20);
            this.txtBoxLdfLocation.TabIndex = 5;
            // 
            // lblSelectLdfLocation
            // 
            this.lblSelectLdfLocation.AutoSize = true;
            this.lblSelectLdfLocation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLdfLocation.Location = new System.Drawing.Point(29, 80);
            this.lblSelectLdfLocation.Name = "lblSelectLdfLocation";
            this.lblSelectLdfLocation.Size = new System.Drawing.Size(145, 19);
            this.lblSelectLdfLocation.TabIndex = 4;
            this.lblSelectLdfLocation.Text = "Select log file (.ldf) :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(206, 134);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnOpenMdfLocation
            // 
            this.btnOpenMdfLocation.Location = new System.Drawing.Point(459, 32);
            this.btnOpenMdfLocation.Name = "btnOpenMdfLocation";
            this.btnOpenMdfLocation.Size = new System.Drawing.Size(34, 23);
            this.btnOpenMdfLocation.TabIndex = 2;
            this.btnOpenMdfLocation.UseVisualStyleBackColor = true;
            this.btnOpenMdfLocation.Click += new System.EventHandler(this.btnOpenMdfLocation_Click);
            // 
            // txtBoxMdfLocation
            // 
            this.txtBoxMdfLocation.Location = new System.Drawing.Point(230, 34);
            this.txtBoxMdfLocation.Name = "txtBoxMdfLocation";
            this.txtBoxMdfLocation.ReadOnly = true;
            this.txtBoxMdfLocation.Size = new System.Drawing.Size(214, 20);
            this.txtBoxMdfLocation.TabIndex = 1;
            // 
            // lblSelectDBLocation
            // 
            this.lblSelectDBLocation.AutoSize = true;
            this.lblSelectDBLocation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDBLocation.Location = new System.Drawing.Point(29, 32);
            this.lblSelectDBLocation.Name = "lblSelectDBLocation";
            this.lblSelectDBLocation.Size = new System.Drawing.Size(195, 19);
            this.lblSelectDBLocation.TabIndex = 0;
            this.lblSelectDBLocation.Text = "Select database file (.mdf) :";
            // 
            // frmRestoreDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 290);
            this.Controls.Add(this.grpBoxBckUpDB);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestoreDB";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpBoxBckUpDB.ResumeLayout(false);
            this.grpBoxBckUpDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpBoxBckUpDB;
        private System.Windows.Forms.Button btnOpenLdfLocation;
        private System.Windows.Forms.TextBox txtBoxLdfLocation;
        private System.Windows.Forms.Label lblSelectLdfLocation;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnOpenMdfLocation;
        private System.Windows.Forms.TextBox txtBoxMdfLocation;
        private System.Windows.Forms.Label lblSelectDBLocation;
    }
}