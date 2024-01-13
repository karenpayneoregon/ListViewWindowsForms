namespace BasicListViewGroupsExampleCore;
public partial class SelectedProductsForm : Form
{
    private string _selectedData;
    public SelectedProductsForm()
    {
        InitializeComponent();
    }
    public SelectedProductsForm(string selectedData)
    {
        InitializeComponent();
        _selectedData = selectedData;
        Shown += SelectedProductsForm_Shown;
    }

    private void SelectedProductsForm_Shown(object sender, EventArgs e)
    {
        textBox1.Text = _selectedData;
    }
}
