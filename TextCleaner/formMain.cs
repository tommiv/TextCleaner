using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace TextCleaner
{
    public partial class formMain : Form
    {
        public formMain() { InitializeComponent(); }
        private void btnAll_Click(object sender, EventArgs e)
        {
            var s = (GroupBox)((Button)sender).Parent;
            foreach (Control c in s.Controls) if (c is CheckBox) ((CheckBox)c).Checked = true;
        }
        private void btnNone_Click(object sender, EventArgs e)
        {
            var s = (GroupBox)((Button)sender).Parent;
            foreach (Control c in s.Controls) if (c is CheckBox) ((CheckBox)c).Checked = false;
        }
        private void btnClose_Click(object sender, EventArgs e) { this.Close(); }
        private void btnRun_Click(object sender, EventArgs e)
        {
            int maximum = 0;
            foreach (Control cnt in this.Controls)
            {
                cnt.Enabled = false;
                if (cnt is GroupBox)
                    foreach (Control c in cnt.Controls) if (c is CheckBox && ((CheckBox) c).Checked) maximum++;
            }
            prgrsMain.Maximum = maximum;
            prgrsMain.Value   = 0;
            var bw = new BackgroundWorker { WorkerReportsProgress = true };
            bw.DoWork += run;
            bw.ProgressChanged += plus;
            bw.RunWorkerCompleted += done;
            bw.RunWorkerAsync();
        }
        private void done(object sender, RunWorkerCompletedEventArgs e) { foreach (Control c in this.Controls) c.Enabled = true; }

        private void plus(object sender, ProgressChangedEventArgs e)
        {
            if (prgrsMain.Maximum <= prgrsMain.Value + 1)
                if (prgrsMain.InvokeRequired) Invoke((Action)(() => prgrsMain.Maximum += 1));
                else prgrsMain.Maximum += 1;
            if (prgrsMain.InvokeRequired) Invoke((Action) (() => prgrsMain.Value += 1));
            else prgrsMain.Value += 1;
            if (lblProgress.InvokeRequired) Invoke((Action)(() => lblProgress.Text = e.UserState.ToString()));
            else lblProgress.Text = e.UserState.ToString();
            if (e.UserState.ToString() == "Idle")
                if (prgrsMain.InvokeRequired) Invoke((Action)(() => prgrsMain.Value = prgrsMain.Maximum));
                else prgrsMain.Value = prgrsMain.Maximum;
        }
        private void run(object sender, DoWorkEventArgs e)
        {
            var bw = sender as BackgroundWorker;
            if (chkSpaces.Checked)         SearchReplace(" {2;}",          " ",   false, false, bw, "Spaces"                );
            if (chkSpaceDashSpace.Checked) SearchReplace(" [-–—]{1} ",     " – ", false, false, bw, "Space-Dash-Space"      );
            if (chkPercent.Checked)        SearchReplace("%",              " %",  false, false, bw, "Percent"               );         
            if (chkTab.Checked)            SearchReplace("^t",             "",    false, false, bw, "Tabulation"            );
            if (chkLineBreak.Checked)      SearchReplace("^l",             "",    false, false, bw, "Line Break"            );
            if (chkSpaceDots.Checked)      SearchReplace("([  ])([.,;:])", @"\2", false, false, bw, "Space-dots"            );
            if (chkCRLFSpace.Checked)      SearchReplace(" ^p",            "^p",  false, false, bw, "Space-CRLF",      false);
            if (chkSpaceCRLF.Checked)      SearchReplace("^p ",            "^p",  false, false, bw, "CRLF-Space",      false);
            if (chkPageBreak.Checked)      SearchReplace("^m",             "^p",  false, false, bw, "Page Break",      false); // Check
            if (chkYo.Checked)             SearchReplace("ё",              "е",   false, false, bw, "ё -> е",          false);
            if (chkSpaces.Checked)         SearchReplace(" {2;}",          " ",   false, false, bw, "Spaces, again"         );
            if (chkNBSP.Checked)           SearchReplace(" {2;}",          " ",   false, false, bw, "Double NBSP"           ); // This is NBPS
            if (chkNBSP.Checked)           SearchReplace(" ^s",            "^s",  false, true,  bw, "Space-NBSP",      false);
            if (chkNBSP.Checked)           SearchReplace("^s ",            "^s",  false, true,  bw, "Space-NBSP",      false);
            bw.ReportProgress(0, "Idle");
        }
        private static void SearchReplace(
            string search, string replace, bool matchCase, bool repeated, 
            BackgroundWorker bw, string message, bool wildcards = true, bool format = false
        )
        {
            Object FindText           = search;
            Object MatchCase          = matchCase;
            Object MatchWholeWord     = false;
            Object MatchWildcards     = wildcards;
            Object MatchSoundsLike    = false;
            Object MatchAllWordForms  = false;
            Object Forward            = false;
            Object Wrap               = Word.WdFindWrap.wdFindContinue;
            Object Format             = format;
            Object ReplaceWith        = replace;
            Object Replace            = Word.WdReplace.wdReplaceAll;

            bool loop = true;
            int i = 0;
            while (loop)
            {
                bw.ReportProgress(0, message + (repeated? ", #" + i : ""));
                Word.Find findObject = Globals.ThisAddIn.Application.Selection.Find;
                findObject.ClearFormatting();
                findObject.Replacement.ClearFormatting();
                loop = findObject.Execute(
                    ref FindText, ref MatchCase, ref MatchWholeWord, ref MatchWildcards, ref MatchSoundsLike,
                    ref MatchAllWordForms, ref Forward, ref Wrap, ref Format, ref ReplaceWith, ref Replace
                );
                if (!repeated) loop = false;
                i++;
            }
        }
    }
}
