using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicListViewDetailViewExample.Classes
{
    public static class Extensions
    {
        public static List<ListViewItem> SelectedRows(this ListView.ListViewItemCollection sender)
        {
            return sender.Cast<ListViewItem>()
                .Where(listViewItem => listViewItem.Selected)
                .Select(listViewItem => listViewItem)
                .ToList();
        }
    }
}
