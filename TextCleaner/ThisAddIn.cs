using System;

namespace TextCleaner
{
    public partial class ThisAddIn
    {   
        private void ThisAddIn_Startup(object sender, EventArgs e) { }
        private void ThisAddIn_Shutdown(object sender, EventArgs e) { }

        #region VSTO generated code

        private void InternalStartup()
        {
            this.Startup += ThisAddIn_Startup;
            this.Shutdown += ThisAddIn_Shutdown;
        }
        
        #endregion
    }
}
