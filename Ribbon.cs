﻿using Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;
using OCAnalytics.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;

// TODO:  Siga estos pasos para habilitar el elemento (XML) de la cinta de opciones:

// 1: Copie el siguiente bloque de código en la clase ThisAddin, ThisWorkbook o ThisDocument.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new Ribbon();
//  }

// 2. Cree métodos de devolución de llamada en el área "Devolución de llamadas de la cinta de opciones" de esta clase para controlar acciones del usuario,
//    como hacer clic en un botón. Nota: si ha exportado esta cinta de opciones desde el diseñador de la cinta de opciones,
//    mueva el código de los controladores de eventos a los métodos de devolución de llamada y modifique el código para que funcione con el
//    modelo de programación de extensibilidad de la cinta de opciones (RibbonX).

// 3. Asigne atributos a las etiquetas de control del archivo XML de la cinta de opciones para identificar los métodos de devolución de llamada apropiados en el código.  

// Para obtener más información, vea la documentación XML de la cinta de opciones en la Ayuda de Visual Studio Tools para Office.


namespace OCAnalytics
{
    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public Ribbon()
        {
        }

        #region Miembros de IRibbonExtensibility

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("OCAnalytics.Ribbon.xml");
        }

        #endregion

        #region Devoluciones de llamada de la cinta de opciones
        //Cree métodos de devolución de llamada aquí. Para obtener más información sobre la adición de métodos de devolución de llamada, visite https://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        public void ToggleVisibility(Office.IRibbonControl Control, bool isPressed)
        {
            Globals.ThisAddIn.myCustomTaskPane.Visible = isPressed;
            Globals.ThisAddIn.ocAnalyticsPanel.tpAnalisis.Visible = isPressed;
            Globals.ThisAddIn.ocAnalyticsPanel.tpConfiguration.Visible = !isPressed;
            if (isPressed)
            {
                Globals.ThisAddIn.ocAnalyticsPanel.Refrescar();
            }
        }

        public void ToggleConfiguration(Office.IRibbonControl Control, bool isPressed)
        {
            Globals.ThisAddIn.myCustomTaskPane.Visible = isPressed;
            Globals.ThisAddIn.ocAnalyticsPanel.tpConfiguration.Visible = isPressed;
            Globals.ThisAddIn.ocAnalyticsPanel.tpAnalisis.Visible = !isPressed;
        }

        public void RefreshData(Office.IRibbonControl Control)
        {
            Globals.ThisAddIn.myCustomTaskPane.Visible = true;
            Globals.ThisAddIn.ocAnalyticsPanel.tpAnalisis.Visible = true;
            Globals.ThisAddIn.ocAnalyticsPanel.tpConfiguration.Visible = false;
            Globals.ThisAddIn.ocAnalyticsPanel.Refrescar();
        }

        public Bitmap GetRefreshImage(IRibbonControl control)
        {
            return Resources.refresh;
        }

        public Bitmap GetGearsImage(IRibbonControl control)
        {
            return Resources.gears;
        }

        

        public Bitmap GetVisibilityImage(IRibbonControl control)
        {
            return Resources.lupa;
        }


        #endregion

        #region Asistentes

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
