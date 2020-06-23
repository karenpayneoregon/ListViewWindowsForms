using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicListViewDetailViewExample.Classes;
using SqlServerOperations;
using SqlServerOperations.Classes;
using static BasicListViewDetailViewExample.Classes.Dialogs;

namespace BasicListViewDetailViewExample
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            Shown += Form1_Shown;

            ownerContactListView.MouseDoubleClick += ListView1_MouseDoubleClick;
            ownerContactListView.SelectedIndexChanged += OwnerContactListView_SelectedIndexChanged;

        }

        private void OwnerContactListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ownerContactListView.SelectedItems.Count == 1)
            {
                Console.WriteLine(ownerContactListView.SelectedItems[0].Text);
            }
            
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Call {ownerContactListView.SelectedItems[0].Text} at " + 
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
        /// <summary>
        /// Shows how to remove selected rows with a prompt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedListViewRows();
        }
        /// <summary>
        /// Used to prompt for deleting rows from button click or pressing
        /// the DEL key.
        /// </summary>
        private void DeleteSelectedListViewRows()
        {
            var selectedRows = ownerContactListView.Items.SelectedRows();

            if (Question($"Remove {selectedRows.Count} rows?"))
            {
                selectedRows.ForEach(listViewItem => 
                    ownerContactListView.Items.Remove(listViewItem));
            }
        }
        /// <summary>
        /// Shows how to remove selected rows with a prompt when pressing
        /// the DEL key.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != (Keys.Delete)) return base.ProcessCmdKey(ref msg, keyData);
            DeleteSelectedListViewRows();
            return true;
        }
        /// <summary>
        /// Demo changing a item value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MockedEditButton_Click(object sender, EventArgs e)
        {
            ownerContactListView.SelectedItems[0].SubItems[3].Text =
                ownerContactListView.SelectedItems[0].SubItems[3].Text.Replace("-", "");
        }
    }
}
