namespace Analytica_Lab
{
    partial class frmSampling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSampling));
            this.lblSampleName = new System.Windows.Forms.Label();
            this.txtBoxSampleName = new System.Windows.Forms.TextBox();
            this.btnSampleName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSampleName
            // 
            this.lblSampleName.AutoSize = true;
            this.lblSampleName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleName.Location = new System.Drawing.Point(22, 30);
            this.lblSampleName.Name = "lblSampleName";
            this.lblSampleName.Size = new System.Drawing.Size(114, 15);
            this.lblSampleName.TabIndex = 0;
            this.lblSampleName.Text = "Name new sample :";
            // 
            // txtBoxSampleName
            // 
            this.txtBoxSampleName.Location = new System.Drawing.Point(142, 30);
            this.txtBoxSampleName.Name = "txtBoxSampleName";
            this.txtBoxSampleName.Size = new System.Drawing.Size(115, 20);
            this.txtBoxSampleName.TabIndex = 1;
            // 
            // btnSampleName
            // 
            this.btnSampleName.Location = new System.Drawing.Point(85, 73);
            this.btnSampleName.Name = "btnSampleName";
            this.btnSampleName.Size = new System.Drawing.Size(105, 28);
            this.btnSampleName.TabIndex = 2;
            this.btnSampleName.Text = "Ok";
            this.btnSampleName.UseVisualStyleBackColor = true;
            this.btnSampleName.Click += new System.EventHandler(this.btnSampleName_Click);
            // 
            // frmSampling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 130);
            this.Controls.Add(this.btnSampleName);
            this.Controls.Add(this.txtBoxSampleName);
            this.Controls.Add(this.lblSampleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSampling";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSampleName;
        private System.Windows.Forms.TextBox txtBoxSampleName;
        private System.Windows.Forms.Button btnSampleName;
    }
}