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
            this.btnLoadDelimitedFile = this.Factory.CreateRibbonButton();
            this.tabLoadToText.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLoadToText
            // 
            this.tabLoadToText.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabLoadToText.Groups.Add(this.grpActions);
            this.tabLoadToText.Label = "TabAddIns";
            this.tabLoadToText.Name = "tabLoadToText";
            // 
            // grpActions
            // 
            this.grpActions.Items.Add(this.btnLoadDelimitedFile);
            this.grpActions.Label = "Excel L2T";
            this.grpActions.Name = "grpActions";
            // 
            // btnLoadDelimitedFile
            // 
            this.btnLoadDelimitedFile.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLoadDelimitedFile.Image = global::excel_load_to_text.Properties.Resources.ic_text_document;
            this.btnLoadDelimitedFile.Label = "Load Delimited File";
            this.btnLoadDelimitedFile.Name = "btnLoadDelimitedFile";
            this.btnLoadDelimitedFile.ShowImage = true;
            this.btnLoadDelimitedFile.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLoadDelimitedFile_Click);
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLoadDelimitedFile;
    }

    partial class ThisRibbonCollection
    {
        internal rbnThisAddin Ribbon1
        {
            get { return this.GetRibbon<rbnThisAddin>(); }
        }
    }
}
