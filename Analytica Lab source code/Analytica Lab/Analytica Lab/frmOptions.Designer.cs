namespace Analytica_Lab
{
    partial class frmOptions
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
            this.numericUpDownRndSmplng = new System.Windows.Forms.NumericUpDown();
            this.grpBoxRndSmplngOptns = new System.Windows.Forms.GroupBox();
            this.lblmaxComponents = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRndSmplng)).BeginInit();
            this.grpBoxRndSmplngOptns.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownRndSmplng
            // 
            this.numericUpDownRndSmplng.Location = new System.Drawing.Point(252, 39);
            this.numericUpDownRndSmplng.Name = "numericUpDownRndSmplng";
            this.numericUpDownRndSmplng.Size = new System.Drawing.Size(49, 23);
            this.numericUpDownRndSmplng.TabIndex = 0;
            // 
            // grpBoxRndSmplngOptns
            // 
            this.grpBoxRndSmplngOptns.Controls.Add(this.lblmaxComponents);
            this.grpBoxRndSmplngOptns.Controls.Add(this.numericUpDownRndSmplng);
            this.grpBoxRndSmplngOptns.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRndSmplngOptns.Location = new System.Drawing.Point(23, 24);
            this.grpBoxRndSmplngOptns.Name = "grpBoxRndSmplngOptns";
            this.grpBoxRndSmplngOptns.Size = new System.Drawing.Size(339, 93);
            this.grpBoxRndSmplngOptns.TabIndex = 1;
            this.grpBoxRndSmplngOptns.TabStop = false;
            this.grpBoxRndSmplngOptns.Text = "Random Sampling";
            // 
            // lblmaxComponents
            // 
            this.lblmaxComponents.AutoSize = true;
            this.lblmaxComponents.Location = new System.Drawing.Point(27, 41);
            this.lblmaxComponents.Name = "lblmaxComponents";
            this.lblmaxComponents.Size = new System.Drawing.Size(219, 15);
            this.lblmaxComponents.TabIndex = 1;
            this.lblmaxComponents.Text = "Number of species in random sample :";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(290, 133);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(72, 34);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 183);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpBoxRndSmplngOptns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRndSmplng)).EndInit();
            this.grpBoxRndSmplngOptns.ResumeLayout(false);
            this.grpBoxRndSmplngOptns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRndSmplng;
        private System.Windows.Forms.GroupBox grpBoxRndSmplngOptns;
        private System.Windows.Forms.Label lblmaxComponents;
        private System.Windows.Forms.Button btnOk;
    }
}