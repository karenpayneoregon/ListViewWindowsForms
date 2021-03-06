﻿# ListView Extension method for moving rows up/down

Used in the following [code sample](https://github.com/karenpayneoregon/ListViewWindowsForms/tree/master/JsonExample).

```csharp
using System.Windows.Forms;

namespace LanguageExtensions
{
    public enum MoveDirection { Up = -1, Down = 1 };
    public static class ListViewExtensions
    {
        /// <summary>
        /// Move row up or down dependent on direction parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="moveDirection">Up or Down</param>
        public static void MoveListViewItems(this ListView sender, MoveDirection moveDirection)
        {
            int direction = (int)moveDirection;

            bool valid = sender.SelectedItems.Count > 0 &&
                         ((moveDirection == MoveDirection.Down &&
                           (sender.SelectedItems[sender.SelectedItems.Count - 1]
                                .Index < sender.Items.Count - 1)) || 
                          (moveDirection == MoveDirection.Up && (sender.SelectedItems[0] .Index > 0)));

            if (valid)
            {
                sender.SuspendLayout();

                try
                {
                    foreach (ListViewItem item in sender.SelectedItems)
                    {
                        var index = item.Index + direction;
                        sender.Items.RemoveAt(item.Index);
                        sender.Items.Insert(index, item);
                        sender.Items[index].Selected = true;
                        sender.Focus();
                    }
                }
                finally
                {
                    sender.ResumeLayout();
                }
            }
        }
    }
}
```
