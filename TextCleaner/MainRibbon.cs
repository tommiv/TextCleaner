using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace TextCleaner
{
    public partial class MainRibbon
    {
        private void MainRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void BtnClean_Click(object sender, RibbonControlEventArgs e)
        {
            new GUI.Clean().ShowDialog();
        }

        private void BtnMerge_Click(object sender, RibbonControlEventArgs e)
        {
            new GUI.Merge().ShowDialog();
        }
    }
}
