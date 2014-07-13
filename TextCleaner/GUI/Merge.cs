using System;
using System.IO;
using System.Windows.Forms;

namespace TextCleaner.GUI
{
    public partial class Merge : Form
    {
        public Merge()
        {
            InitializeComponent();
        }

        private string path;
        private static object m = System.Reflection.Missing.Value;
        private readonly Microsoft.Office.Interop.Word.Application app = Globals.ThisAddIn.Application;
        private static readonly object eof = "\\endofdoc";

        private void btnRun_Click(object sender, EventArgs e)
        {
            string separator = TxtAbstractAnchor.Text;

            var destination = app.Documents.Add(ref m, ref m, ref m, ref m);
            var ann_ru = app.Documents.Add(ref m, ref m, ref m, ref m);
            var ann_en = app.Documents.Add(ref m, ref m, ref m, ref m);

            foreach (string subdir in Directory.GetDirectories(path))
            {
                // get data
                string article = string.Empty;
                string annotation = string.Empty;

                foreach (string f in Directory.GetFiles(subdir))
                {
                    if (Path.GetFileName(f).ToLowerInvariant().StartsWith("article"))
                    {
                        article = f;
                    }
                    else if (Path.GetFileName(f).ToLowerInvariant().StartsWith("abstract"))
                    {
                        annotation = f;
                    }

                    if (!string.IsNullOrEmpty(article) && !string.IsNullOrEmpty(annotation))
                    {
                        break;
                    }
                }
                if (article == string.Empty && annotation == string.Empty)
                {
                    continue;
                }

                // copy article
                var art = app.Documents.Open(article, ReadOnly: true, Visible: false);
                try
                {
                    art.Content.Copy();
                    destination.Bookmarks.get_Item(eof).Range.Paste();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error in file: {0}\n{1}", article, ex.Message));
                }
                art.Close();
                // copy annotation
                var ann = app.Documents.Open(annotation, ReadOnly: true, Visible: false);
                try
                {
                    var fnd = ann.Content.Find;
                    fnd.Execute(separator);
                    ann.Range(0, fnd.Parent.End - separator.Length).Copy();
                    ann_ru.Bookmarks.get_Item(eof).Range.Paste();
                    ann.Range(fnd.Parent.End, ann.Content.End).Copy();
                    ann_en.Bookmarks.get_Item(eof).Range.Paste();
                    ann.Close();
                }
                catch(Exception ex)
                {
                    if (MessageBox.Show("Missed abstract in [" + subdir + "]. Cancel?", "Missed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        return;
                    }
                }
            }
            // Merge all
            destination.Content.Select();
            destination.Content.InsertAfter("ABSTRACT");
            ann_ru.Content.Copy();
            destination.Bookmarks.get_Item(eof).Range.Paste();
            ann_ru.Close(SaveChanges: ref m);
            ann_en.Content.Copy();
            destination.Bookmarks.get_Item(eof).Range.Paste();
            ann_en.Close(SaveChanges: ref m);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            BrowsePath.ShowDialog();
            path = BrowsePath.SelectedPath;
            TxtPath.Text = path ?? String.Empty;
            btnRun.Enabled = Directory.Exists(path);
        }
    }
}
