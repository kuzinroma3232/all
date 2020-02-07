using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FastTreeNS;
using System.Diagnostics;

namespace Search_RT
{
    public partial class Form1 : Form
    {
        private int found;
        private string currFileName;
        Stopwatch st = new Stopwatch();
        string dir;
        string fileMask;
        Node root;
        Thread thread;


        public Form1()
        {
            InitializeComponent();
            lb_mask.Text = "маска файла: \n*txt -по формату \nполное_имя* - по имени, \n*.* -все файлы";
            tb_directory.Text = Properties.Settings.Default.Dir;
            tb_Mask.Text = Properties.Settings.Default.Mask;

        }

        private void StartSearch()
        {

            found = 0;
            st.Reset();
            dir = tb_directory.Text;
            if (System.IO.Directory.Exists(dir))
            {
                fileMask = tb_Mask.Text;
                root = new Node { FullPath = dir };

                thread = new Thread(() => Build(root, fileMask)) { IsBackground = true };
                Thread.Sleep(3000);
                thread.Start();
                st.Start();
                //обновление дерева
                UpdateTree();
            }
            else
            {
                MessageBox.Show("Неправильный путь");
            }

        }
        private void StopSearch()
        {
            if ( thread != null)
            {
                thread.Abort();
                thread.Join();
                st.Stop();
            }
        }
        private void UpdateTree()
        {
            Application.Idle += delegate
            {
                if (thread.IsAlive)
                {
                    fastTree1.Build(root);
                }
            };
        }


        private void UpdateInfo(int foundFiles, double totalSec,string currFileName)
        {       
            this.Invoke((Action)delegate ()
            {

                lb_info.Text = "Обработано файлов: " + foundFiles + "\nТекущий файл: " + currFileName + "\nВремя выполнения: " + totalSec;
            });
        }


        private void Build(Node root, string fileMask)
        {
            var toProcess = new Stack<Node>();
            toProcess.Push(root);

            while (toProcess.Count > 0)
            {
                var node = toProcess.Pop();
                try
                {
                    foreach (var dir in Directory.GetDirectories(node.FullPath))
                    {
                        var n = new Node { FullPath = dir };
                        node.Add(n);
                        toProcess.Push(n);
                    }

                    foreach (var file in Directory.GetFiles(node.FullPath, fileMask))
                    {
                        var n = new Node { FullPath = file, IsFile = true };
                        node.Add(n);
                        found++;
                        currFileName = node.Name;
                        UpdateInfo(found, st.Elapsed.TotalSeconds, currFileName);

                    }
                }
                catch (UnauthorizedAccessException)
                {
                }
            }
        }
        public class Node : IEnumerable<Node>
        {
            private List<Node> nodes;
            //Файл?
            public bool IsFile { get; set; }
            //Полный путь
            public string FullPath { get; set; }
            //Имя
            public string Name { get { return Path.GetFileName(FullPath); } }

            // Имеет хоть один файл у себя или у потомков ?
            public bool HasFile
            {
                get
                {
                    return IsFile || Nodes.Any(n => n.HasFile);
                }
            }

            public Node()
            {
                nodes = new List<Node>();
            }

            public override string ToString()
            {
                return string.IsNullOrEmpty(Name) ? FullPath : Name;
            }

            //добавление нода
            public void Add(Node node)
            {
                nodes.Add(node);
            }

            IEnumerable<Node> Nodes
            {
                get
                {
                    for (int i = 0; i < nodes.Count; i++)
                        yield return nodes[i];
                }
            }

            public IEnumerator<Node> GetEnumerator()
            {
                return Nodes.Where(n => n.HasFile).GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopSearch();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSearch();
            Properties.Settings.Default.Dir = tb_directory.Text;
            Properties.Settings.Default.Mask = tb_Mask.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartSearch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
