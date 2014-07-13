namespace TextCleaner
{
    partial class MainRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbon()
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
            this.TabMain = this.Factory.CreateRibbonTab();
            this.GroupMain = this.Factory.CreateRibbonGroup();
            this.BtnClean = this.Factory.CreateRibbonButton();
            this.BtnMerge = this.Factory.CreateRibbonButton();
            this.TabMain.SuspendLayout();
            this.GroupMain.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.TabMain.Groups.Add(this.GroupMain);
            this.TabMain.Label = "TabAddIns";
            this.TabMain.Name = "TabMain";
            // 
            // GroupMain
            // 
            this.GroupMain.Items.Add(this.BtnClean);
            this.GroupMain.Items.Add(this.BtnMerge);
            this.GroupMain.Label = "Main";
            this.GroupMain.Name = "GroupMain";
            // 
            // BtnClean
            // 
            this.BtnClean.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnClean.Image = global::TextCleaner.Properties.Resources.Broom;
            this.BtnClean.Label = "Clean";
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.ShowImage = true;
            this.BtnClean.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnClean_Click);
            // 
            // BtnMerge
            // 
            this.BtnMerge.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnMerge.Image = global::TextCleaner.Properties.Resources.Merge;
            this.BtnMerge.Label = "Merge";
            this.BtnMerge.Name = "BtnMerge";
            this.BtnMerge.ShowImage = true;
            this.BtnMerge.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnMerge_Click);
            // 
            // MainRibbon
            // 
            this.Name = "MainRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.TabMain);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainRibbon_Load);
            this.TabMain.ResumeLayout(false);
            this.TabMain.PerformLayout();
            this.GroupMain.ResumeLayout(false);
            this.GroupMain.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabMain;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupMain;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnClean;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnMerge;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbon MainRibbon
        {
            get { return this.GetRibbon<MainRibbon>(); }
        }
    }
}
