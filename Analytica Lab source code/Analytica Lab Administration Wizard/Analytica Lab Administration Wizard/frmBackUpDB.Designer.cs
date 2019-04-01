namespace Analytica_Lab_Administration_Wizard
{
    partial class frmBackUpDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUpDB));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpBoxBckUpDB = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOpenLocation = new System.Windows.Forms.Button();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.lblSelectDBLocation = new System.Windows.Forms.Label();
            this.grpBoxBckUpDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(150, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(193, 22);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Backup your data base";
            // 
            // grpBoxBckUpDB
            // 
            this.grpBoxBckUpDB.Controls.Add(this.btnOk);
            this.grpBoxBckUpDB.Controls.Add(this.btnOpenLocation);
            this.grpBoxBckUpDB.Controls.Add(this.txtBoxLocation);
            this.grpBoxBckUpDB.Controls.Add(this.lblSelectDBLocation);
            this.grpBoxBckUpDB.Location = new System.Drawing.Point(41, 64);
            this.grpBoxBckUpDB.Name = "grpBoxBckUpDB";
            this.grpBoxBckUpDB.Size = new System.Drawing.Size(433, 134);
            this.grpBoxBckUpDB.TabIndex = 2;
            this.grpBoxBckUpDB.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(207, 84);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnOpenLocation
            // 
            this.btnOpenLocation.Location = new System.Drawing.Point(380, 32);
            this.btnOpenLocation.Name = "btnOpenLocation";
            this.btnOpenLocation.Size = new System.Drawing.Size(34, 23);
            this.btnOpenLocation.TabIndex = 2;
            this.btnOpenLocation.UseVisualStyleBackColor = true;
            this.btnOpenLocation.Click += new System.EventHandler(this.btnOpenLocation_Click);
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.Location = new System.Drawing.Point(151, 32);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.ReadOnly = true;
            this.txtBoxLocation.Size = new System.Drawing.Size(214, 23);
            this.txtBoxLocation.TabIndex = 1;
            // 
            // lblSelectDBLocation
            // 
            this.lblSelectDBLocation.AutoSize = true;
            this.lblSelectDBLocation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDBLocation.Location = new System.Drawing.Point(29, 32);
            this.lblSelectDBLocation.Name = "lblSelectDBLocation";
            this.lblSelectDBLocation.Size = new System.Drawing.Size(116, 19);
            this.lblSelectDBLocation.TabIndex = 0;
            this.lblSelectDBLocation.Text = "Select location :";
            // 
            // frmBackUpDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 234);
            this.Controls.Add(this.grpBoxBckUpDB);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackUpDB";
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
        private System.Windows.Forms.Button btnOpenLocation;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Label lblSelectDBLocation;
        private System.Windows.Forms.Button btnOk;
    }
}