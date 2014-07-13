using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using CheckBox = System.Windows.Forms.CheckBox;

namespace TextCleaner.GUI
{
    public partial class Clean : Form
    {
        private readonly Microsoft.Office.Interop.Word.Application app = Globals.ThisAddIn.Application;

        public Clean() { InitializeComponent(); }
        private void btnAll_Click(object sender, EventArgs e)
        {
            var s = (GroupBox)((Button)sender).Parent;
            foreach (CheckBox c in s.Controls.OfType<CheckBox>())
                c.Checked = true;
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            var s = (GroupBox)((Button)sender).Parent;
            foreach (CheckBox c in s.Controls.OfType<CheckBox>())
                c.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e) { this.Close(); }
        private void btnRun_Click(object sender, EventArgs e)
        {
            int maximum = 10;
            foreach (Control cnt in this.Controls)
            {
                cnt.Enabled = false;
                if (cnt is GroupBox)
                    maximum += cnt.Controls.Cast<Control>().Count(c => c is CheckBox && ((CheckBox) c).Checked);
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
            var t = DateTime.Now;
            var bw = sender as BackgroundWorker;
            if (chkSpaces.Checked)         searchReplace(" {2;}",             " ",       false, false, bw, "Spaces"                );
            if (chkSpaceDashSpace.Checked) searchReplace(" [-–—]{1} ",        " – ",     false, false, bw, "Space-Dash-Space"      );
            if (chkPercent.Checked)        searchReplace("%",                 " %",      false, false, bw, "Percent"               );
            if (chkNumber.Checked)         searchReplace("№",                 "№ ",      false, false, bw, "№"                     );
            if (chkTab.Checked)            searchReplace("^t",                "",        false, false, bw, "Tabulation"            );
            if (chkLineBreak.Checked)      searchReplace("^l",                "",        false, false, bw, "Line Break"            );
            if (chkSpaceDots.Checked)      searchReplace("([  ])([.,;:])",    @"\2",     false, false, bw, "Space-dots"            );
            if (chkCRLFSpace.Checked)      searchReplace(" ^p",               "^p",      false, false, bw, "Space-CRLF",      false);
            if (chkSpaceCRLF.Checked)      searchReplace("^p ",               "^p",      false, false, bw, "CRLF-Space",      false);
            if (chkPageBreak.Checked)      searchReplace("^m",                "^p",      false, false, bw, "Page Break",      false); // Check
            if (chkYo.Checked)             searchReplace("ё",                 "е",       false, false, bw, "ё -> е",          false);
            if (chkSpaces.Checked)         searchReplace(" {2;}",             " ",       false, false, bw, "Spaces, again"         );
            if (chkNBSP.Checked)           searchReplace(" {2;}",             " ",       false, false, bw, "Double NBSP"           ); // This is NBPS
            if (chkNBSP.Checked)           searchReplace(" ^s",               "^s",      false, true,  bw, "Space-NBSP",      false);
            if (chkNBSP.Checked)           searchReplace("^s ",               "^s",      false, true,  bw, "Space-NBSP",      false);
            if (chkDigitDashDigit.Checked) searchReplace("([0-9])-([0-9])",   @"\1–\2",  false, false, bw, "Digit-Dash-Digit"      );
            if (chkYearAndCity.Checked)    searchReplace("([0-9]{2;}) г.",    @"\1 г.",  false, false, bw, "Year"                  ); // This is NBPS
            if (chkYearAndCity.Checked)    searchReplace(" г. ([!0-9])",      @" г. \1", false, false, bw, "City"                  ); // This is NBPS
            if (chkPreposition.Checked)    searchReplace(" ([а-яА-Я]{1;3}) ", @" \1 ",   false, false, bw, "Preposition"           ); // This is NBPS
            if (chkSpaces.Checked)         searchReplace(" {2;}",             " ",       false, false, bw, "Spaces, a little more" );
            if (chkItalicDigits.Checked)   setFormat("[0-9]",             bw, "Italic digits"  );
            if (chkItalicBrackets.Checked) setFormat(@"[\(\[\{\}\]\)<>]", bw, "Italic brackets");
            if (chkBlack.Checked)
            {
                bw.ReportProgress(0, "Set black color");
                app.Selection.WholeStory();
                app.Selection.Font.ColorIndex = WdColorIndex.wdBlack;
                foreach (Footnote f in Globals.ThisAddIn.Application.Selection.Footnotes)
                {
                    f.Range.Select();
                    Globals.ThisAddIn.Application.Selection.Font.ColorIndex = WdColorIndex.wdBlack;
                }
            }
            if (chkTracking.Checked)
            {
                bw.ReportProgress(0, "Remove tracking/kerning");
                app.Selection.WholeStory();
                app.Selection.Font.Scaling = 100;
                app.Selection.Font.Spacing = 0;
                foreach (Footnote f in Globals.ThisAddIn.Application.Selection.Footnotes)
                {
                    f.Range.Select();
                    Globals.ThisAddIn.Application.Selection.Font.Scaling = 100;
                    Globals.ThisAddIn.Application.Selection.Font.Spacing = 0;
                }
            }
            if (chkHyphen.Checked)
            {
                bw.ReportProgress(0, "Turn off hyphenation");
                app.Selection.WholeStory();
                app.Selection.ParagraphFormat.Hyphenation = 0;
            }
            if (chkEquationsReset.Checked)
            {
                bw.ReportProgress(0, "Resetting inline shapes");
                var shapes = app.ActiveDocument.InlineShapes;
                if (shapes != null && shapes.Count > 0)
                {
                    foreach (object o in shapes)
                    {
                        if (!(o is InlineShape)) continue;
                        var eq = o as InlineShape;
                        eq.LockAspectRatio = MsoTriState.msoFalse;
                        eq.ScaleWidth = 100.0f;
                        eq.ScaleHeight = 100.0f;
                    }
                }
            }
            if (chkHyperlinks.Checked)
            {
                bw.ReportProgress(0, "Removing hyperlinks");
                var links = new List<Hyperlink>(); // Temporary collection is a hack for unexpected behavior of Hyperlinks enumerator
                foreach (Hyperlink l in app.ActiveDocument.Hyperlinks)
                {
                    links.Add(l);
                }
                foreach (var link in links) 
                {
                    link.Delete();
                }
            }

            bw.ReportProgress(0, "Idle");
            var sp = DateTime.Now - t;
            Invoke((Action)(()=>
            {
                label1.Text = sp.Duration().TotalMilliseconds + " ms.";
                btnClose.Focus();
            }));
        }
        private void searchReplace(
            string search, string replace, bool matchCase, bool repeated, 
            BackgroundWorker bw, string message, bool wildcards = true, bool format = false
        )
        {
            bw.ReportProgress(0, message);
            Object FindText           = search;
            Object MatchCase          = matchCase;
            Object MatchWholeWord     = false;
            Object MatchWildcards     = wildcards;
            Object MatchSoundsLike    = false;
            Object MatchAllWordForms  = false;
            Object Forward            = false;
            Object Wrap               = WdFindWrap.wdFindContinue;
            Object Format             = format;
            Object ReplaceWith        = replace;
            Object Replace            = WdReplace.wdReplaceAll;

            var ranges = new List<Find>();
            ranges.Add(app.ActiveDocument.Range().Find);
            foreach (Footnote footnote in app.ActiveDocument.Footnotes)
            {
                ranges.Add(footnote.Range.Find);
            }

            foreach (var findObject in ranges)
            {
                bool loop = true;
                while (loop)
                {
                    findObject.ClearFormatting();
                    findObject.Replacement.ClearFormatting();
                    loop = findObject.Execute(
                        ref FindText, ref MatchCase, ref MatchWholeWord, ref MatchWildcards, ref MatchSoundsLike,
                        ref MatchAllWordForms, ref Forward, ref Wrap, ref Format, ref ReplaceWith, ref Replace
                    );
                    if (!repeated) loop = false;
                }   
            }
        }
        private static void setFormat(string search, BackgroundWorker bw, string message, bool wildcards = true)
        {
            bw.ReportProgress(0, message);
            Object FindText          = search;
            Object MatchCase         = false;
            Object MatchWholeWord    = false;
            Object MatchWildcards    = wildcards;
            Object MatchSoundsLike   = false;
            Object MatchAllWordForms = false;
            Object Forward           = true;
            Object Wrap              = WdFindWrap.wdFindStop;
            Object Format            = false;
            Object ReplaceWith       = null;
            Object Replace           = WdReplace.wdReplaceNone;

            Globals.ThisAddIn.Application.Selection.HomeKey(WdUnits.wdStory);
            bool loop = true;
            while (loop)
            {
                Find findObject = Globals.ThisAddIn.Application.Selection.Find;
                findObject.ClearFormatting();
                findObject.Replacement.ClearFormatting();
                findObject.Font.Italic = 1;
                loop = findObject.Execute(
                    ref FindText, ref MatchCase, ref MatchWholeWord, ref MatchWildcards, ref MatchSoundsLike,
                    ref MatchAllWordForms, ref Forward, ref Wrap, ref Format, ref ReplaceWith, ref Replace
                );
                Globals.ThisAddIn.Application.Selection.Font.Italic = 0;
            }
        }
    }
}
