using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;

namespace OCAnalytics
{
    public partial class ThisAddIn
    {
        public OCAnalyticsPanel ocAnalyticsPanel;
        public Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;


        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new Ribbon();
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            ocAnalyticsPanel = new OCAnalyticsPanel();
            myCustomTaskPane = this.CustomTaskPanes.Add(ocAnalyticsPanel, "OCAnalytics");
            myCustomTaskPane.Visible = false;
            myCustomTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionTop;
        }


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Nota: Outlook ya no genera este evento. Si tiene código que 
            //    se debe ejecutar cuando Outlook se apaga, consulte https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region Código generado por VSTO

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
