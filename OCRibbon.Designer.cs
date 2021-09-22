
namespace OCAnalytics
{
    partial class OCRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public OCRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRibbon));
            this.OCTools = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.ShowPanel = this.Factory.CreateRibbonToggleButton();
            this.Refrescar = this.Factory.CreateRibbonButton();
            this.Configurar = this.Factory.CreateRibbonButton();
            this.OCTools.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OCTools
            // 
            this.OCTools.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.OCTools.ControlId.OfficeId = "TabMail";
            this.OCTools.Groups.Add(this.group1);
            this.OCTools.Label = "TabMail";
            this.OCTools.Name = "OCTools";
            this.OCTools.Tag = "OCTools";
            // 
            // group1
            // 
            this.group1.Items.Add(this.ShowPanel);
            this.group1.Items.Add(this.Refrescar);
            this.group1.Items.Add(this.Configurar);
            this.group1.Label = "General";
            this.group1.Name = "group1";
            // 
            // ShowPanel
            // 
            this.ShowPanel.Checked = true;
            this.ShowPanel.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.ShowPanel.Label = "Ver Panel";
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.ShowImage = true;
            this.ShowPanel.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ShowPanel_Click);
            // 
            // Refrescar
            // 
            this.Refrescar.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Refrescar.Image")));
            this.Refrescar.Label = "Refrescar";
            this.Refrescar.Name = "Refrescar";
            this.Refrescar.ShowImage = true;
            // 
            // Configurar
            // 
            this.Configurar.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Configurar.Label = "Configurar";
            this.Configurar.Name = "Configurar";
            this.Configurar.ShowImage = true;
            // 
            // OCRibbon
            // 
            this.Name = "OCRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.OCTools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OCRibbon_Load);
            this.OCTools.ResumeLayout(false);
            this.OCTools.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        public Microsoft.Office.Tools.Ribbon.RibbonTab OCTools;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton ShowPanel;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Refrescar;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Configurar;
    }

    partial class ThisRibbonCollection
    {
        internal OCRibbon OCRibbon
        {
            get { return this.GetRibbon<OCRibbon>(); }
        }
    }
}
