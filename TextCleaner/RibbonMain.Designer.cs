namespace TextCleaner
{
    partial class RibbonMain : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonMain()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = this.Factory.CreateRibbonTab();
            this.DTP = this.Factory.CreateRibbonGroup();
            this.btnLaunch = this.Factory.CreateRibbonButton();
            this.btnMerge = this.Factory.CreateRibbonButton();
            this.tabMain.SuspendLayout();
            this.DTP.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabMain.Groups.Add(this.DTP);
            this.tabMain.Label = "TabAddIns";
            this.tabMain.Name = "tabMain";
            // 
            // DTP
            // 
            this.DTP.Items.Add(this.btnLaunch);
            this.DTP.Items.Add(this.btnMerge);
            this.DTP.Label = "DTP";
            this.DTP.Name = "DTP";
            // 
            // btnLaunch
            // 
            this.btnLaunch.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLaunch.Image = global::TextCleaner.Properties.Resources._400px_broom_icon;
            this.btnLaunch.Label = "TextCleaner";
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.ShowImage = true;
            this.btnLaunch.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLaunch_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnMerge.Label = "Merge";
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.ShowImage = true;
            this.btnMerge.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMerge_Click);
            // 
            // RibbonMain
            // 
            this.Name = "RibbonMain";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tabMain);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.DTP.ResumeLayout(false);
            this.DTP.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabMain;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup DTP;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLaunch;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMerge;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonMain Ribbon1
        {
            get { return this.GetRibbon<RibbonMain>(); }
        }
    }
}
