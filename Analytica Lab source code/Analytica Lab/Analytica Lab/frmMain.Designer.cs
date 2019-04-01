namespace Analytica_Lab
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.cntxtMenuMainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takeAPortionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripMainForm = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSubSample = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSeperate = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            this.pnlRgnts_Op = new BSE.Windows.Forms.Panel();
            this.xPanderPanelList1 = new BSE.Windows.Forms.XPanderPanelList();
            this.xPanderPnlRgnts = new BSE.Windows.Forms.XPanderPanel();
            this.pnlRgnts = new System.Windows.Forms.Panel();
            this.xPanderPnlOprtns = new BSE.Windows.Forms.XPanderPanel();
            this.pnlInProgress = new BSE.Windows.Forms.Panel();
            this.treeViewSample = new System.Windows.Forms.TreeView();
            this.picBoxSample = new System.Windows.Forms.PictureBox();
            this.pnlMsgs = new BSE.Windows.Forms.Panel();
            this.richTxtBoxStatus = new System.Windows.Forms.RichTextBox();
            this.cntxtMenuMainForm.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripMainForm.SuspendLayout();
            this.pnlViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            this.pnlRgnts_Op.SuspendLayout();
            this.xPanderPanelList1.SuspendLayout();
            this.xPanderPnlRgnts.SuspendLayout();
            this.pnlInProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSample)).BeginInit();
            this.pnlMsgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntxtMenuMainForm
            // 
            this.cntxtMenuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeAPortionToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.cntxtMenuMainForm.Name = "cntxtMenuMainForm";
            this.cntxtMenuMainForm.Size = new System.Drawing.Size(151, 48);
            // 
            // takeAPortionToolStripMenuItem
            // 
            this.takeAPortionToolStripMenuItem.Name = "takeAPortionToolStripMenuItem";
            this.takeAPortionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.takeAPortionToolStripMenuItem.Text = "Take a portion";
            this.takeAPortionToolStripMenuItem.Click += new System.EventHandler(this.takeAPortionToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 78);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(1370, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(1370, 25);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightToolStripPanel.Location = new System.Drawing.Point(1370, 25);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 53);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 53);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Size = new System.Drawing.Size(1370, 53);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStripMainForm);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1370, 53);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1370, 78);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripMainForm
            // 
            this.toolStripMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNew,
            this.toolStripBtnOpen,
            this.toolStripBtnSave,
            this.toolStripBtnAbout,
            this.toolStripBtnHelp,
            this.toolStripSeparator4,
            this.toolStripSeparator1,
            this.toolStripBtnSubSample,
            this.toolStripBtnSeperate,
            this.toolStripBtnOptions,
            this.toolStripBtnDB,
            this.toolStripSeparator2});
            this.toolStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainForm.Name = "toolStripMainForm";
            this.toolStripMainForm.Size = new System.Drawing.Size(1368, 51);
            this.toolStripMainForm.TabIndex = 2;
            // 
            // toolStripBtnNew
            // 
            this.toolStripBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNew.Image")));
            this.toolStripBtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNew.Name = "toolStripBtnNew";
            this.toolStripBtnNew.Size = new System.Drawing.Size(52, 48);
            this.toolStripBtnNew.ToolTipText = "Create a new sample";
            this.toolStripBtnNew.Click += new System.EventHandler(this.toolStripBtnNew_Click);
            // 
            // toolStripBtnOpen
            // 
            this.toolStripBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpen.Image")));
            this.toolStripBtnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpen.Name = "toolStripBtnOpen";
            this.toolStripBtnOpen.Size = new System.Drawing.Size(52, 48);
            this.toolStripBtnOpen.ToolTipText = "Open a saved data file of a sample";
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSave.Image")));
            this.toolStripBtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(52, 48);
            this.toolStripBtnSave.Text = "toolStripButton1";
            this.toolStripBtnSave.ToolTipText = "Save all the samples in current project";
            this.toolStripBtnSave.Click += new System.EventHandler(this.toolStripBtnSave_Click);
            // 
            // toolStripBtnAbout
            // 
            this.toolStripBtnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAbout.Image")));
            this.toolStripBtnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAbout.Name = "toolStripBtnAbout";
            this.toolStripBtnAbout.Size = new System.Drawing.Size(52, 48);
            this.toolStripBtnAbout.ToolTipText = "About Analytica Lab";
            this.toolStripBtnAbout.Click += new System.EventHandler(this.toolStripBtnAbout_Click);
            // 
            // toolStripBtnHelp
            // 
            this.toolStripBtnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHelp.Image")));
            this.toolStripBtnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnHelp.Name = "toolStripBtnHelp";
            this.toolStripBtnHelp.Size = new System.Drawing.Size(52, 48);
            this.toolStripBtnHelp.ToolTipText = "Open help";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripBtnSubSample
            // 
            this.toolStripBtnSubSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSubSample.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSubSample.Image")));
            this.toolStripBtnSubSample.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSubSample.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSubSample.Name = "toolStripBtnSubSample";
            this.toolStripBtnSubSample.Size = new System.Drawing.Size(52, 48);
            this.toolStripBtnSubSample.Text = "Take portion from the selected sample";
            this.toolStripBtnSubSample.Click += new System.EventHandler(this.toolStripBtnSubSample_Click);
            // 
            // toolStripBtnSeperate
            // 
            this.toolStripBtnSeperate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSeperate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSeperate.Image")));
            this.toolStripBtnSeperate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSeperate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSeperate.Name = "toolStripBtnSeperate";
            this.toolStripBtnSeperate.Size = new System.Drawing.Size(52, 48);
            this.toolStripBtnSeperate.ToolTipText = "Centrifuge and seperate";
            this.toolStripBtnSeperate.Click += new System.EventHandler(this.toolStripBtnSeperate_Click);
            // 
            // toolStripBtnOptions
            // 
            this.toolStripBtnOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOptions.Image")));
            this.toolStripBtnOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOptions.Name = "toolStripBtnOptions";
            this.toolStripBtnOptions.Size = new System.Drawing.Size(52, 48);
            this.toolStripBtnOptions.ToolTipText = "Open program settings";
            this.toolStripBtnOptions.Click += new System.EventHandler(this.toolStripBtnOptions_Click);
            // 
            // toolStripBtnDB
            // 
            this.toolStripBtnDB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDB.Image")));
            this.toolStripBtnDB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDB.Name = "toolStripBtnDB";
            this.toolStripBtnDB.Size = new System.Drawing.Size(68, 48);
            this.toolStripBtnDB.ToolTipText = "Open up the database";
            this.toolStripBtnDB.Click += new System.EventHandler(this.toolStripBtnDB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // pnlViewer
            // 
            this.pnlViewer.AutoScroll = true;
            this.pnlViewer.AutoSize = true;
            this.pnlViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewer.Controls.Add(this.pdfViewer);
            this.pnlViewer.Location = new System.Drawing.Point(342, 79);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(721, 408);
            this.pnlViewer.TabIndex = 5;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(719, 406);
            this.pdfViewer.TabIndex = 0;
            this.pdfViewer.OnError += new System.EventHandler(this.pdfViewer_OnError);
            // 
            // pnlRgnts_Op
            // 
            this.pnlRgnts_Op.AssociatedSplitter = null;
            this.pnlRgnts_Op.BackColor = System.Drawing.Color.Transparent;
            this.pnlRgnts_Op.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.pnlRgnts_Op.CaptionHeight = 27;
            this.pnlRgnts_Op.Controls.Add(this.xPanderPanelList1);
            this.pnlRgnts_Op.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlRgnts_Op.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pnlRgnts_Op.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pnlRgnts_Op.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlRgnts_Op.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pnlRgnts_Op.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlRgnts_Op.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pnlRgnts_Op.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pnlRgnts_Op.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlRgnts_Op.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlRgnts_Op.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.pnlRgnts_Op.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlRgnts_Op.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pnlRgnts_Op.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRgnts_Op.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlRgnts_Op.Image = null;
            this.pnlRgnts_Op.Location = new System.Drawing.Point(0, 78);
            this.pnlRgnts_Op.MinimumSize = new System.Drawing.Size(27, 27);
            this.pnlRgnts_Op.Name = "pnlRgnts_Op";
            this.pnlRgnts_Op.ShowExpandIcon = true;
            this.pnlRgnts_Op.Size = new System.Drawing.Size(274, 621);
            this.pnlRgnts_Op.TabIndex = 6;
            this.pnlRgnts_Op.ToolTipTextCloseIcon = null;
            this.pnlRgnts_Op.ToolTipTextExpandIconPanelCollapsed = null;
            this.pnlRgnts_Op.ToolTipTextExpandIconPanelExpanded = null;
            this.pnlRgnts_Op.PanelExpanding += new System.EventHandler<BSE.Windows.Forms.XPanderStateChangeEventArgs>(this.pnlRgnts_Op_PanelExpanding);
            this.pnlRgnts_Op.PanelCollapsing += new System.EventHandler<BSE.Windows.Forms.XPanderStateChangeEventArgs>(this.pnlRgnts_Op_PanelCollapsing);
            // 
            // xPanderPanelList1
            // 
            this.xPanderPanelList1.CaptionStyle = BSE.Windows.Forms.CaptionStyle.Normal;
            this.xPanderPanelList1.Controls.Add(this.xPanderPnlRgnts);
            this.xPanderPanelList1.Controls.Add(this.xPanderPnlOprtns);
            this.xPanderPanelList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanderPanelList1.GradientBackground = System.Drawing.Color.Empty;
            this.xPanderPanelList1.Location = new System.Drawing.Point(0, 28);
            this.xPanderPanelList1.Name = "xPanderPanelList1";
            this.xPanderPanelList1.PanelColors = null;
            this.xPanderPanelList1.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPanelList1.Size = new System.Drawing.Size(274, 592);
            this.xPanderPanelList1.TabIndex = 0;
            this.xPanderPanelList1.Text = "xPanderPanelList1";
            // 
            // xPanderPnlRgnts
            // 
            this.xPanderPnlRgnts.CaptionFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.xPanderPnlRgnts.Controls.Add(this.pnlRgnts);
            this.xPanderPnlRgnts.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPnlRgnts.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPnlRgnts.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPnlRgnts.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPnlRgnts.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPnlRgnts.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlRgnts.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlRgnts.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPnlRgnts.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPnlRgnts.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPnlRgnts.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xPanderPnlRgnts.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xPanderPnlRgnts.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xPanderPnlRgnts.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xPanderPnlRgnts.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xPanderPnlRgnts.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xPanderPnlRgnts.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlRgnts.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlRgnts.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPnlRgnts.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPnlRgnts.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPnlRgnts.Expand = true;
            this.xPanderPnlRgnts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlRgnts.Image = null;
            this.xPanderPnlRgnts.Name = "xPanderPnlRgnts";
            this.xPanderPnlRgnts.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPnlRgnts.Size = new System.Drawing.Size(274, 567);
            this.xPanderPnlRgnts.TabIndex = 1;
            this.xPanderPnlRgnts.Text = "                      Reagents";
            this.xPanderPnlRgnts.ToolTipTextCloseIcon = null;
            this.xPanderPnlRgnts.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPnlRgnts.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // pnlRgnts
            // 
            this.pnlRgnts.AutoScroll = true;
            this.pnlRgnts.Location = new System.Drawing.Point(6, 29);
            this.pnlRgnts.Name = "pnlRgnts";
            this.pnlRgnts.Size = new System.Drawing.Size(262, 532);
            this.pnlRgnts.TabIndex = 0;
            // 
            // xPanderPnlOprtns
            // 
            this.xPanderPnlOprtns.CaptionFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.xPanderPnlOprtns.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPnlOprtns.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.xPanderPnlOprtns.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
            this.xPanderPnlOprtns.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
            this.xPanderPnlOprtns.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
            this.xPanderPnlOprtns.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlOprtns.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlOprtns.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPnlOprtns.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.xPanderPnlOprtns.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPnlOprtns.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xPanderPnlOprtns.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xPanderPnlOprtns.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.xPanderPnlOprtns.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xPanderPnlOprtns.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xPanderPnlOprtns.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.xPanderPnlOprtns.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlOprtns.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlOprtns.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.xPanderPnlOprtns.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.xPanderPnlOprtns.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.xPanderPnlOprtns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPnlOprtns.Image = null;
            this.xPanderPnlOprtns.Name = "xPanderPnlOprtns";
            this.xPanderPnlOprtns.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
            this.xPanderPnlOprtns.Size = new System.Drawing.Size(274, 25);
            this.xPanderPnlOprtns.TabIndex = 0;
            this.xPanderPnlOprtns.Text = "                      Operations";
            this.xPanderPnlOprtns.ToolTipTextCloseIcon = null;
            this.xPanderPnlOprtns.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPnlOprtns.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.AssociatedSplitter = null;
            this.pnlInProgress.BackColor = System.Drawing.Color.Transparent;
            this.pnlInProgress.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.pnlInProgress.CaptionHeight = 27;
            this.pnlInProgress.Controls.Add(this.treeViewSample);
            this.pnlInProgress.Controls.Add(this.picBoxSample);
            this.pnlInProgress.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlInProgress.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pnlInProgress.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pnlInProgress.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlInProgress.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pnlInProgress.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlInProgress.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pnlInProgress.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pnlInProgress.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlInProgress.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlInProgress.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.pnlInProgress.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlInProgress.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pnlInProgress.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInProgress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlInProgress.Image = null;
            this.pnlInProgress.Location = new System.Drawing.Point(1111, 78);
            this.pnlInProgress.MinimumSize = new System.Drawing.Size(27, 27);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.ShowExpandIcon = true;
            this.pnlInProgress.Size = new System.Drawing.Size(259, 621);
            this.pnlInProgress.TabIndex = 7;
            this.pnlInProgress.ToolTipTextCloseIcon = null;
            this.pnlInProgress.ToolTipTextExpandIconPanelCollapsed = null;
            this.pnlInProgress.ToolTipTextExpandIconPanelExpanded = null;
            this.pnlInProgress.PanelExpanding += new System.EventHandler<BSE.Windows.Forms.XPanderStateChangeEventArgs>(this.pnlInProgress_PanelExpanding);
            this.pnlInProgress.PanelCollapsing += new System.EventHandler<BSE.Windows.Forms.XPanderStateChangeEventArgs>(this.pnlInProgress_PanelCollapsing);
            // 
            // treeViewSample
            // 
            this.treeViewSample.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSample.Location = new System.Drawing.Point(11, 320);
            this.treeViewSample.Name = "treeViewSample";
            this.treeViewSample.Size = new System.Drawing.Size(238, 287);
            this.treeViewSample.TabIndex = 2;
            this.treeViewSample.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewSample_AfterLabelEdit);
            this.treeViewSample.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSample_NodeMouseClick);
            // 
            // picBoxSample
            // 
            this.picBoxSample.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxSample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxSample.Location = new System.Drawing.Point(11, 39);
            this.picBoxSample.Name = "picBoxSample";
            this.picBoxSample.Size = new System.Drawing.Size(239, 275);
            this.picBoxSample.TabIndex = 1;
            this.picBoxSample.TabStop = false;
            // 
            // pnlMsgs
            // 
            this.pnlMsgs.AssociatedSplitter = null;
            this.pnlMsgs.BackColor = System.Drawing.Color.Transparent;
            this.pnlMsgs.CaptionFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.pnlMsgs.CaptionHeight = 27;
            this.pnlMsgs.Controls.Add(this.richTxtBoxStatus);
            this.pnlMsgs.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlMsgs.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pnlMsgs.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pnlMsgs.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlMsgs.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pnlMsgs.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlMsgs.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pnlMsgs.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.pnlMsgs.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlMsgs.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlMsgs.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.pnlMsgs.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlMsgs.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pnlMsgs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMsgs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMsgs.Image = null;
            this.pnlMsgs.Location = new System.Drawing.Point(274, 487);
            this.pnlMsgs.MinimumSize = new System.Drawing.Size(27, 27);
            this.pnlMsgs.Name = "pnlMsgs";
            this.pnlMsgs.ShowExpandIcon = true;
            this.pnlMsgs.Size = new System.Drawing.Size(837, 212);
            this.pnlMsgs.TabIndex = 8;
            this.pnlMsgs.ToolTipTextCloseIcon = null;
            this.pnlMsgs.ToolTipTextExpandIconPanelCollapsed = null;
            this.pnlMsgs.ToolTipTextExpandIconPanelExpanded = null;
            this.pnlMsgs.PanelExpanding += new System.EventHandler<BSE.Windows.Forms.XPanderStateChangeEventArgs>(this.pnlMsgs_PanelExpanding);
            this.pnlMsgs.PanelCollapsing += new System.EventHandler<BSE.Windows.Forms.XPanderStateChangeEventArgs>(this.pnlMsgs_PanelCollapsing);
            // 
            // richTxtBoxStatus
            // 
            this.richTxtBoxStatus.BackColor = System.Drawing.Color.White;
            this.richTxtBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBoxStatus.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxStatus.Location = new System.Drawing.Point(1, 28);
            this.richTxtBoxStatus.Name = "richTxtBoxStatus";
            this.richTxtBoxStatus.ReadOnly = true;
            this.richTxtBoxStatus.Size = new System.Drawing.Size(835, 183);
            this.richTxtBoxStatus.TabIndex = 1;
            this.richTxtBoxStatus.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 699);
            this.Controls.Add(this.pnlMsgs);
            this.Controls.Add(this.pnlInProgress);
            this.Controls.Add(this.pnlRgnts_Op);
            this.Controls.Add(this.pnlViewer);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Analytica Lab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cntxtMenuMainForm.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripMainForm.ResumeLayout(false);
            this.toolStripMainForm.PerformLayout();
            this.pnlViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            this.pnlRgnts_Op.ResumeLayout(false);
            this.xPanderPanelList1.ResumeLayout(false);
            this.xPanderPnlRgnts.ResumeLayout(false);
            this.pnlInProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSample)).EndInit();
            this.pnlMsgs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipMainForm;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuMainForm;
        private System.Windows.Forms.ToolStripMenuItem takeAPortionToolStripMenuItem;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripMainForm;
        private System.Windows.Forms.ToolStripButton toolStripBtnSeperate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnNew;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpen;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnOptions;
        private System.Windows.Forms.ToolStripButton toolStripBtnDB;
        private System.Windows.Forms.ToolStripButton toolStripBtnAbout;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripBtnSubSample;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.Panel pnlViewer;
        private BSE.Windows.Forms.Panel pnlRgnts_Op;
        private BSE.Windows.Forms.XPanderPanelList xPanderPanelList1;
        private BSE.Windows.Forms.XPanderPanel xPanderPnlRgnts;
        private BSE.Windows.Forms.XPanderPanel xPanderPnlOprtns;
        private System.Windows.Forms.Panel pnlRgnts;
        private BSE.Windows.Forms.Panel pnlInProgress;
        public System.Windows.Forms.TreeView treeViewSample;
        private System.Windows.Forms.PictureBox picBoxSample;
        private BSE.Windows.Forms.Panel pnlMsgs;
        private System.Windows.Forms.RichTextBox richTxtBoxStatus;
        private AxAcroPDFLib.AxAcroPDF pdfViewer;
    }
}

