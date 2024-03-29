﻿using System;
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

            ownerContactListView.MultiSelect = false;

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
            else
            {
                IterateSelectedItems();
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

            // this is how to select the first item
            //ownerContactListView.FocusedItem = ownerContactListView.Items[0];
            //ownerContactListView.Items[0].Selected = true;

            /*
             * This is a hard coded example to find an item and ensure it's visible
             */
            var item = ownerContactListView.FindItemWithText("Santé Gourmet");

            if (item != null)
            {
                var index = ownerContactListView.Items.IndexOf(item);
                ownerContactListView.Items[index].Selected = true;
                ownerContactListView.EnsureVisible(index);
            }

            CountLabel.Text = $@"Row count: {ownerContactListView.Items.Count}";
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

        private void ForumQuestionButton_Click(object sender, EventArgs e)
        {
            IterateSelectedItems();
        }

        private void IterateSelectedItems()
        {
            Console.WriteLine();
            Console.WriteLine(nameof(ForumQuestionButton_Click));

            var items = ownerContactListView.SelectedItems;
            if (items.Count > 0)
            {
                foreach (ListViewItem item in items)
                {
                    Console.WriteLine($@"{item.Text,-40}{item.SubItems[1].Text,-20}{item.SubItems[2].Text,-20}");
                }
            }

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            var companyName = "Just added";

            Contact contact = new Contact()
            {
                CompanyName = companyName,
                FirstName = "Karen",
                LastName = "Payne",
                PhoneNumber = "123-333-4444",
                CountryName = "USA"
            };

            ownerContactListView.Items.Add(
                new ListViewItem(contact.ItemArray)
                {
                    Tag = contact.CustomerIdentifier
                });

            CountLabel.Text = $@"Row count: {ownerContactListView.Items.Count}";

            var index = ownerContactListView.Items.IndexOf(
                ownerContactListView.FindItemWithText(companyName));

            ownerContactListView.Items[index].Selected = true;
            ownerContactListView.EnsureVisible(index);
            ActiveControl = ownerContactListView;
        }
    }
}
