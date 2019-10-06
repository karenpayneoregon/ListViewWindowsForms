using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerOperations;
using SqlServerOperations.Classes;

namespace BasicListViewDetailViewExample
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            Shown += Form1_Shown;

            ownerContactListView.MouseDoubleClick += ListView1_MouseDoubleClick;

        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(
                $"Call {ownerContactListView.SelectedItems[0].Text} at " + 
                $"{ownerContactListView.SelectedItems[0].SubItems[3].Text}");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var dataOperations = new SqlInformation();
            var contacts = dataOperations.GetOwnerContacts();

            ownerContactListView.BeginUpdate();
            foreach (var contact in contacts)
            {

                ownerContactListView.Items.Add(
                    new ListViewItem(contact.ItemArray)
                    {
                        Tag = contact.CustomerIdentifier
                    });

            }

            ownerContactListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            ownerContactListView.EndUpdate();

            ownerContactListView.FocusedItem = ownerContactListView.Items[0];
            ownerContactListView.Items[0].Selected = true;
            ActiveControl = ownerContactListView;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
