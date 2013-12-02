using Microsoft.Office.Tools.Ribbon;

namespace TextCleaner
{
    public partial class RibbonMain
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e) { }
        private void btnLaunch_Click(object sender, RibbonControlEventArgs e) { new formMain().ShowDialog(); }
        private void btnMerge_Click(object sender, RibbonControlEventArgs e)  { new formMerge().ShowDialog(); }
    }
}
