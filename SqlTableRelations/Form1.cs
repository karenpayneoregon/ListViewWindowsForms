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

namespace SqlTableRelations
{
    public partial class Form1 : Form
    {
        private SqlInformation _tableInformation = new SqlInformation();

        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var items = _tableInformation.TableDependencies();
            tableInformationComboBox.DataSource = new BindingSource(items, null);
            tableInformationComboBox.DisplayMember = "Key";
        }

        private void GetInformationButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var detailItems = ((KeyValuePair<string, List<ServerTableItem> >)tableInformationComboBox.SelectedItem);

            foreach (var serverTableItem in detailItems.Value)
            {
                var item = listView1.Items.Add(serverTableItem.FieldOrder.ToString());
                item.SubItems.Add(serverTableItem.Field);
                item.SubItems.Add(serverTableItem.DataType);
                item.SubItems.Add(serverTableItem.Length.ToString());
                item.SubItems.Add(serverTableItem.Precision.ToString());
                item.SubItems.Add(serverTableItem.Scale.ToString());
                item.SubItems.Add(serverTableItem.AllowNulls);
                item.SubItems.Add(serverTableItem.Identity);
                item.SubItems.Add(serverTableItem.PrimaryKey);
                item.SubItems.Add(serverTableItem.ForeignKey);
                item.SubItems.Add(serverTableItem.RelatedTable);
                //item.SubItems.Add(serverTableItem.Description);
            }

            if (AutoSizeColumnsCheckBox.Checked)
            {
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listView1.FocusedItem = listView1.Items[0];
            listView1.Items[0].Selected = true;
            ActiveControl = listView1;
        }
    }
}
