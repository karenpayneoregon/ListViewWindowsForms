using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicListViewGroupsExample.LanguageExtensions;
using SqlServerOperations;
using SqlServerOperations.Classes;

namespace BasicListViewGroupsExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var dataOperations = new SqlInformation();
            var categories = dataOperations.Categories();

            var categoryIndex = 1;

            // ReSharper disable once TooWideLocalVariableScope
            var groupName = ""; 

            foreach (var category in categories)
            {
                var products = dataOperations.Products(category.CategoryId);

                /*
                 * Some category names have unwanted characters and/or whitespace, remove these chars.
                 */
                groupName = category.Name.Replace("/", "").Replace(" ", "");

                var currentGroup = new ListViewGroup(category.Name, HorizontalAlignment.Left)
                {
                    Header = category.Name,
                    Name = $"{groupName}Group{categoryIndex}"                    
                };

                categoryIndex += 1;

                ProductListView.Groups.Add(currentGroup);

                foreach (var product in products)
                {
                    var listViewProductItem = new ListViewItem(new[]
                    {
                        product.ProductName,
                        product.Supplier,
                        product.Phone,
                        product.UnitPrice.ToString(),
                        product.UnitsInStock.ToString()
                    }, -1)
                    {
                        Group = currentGroup,
                        /*
                         * Contains primary and foreign keys for current product
                         */
                        Tag = product.IdentifiersTag,
                        /*
                         * Required to change font and ForeColor below
                         */
                        UseItemStyleForSubItems = false
                    };


                    /*
                     * Alter user that the product is not available.
                     * Could have excluded the product, that would be dependent
                     * on business requirements. Also reorder information could
                     * be presented.
                     */
                    if (product.UnitsInStock == 0)
                    {
                        listViewProductItem.SubItems[4].ForeColor = Color.Red;

                        listViewProductItem.SubItems[4].Font = new Font(
                            listViewProductItem.SubItems[4].Font.FontFamily, 
                            listViewProductItem.SubItems[4].Font.Size, FontStyle.Bold);

                    }

                    ProductListView.Items.Add(listViewProductItem);
                }
            }

            ProductListView.FocusedItem = ProductListView.Items[0];
            ProductListView.Items[0].Selected = true;

            ActiveControl = ProductListView;

            ProductListView.ItemSelectionChanged += ProductListView_ItemSelectionChanged;
            ProductListView.ItemCheck += ProductListView_ItemCheck;

            GroupsComboBox.DataSource = ProductListView.Groups.Cast<ListViewGroup>().Select(lvg => lvg.Name).ToList();
        }


        /// <summary>
        /// Get information on the current selected product
        /// Note HoverSelection = true which causes the current item
        /// to change when hovering over a row in the ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var primaryKeys = ProductListView.Items[e.Index].ProductTag();

            ItemCheckedLabel.Text = e.NewValue == CheckState.Checked ? 
                $"Current checked: product: {primaryKeys.ProductId} category: {primaryKeys.CategoryId} " + 
                    $"supplier: {primaryKeys.SupplierId}" : 
                $"Current un-checked: product: {primaryKeys.ProductId} category: {primaryKeys.CategoryId} " + 
                    $"supplier: {primaryKeys.SupplierId}";
        }
        /// <summary>
        /// Shows how to get information for the current item on selection change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var primaryKeys = e.Item.ProductTag();
                SelectionChangedLabel.Text = $"product: {primaryKeys.ProductId} {ProductListView.Items[e.ItemIndex].Text}";
            }
        }
        /// <summary>
        /// If there are selected products grab information to process which
        /// includes all primary keys to process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedProductsButton_Click(object sender, EventArgs e)
        {
            var checkedItems = ProductListView.CheckedItems;

            if (checkedItems.Count > 0)
            {
                var sb = new StringBuilder();

                for (int index = 0; index < checkedItems.Count; index++)
                {
                    var keys = checkedItems[index].ProductTag();

                    sb.AppendLine(
                        $"{keys.CategoryId}," +
                        $"{checkedItems[index].Group.Header}," + 
                        $"{keys.ProductId}," + 
                        $"{checkedItems[index].Text}," + 
                        $"{keys.SupplierId}," + 
                        $"{checkedItems[index].SubItems[0].Text}");
                }

                /*
                 * Show selected products, in a real application this data
                 * would be sent to a method to process the products
                 */

                var f = new SelectedProductsForm(sb.ToString());

                try
                {
                    f.ShowDialog();
                }
                finally
                {
                    f.Dispose();
                }
            }
            else
            {
                MessageBox.Show("No product(s) selected");
            }
        }
        /// <summary>
        /// Toggle HoverSelection property between tracking current item with mouse over
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoverSelectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ProductListView.HoverSelection = HoverSelectionCheckBox.Checked;
        }
        /// <summary>
        /// Demonstration for iterating a single ListViewGroup by group name in ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetGroupProductsButton_Click(object sender, EventArgs e)
        {
            var specificGroup = ProductListView.Groups.Cast<ListViewGroup>()
                .FirstOrDefault(lvg => lvg.Name == GroupsComboBox.Text);

            for (int index = 0; index < specificGroup.Items.Count; index++)
            {
                var productTag = specificGroup.Items[index].ProductTag();               
                Console.WriteLine($"Id: {productTag.ProductId} Product: {specificGroup.Items[index].Text}");
            }
        }
        /// <summary>
        /// Example for iterating groups in the ListView to get information on products for
        /// all groups while the click event above iterates one group of products.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IterateListViewGroupsButton_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < ProductListView.Groups.Count; index++)
            {
                Console.WriteLine(ProductListView.Groups[index].Header);
                Console.WriteLine();
                Console.WriteLine("Product id  Supplier id");
                for (int itemsIndex = 0; itemsIndex < ProductListView.Groups[index].Items.Count; itemsIndex++)
                {
                    var keys = ProductListView.Groups[index].Items[itemsIndex].ProductTag();
                    Console.WriteLine($"{keys.ProductId, 5} {keys.SupplierId,12}");
                }

                Console.WriteLine();
            }
        }
    }
}
