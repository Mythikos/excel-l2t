namespace excel_load_to_text
{
    partial class rbnThisAddin : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public rbnThisAddin()
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
            this.tabLoadToText = this.Factory.CreateRibbonTab();
            this.grpActions = this.Factory.CreateRibbonGroup();
            this.btnLoadFromText = this.Factory.CreateRibbonButton();
            this.tabLoadToText.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLoadToText
            // 
            this.tabLoadToText.Groups.Add(this.grpActions);
            this.tabLoadToText.Label = "L2T";
            this.tabLoadToText.Name = "tabLoadToText";
            // 
            // grpActions
            // 
            this.grpActions.Items.Add(this.btnLoadFromText);
            this.grpActions.Label = "Actions";
            this.grpActions.Name = "grpActions";
            // 
            // btnLoadFromText
            // 
            this.btnLoadFromText.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLoadFromText.Image = global::excel_load_to_text.Properties.Resources.ic_text_document;
            this.btnLoadFromText.Label = "From Text";
            this.btnLoadFromText.Name = "btnLoadFromText";
            this.btnLoadFromText.ShowImage = true;
            this.btnLoadFromText.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLoadFromText_Click);
            // 
            // rbnThisAddin
            // 
            this.Name = "rbnThisAddin";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabLoadToText);
            this.tabLoadToText.ResumeLayout(false);
            this.tabLoadToText.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabLoadToText;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpActions;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLoadFromText;
    }

    partial class ThisRibbonCollection
    {
        internal rbnThisAddin Ribbon1
        {
            get { return this.GetRibbon<rbnThisAddin>(); }
        }
    }
}
