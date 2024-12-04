using System.ComponentModel;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Tag_Finder
{
    public partial class frmtagfinder : Form
    {
        BackgroundWorker worker;
        bool running = false;

        struct rank_path
        {
            public int rank;
            public string path;
        }

        public frmtagfinder()
        {
            InitializeComponent();

            worker = new BackgroundWorker { };
            worker.DoWork += new DoWorkEventHandler(worker_CollectFiles);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_FileListComplete);
        }

        private void btnChooseRoot_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtCurrentPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void rtbResults_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.Arguments = e.LinkText;
            p.StartInfo.FileName = "explorer";
            p.Start();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (running) return;
            if (txtCurrentPath.Text == String.Empty) return;
            if (txtTags.Text == String.Empty) return;

            btnSearch.Enabled = false;
            btnChooseRoot.Enabled = false;

            rtbResults.Text = "Searching...\n\n";

            running = true;
            worker.RunWorkerAsync(argument: txtCurrentPath);
        }

        private void worker_FileListComplete(object? sender, RunWorkerCompletedEventArgs e)
        {
            // check error, check cancel, then use result
            if (e.Error != null)
            {
                rtbResults.AppendText("\n\nSearch Error!");

            }
            else
            {
                if (e.Result != null)
                {
                    List<string> files = (List<string>)e.Result;

                    List<rank_path> list = new List<rank_path>();

                    rank_path rp = new rank_path();

                    foreach (string file in files)
                    {
                        try
                        {
                            if (File.Exists(file))
                            {
                                string contents = File.ReadAllText(file);
                                contents = contents.Replace("#", "");
                                int count = search_engine(txtTags.Text, contents);
                                if (count > 0)
                                {
                                    var p = Path.GetFullPath(file);

                                    if (p != null)
                                    {
                                        var uri = new System.Uri(p);
                                        rp.path = uri.AbsoluteUri.Replace(".tags", "");
                                        rp.rank = count;
                                        list.Add(rp);
                                    }
                                }
                            }
                        }
                        catch
                        {

                        }
                    }

                    var ranked = list.OrderByDescending(x => x.rank).ToList();

                    foreach (rank_path rank in ranked)
                    {
                        rtbResults.AppendText(String.Format("{0} - {1}\n", rank.rank, rank.path));
                    }

                    rtbResults.AppendText("\n\nDone!");
                }
                else
                {
                    rtbResults.AppendText("\n\nInternal Error!");
                }
            }
            running = false;
            btnSearch.Enabled = true;
            btnChooseRoot.Enabled = true;
        }


        void worker_CollectFiles(object? sender, DoWorkEventArgs e)
        {
            List<string> f = new List<string>();

            try
            {
                var myFiles = new DirectoryInfo(txtCurrentPath.Text).EnumerateFiles("*.tags", SearchOption.AllDirectories);
                var myList = EnumerateFilesIgnoreErrors(myFiles).ToList();

                foreach (var file in myList)
                {
                    f.Add(file.ToString());
                }

                e.Result = f;
            }
            catch
            {
                e.Result = null;
            }
        }

        public static IEnumerable<FileInfo> EnumerateFilesIgnoreErrors(IEnumerable<FileInfo> files)
        {
            using (var e1 = files.GetEnumerator())
            {
                while (true)
                {
                    FileInfo? cur = null;

                    try
                    {
                        // MoveNext() can throw an Exception
                        if (!e1.MoveNext())
                            break;

                        cur = e1.Current;

                    }
                    catch { }

                    if (cur != null)
                    {
                        yield return cur;
                    }
                }
            }
        }



        private int search_engine(string tags, string text)
        {
            int count = search_engine_base(txtTags.Text, text);

            string replaced_spaces = txtTags.Text.Replace(" ", ",");
            if (replaced_spaces != txtTags.Text)
                count += search_engine_base(txtTags.Text.Replace(" ", ","), text);

            return count;
        }

        private int search_engine_base(string tags, string text)
        {
            if (tags == String.Empty) return 0;
            if (text == String.Empty) return 0;

            tags = tags.Replace("#", "");

            string[] fields = tags.Split(new[] { "\r\n", "\r", "\n", "," }, StringSplitOptions.RemoveEmptyEntries);

            string keywords = @"\b(";

            int x = 0;
            foreach (string field in fields)
            {
                if (x == 0)
                    keywords += field.Trim();
                else
                    keywords += "|" + field.Trim();
                x++;
            }

            keywords += @")\b";

            Match match = Regex.Match(text, keywords, RegexOptions.IgnoreCase);

            int count = 0;
            while (match.Success)
            {
                if (match.Value.Contains(" "))
                    count += match.Value.Count(x => x == ' ') * 10;
                else
                    count++;
                match = match.NextMatch();
            }

            return count;
        }
    }
}