using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerOperations;
using SqlServerOperations.Classes;

namespace BasicListViewGroupsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var ops = new SqlInformation();
            var categories = ops.Categories();
            var categoryIndex = 1;
            var groupName = ""; 

            foreach (var category in categories)
            {
                var products = ops.Products(category.CategoryId);
                groupName = category.Name.Replace("/", "").Replace(" ", "");

                var listViewGroup1 = new ListViewGroup(category.Name, HorizontalAlignment.Left)
                {
                    Header = category.Name,
                    Name = $"{groupName}Group{categoryIndex}"
                };

                ProductListView.Groups.Add(listViewGroup1);

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
                        Group = listViewGroup1
                    };

                    listViewProductItem.Tag = product.IdentifiersTag;

                    ProductListView.Items.Add(listViewProductItem);
                }
            }

            ProductListView.FocusedItem = ProductListView.Items[0];
            ProductListView.Items[0].Selected = true;

            ActiveControl = ProductListView;

            ProductListView.ItemSelectionChanged += ProductListView_ItemSelectionChanged;

        }

        private void ProductListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var primaryKeys = (ProductTag)e.Item.Tag;
                Console.WriteLine(primaryKeys.SupplierId);

            }
        }
    }
}
