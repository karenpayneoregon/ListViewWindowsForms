using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoriesExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            var path = "C:\\OED\\Documents";
            if (!Directory.Exists(path))
            {
                return;
            }
            
            var items = Operations.GetFiles(path,".docx",".chm");

            DirectoryListView.BeginUpdate();

            try
            {
                
                foreach (var itemDetail in items)
                {
                    DirectoryListView.Items.Add(new ListViewItem(itemDetail.ItemArray) {Tag = itemDetail});
                }
                
                DirectoryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                DirectoryListView.FocusedItem = DirectoryListView.Items[0];
                DirectoryListView.Items[0].Selected = true;
                
                ActiveControl = DirectoryListView;
            }
            finally
            {
                DirectoryListView.EndUpdate();
            }
            
            DirectoryListView.MouseDoubleClick += ListView1OnMouseDoubleClick;

        }

        private void ListView1OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
            var current = (ItemDetails) DirectoryListView.SelectedItems[0].Tag;
            MessageBox.Show($"{current.FullName}\n{current.Directory}");
        }
    }

    public static class Extensions
    {
        public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions) 
            => dir.EnumerateFiles().Where((f) => extensions.Contains(f.Extension));

    }

    public class ItemDetails
    {
        public string Directory { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public DateTime LastWriteTime { get; set; }
        public string[] ItemArray => new[] {Name, LastWriteTime.ToString("MM/dd/yyyy")};
    }

    public class Operations
    {
        public static List<ItemDetails> GetFiles(string path, params string[] extensions)
        {
            
            return new DirectoryInfo(path).GetFilesByExtensions(extensions).
                OrderBy(x => x.Name).
                Select(info => new ItemDetails()
                {
                    Name = info.Name,
                    Directory = info.DirectoryName, 
                    FullName = info.FullName, 
                    LastWriteTime = info.LastWriteTime
                }).
                ToList();
        }
    }
}
