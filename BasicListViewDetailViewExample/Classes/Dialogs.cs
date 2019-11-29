﻿using System.Diagnostics;
using System.Windows.Forms;

namespace BasicListViewDetailViewExample.Classes
{
    public static class Dialogs
    {
        [DebuggerStepThrough]
        public static bool Question(string text)
        {
            return (MessageBox.Show(
                        text,
                        Application.ProductName,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}
