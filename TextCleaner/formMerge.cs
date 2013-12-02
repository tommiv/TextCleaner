using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace TextCleaner
{
    public partial class formMerge : Form
    {
        public formMerge()
        {
            InitializeComponent();
        }

        private const string path = @"f:\Docs\Работа\СКНЦ\НМК - 2013-02\source";
        private static object m = System.Reflection.Missing.Value;
        private readonly Word.Application app = Globals.ThisAddIn.Application;
        private static readonly object eof = "\\endofdoc";
        private const string separator = "###";

        private void btnRun_Click(object sender, EventArgs e)
        {
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
                var fnd = ann.Content.Find;
                fnd.Execute(separator);
                try
                {
                    ann.Range(0, fnd.Parent.End - separator.Length).Copy();
                    ann_ru.Bookmarks.get_Item(eof).Range.Paste();
                    ann.Range(fnd.Parent.End, ann.Content.End).Copy();
                    ann_en.Bookmarks.get_Item(eof).Range.Paste();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Error in file: {0}\n{1}", article, ex.Message));
                }
                ann.Close();
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
    }
}
