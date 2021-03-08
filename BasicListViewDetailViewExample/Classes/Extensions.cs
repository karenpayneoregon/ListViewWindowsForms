using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SqlServerOperations.Classes;

namespace BasicListViewDetailViewExample.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Provides the ability to remove selected rows in detail view.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static List<ListViewItem> SelectedRows(this ListView.ListViewItemCollection sender)
        {
            return sender.Cast<ListViewItem>()
                .Where(listViewItem => listViewItem.Selected)
                .Select(listViewItem => listViewItem)
                .ToList();
        }

        public static int RowIndex(this ListView sender)
        {
            var ssssssssssss = sender.SelectedIndices.Count;
            if (ssssssssssss == 0)
            {
                return -1;
            }
            else
            {
                return sender.Items.IndexOf(sender.SelectedItems[0]);
            }
            
            //return sender.SelectedItems.Count > 0 ? sender.Items.IndexOf(sender.SelectedItems[0]) : -1;
        }

        public static Contact Contact(this ListView sender)
        {
            int index = sender.RowIndex();
            //if (index == -1)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}
            
            return (Contact)sender.Items[index].Tag;
        }
        
    }
}
