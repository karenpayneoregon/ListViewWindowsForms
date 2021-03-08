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
        /// <summary>
        /// Get current row index
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>Current row index value or -1 if no current row</returns>
        public static int RowIndex(this ListView sender)
        {
            var count = sender.SelectedIndices.Count;
            if (count == 0)
            {
                return -1;
            }
            else
            {
                return sender.Items.IndexOf(sender.SelectedItems[0]);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Contact ContactByRowIndex(this ListView sender, int index)
        {
            return (Contact)sender.Items[index].Tag;
        }

        
    }
}
