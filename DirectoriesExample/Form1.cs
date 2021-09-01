using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectoriesExample.Classes;

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
}
