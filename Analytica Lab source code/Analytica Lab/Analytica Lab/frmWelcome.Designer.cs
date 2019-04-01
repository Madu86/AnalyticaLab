namespace Analytica_Lab
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSamplingType = new System.Windows.Forms.Label();
            this.grpBoxSelectSampleType = new System.Windows.Forms.GroupBox();
            this.radioBtnRandomSample = new System.Windows.Forms.RadioButton();
            this.radioBtnCustomSample = new System.Windows.Forms.RadioButton();
            this.radioBtnOpenSample = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpenSample = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpBoxSelectSampleType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(138, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(261, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Analytica Lab...!";
            // 
            // lblSamplingType
            // 
            this.lblSamplingType.AutoSize = true;
            this.lblSamplingType.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamplingType.Location = new System.Drawing.Point(26, 91);
            this.lblSamplingType.Name = "lblSamplingType";
            this.lblSamplingType.Size = new System.Drawing.Size(221, 19);
            this.lblSamplingType.TabIndex = 1;
            this.lblSamplingType.Text = "What do you want to analyze? \r\n";
            // 
            // grpBoxSelectSampleType
            // 
            this.grpBoxSelectSampleType.Controls.Add(this.radioBtnRandomSample);
            this.grpBoxSelectSampleType.Controls.Add(this.radioBtnCustomSample);
            this.grpBoxSelectSampleType.Controls.Add(this.radioBtnOpenSample);
            this.grpBoxSelectSampleType.Controls.Add(this.label2);
            this.grpBoxSelectSampleType.Controls.Add(this.label1);
            this.grpBoxSelectSampleType.Controls.Add(this.lblOpenSample);
            this.grpBoxSelectSampleType.Location = new System.Drawing.Point(30, 126);
            this.grpBoxSelectSampleType.Name = "grpBoxSelectSampleType";
            this.grpBoxSelectSampleType.Size = new System.Drawing.Size(524, 143);
            this.grpBoxSelectSampleType.TabIndex = 2;
            this.grpBoxSelectSampleType.TabStop = false;
            // 
            // radioBtnRandomSample
            // 
            this.radioBtnRandomSample.AutoSize = true;
            this.radioBtnRandomSample.Location = new System.Drawing.Point(487, 113);
            this.radioBtnRandomSample.Name = "radioBtnRandomSample";
            this.radioBtnRandomSample.Size = new System.Drawing.Size(14, 13);
            this.radioBtnRandomSample.TabIndex = 7;
            this.radioBtnRandomSample.TabStop = true;
            this.radioBtnRandomSample.UseVisualStyleBackColor = true;
            // 
            // radioBtnCustomSample
            // 
            this.radioBtnCustomSample.AutoSize = true;
            this.radioBtnCustomSample.Location = new System.Drawing.Point(487, 73);
            this.radioBtnCustomSample.Name = "radioBtnCustomSample";
            this.radioBtnCustomSample.Size = new System.Drawing.Size(14, 13);
            this.radioBtnCustomSample.TabIndex = 6;
            this.radioBtnCustomSample.TabStop = true;
            this.radioBtnCustomSample.UseVisualStyleBackColor = true;
            // 
            // radioBtnOpenSample
            // 
            this.radioBtnOpenSample.AutoSize = true;
            this.radioBtnOpenSample.Location = new System.Drawing.Point(487, 31);
            this.radioBtnOpenSample.Name = "radioBtnOpenSample";
            this.radioBtnOpenSample.Size = new System.Drawing.Size(14, 13);
            this.radioBtnOpenSample.TabIndex = 5;
            this.radioBtnOpenSample.TabStop = true;
            this.radioBtnOpenSample.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "I dont have a sample. Lets make a random sample and analyze it...!  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "I dont have a sample. Lets make a sample with preferred cations...!  ";
            // 
            // lblOpenSample
            // 
            this.lblOpenSample.AutoSize = true;
            this.lblOpenSample.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenSample.Location = new System.Drawing.Point(6, 27);
            this.lblOpenSample.Name = "lblOpenSample";
            this.lblOpenSample.Size = new System.Drawing.Size(369, 19);
            this.lblOpenSample.TabIndex = 2;
            this.lblOpenSample.Text = "I already have an unknown sample. Lets analyze it...!";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(463, 303);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 36);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmWelcome
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(585, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpBoxSelectSampleType);
            this.Controls.Add(this.lblSamplingType);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWelcome";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.grpBoxSelectSampleType.ResumeLayout(false);
            this.grpBoxSelectSampleType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSamplingType;
        private System.Windows.Forms.GroupBox grpBoxSelectSampleType;
        private System.Windows.Forms.RadioButton radioBtnRandomSample;
        private System.Windows.Forms.RadioButton radioBtnCustomSample;
        private System.Windows.Forms.RadioButton radioBtnOpenSample;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpenSample;
        private System.Windows.Forms.Button btnNext;
    }
}