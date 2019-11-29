using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
    }
}
