using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace OCAnalytics
{
    public partial class OCRibbon: RibbonBase
    {

        private void OCRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void ShowPanel_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn.CustomTaskPanes.Count>0)
            {
                Globals.ThisAddIn.CustomTaskPanes[0].Visible = ((RibbonToggleButton)sender).Checked;
                Globals.ThisAddIn.myCustomTaskPane.Visible = ((RibbonToggleButton)sender).Checked; 
            }
        }
    }
}
