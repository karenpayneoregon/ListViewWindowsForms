using System;
using System.Linq;
using System.Windows.Forms;
using NorthWindContactsCodeFirst.Contexts;

namespace NorthWindContactsCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.GridLines = true;
            listView1.OwnerDraw = false;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("NameColumn", 150);
            listView1.Columns.Add("VersionColumn", 130);


            listView1.Columns[0].Text = "First name";
            listView1.Columns[1].Text = "Last name";


            using (NorthContext context = new NorthContext())
            {

                var contacts = context.Contacts.ToList();
                foreach (var contact in contacts)
                {
                    var item = new ListViewItem(new []
                    {
                        contact.FirstName,
                        contact.LastName,
                        contact.ContactId.ToString()
                    });
                    listView1.Items.Add(item);
                }
            }

            listView1.Items[0].Selected = true;
            listView1.Select();
            CurrentButton.Enabled = true;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            var selected = listView1.Items.Cast<ListViewItem>()
                .Where(listViewItem => listViewItem.Selected)
                .Select(listViewItem => listViewItem)
                .FirstOrDefault();

            if (selected != null)
            {
                MessageBox.Show($"{selected.SubItems[0].Text}, {selected.SubItems[1].Text}, {selected.SubItems[2].Text}");
            }
            
        }
    }
}
