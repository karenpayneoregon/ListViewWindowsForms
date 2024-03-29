using System.Diagnostics;
using BasicListViewGroupsExampleCore.Classes;
using BasicListViewGroupsExampleCore.LanguageExtensions;
using System.Text;

namespace BasicListViewGroupsExampleCore;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        Shown += MainForm_Shown;
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
        Operations dataOperations = new Operations();
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

        ProductListView.BeginUpdate();
        ProductListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        ProductListView.EndUpdate();
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
            SelectionChangedLabel.Text =
                $"product: {primaryKeys.ProductId} " +
                $"{ProductListView.Items[e.ItemIndex].Text}";
        }
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

    private void SelectedProductsButton_Click(object sender, EventArgs e)
    {
        ListView.CheckedListViewItemCollection checkedItems = ProductListView.CheckedItems;
        if (checkedItems.Count <= 0)
        {
            MessageBox.Show("No product(s) selected");
        }
        else
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
    }

    private void GetGroupProductsButton_Click(object sender, EventArgs e)
    {
        ListViewGroup specificGroup = ProductListView.Groups.Cast<ListViewGroup>()
            .FirstOrDefault(lvg => lvg.Name == GroupsComboBox.Text);

        Debug.WriteLine(new string('-', 50));
        for (int index = 0; index < specificGroup.Items.Count; index++)
        {
            var productTag = specificGroup.Items[index].ProductTag();
            Debug.WriteLine($"Id: {productTag.ProductId,-5} Product: {specificGroup.Items[index].Text}");
        }
        Debug.WriteLine(new string('-', 50));
    }

    private void IterateListViewGroupsButton_Click(object sender, EventArgs e)
    {
        Operations dataOperations = new Operations();
        var list = dataOperations.Suppliers();
        Debug.WriteLine(new string('-', 50));
        for (int index = 0; index < ProductListView.Groups.Count; index++)
        {
            Debug.WriteLine(ProductListView.Groups[index].Header);
            Debug.WriteLine("Product id  Supplier");
            for (int itemsIndex = 0; itemsIndex < ProductListView.Groups[index].Items.Count; itemsIndex++)
            {
                var keys = ProductListView.Groups[index].Items[itemsIndex].ProductTag();
                Debug.WriteLine($"{keys.ProductId,-12}{list.FirstOrDefault(x => x.SupplierId == keys.SupplierId).CompanyName}");
            }

            Debug.WriteLine(new string('-',50));
        }
    }
}
