namespace BasicListViewGroupsExampleCore;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ProductListView = new ListView();
        ProductColumn = new ColumnHeader();
        SupplierColumn = new ColumnHeader();
        PhoneColumn = new ColumnHeader();
        UnitPriceColumn = new ColumnHeader();
        UnitsInStockColumn = new ColumnHeader();
        panel1 = new Panel();
        IterateListViewGroupsButton = new Button();
        GetGroupProductsButton = new Button();
        GroupsComboBox = new ComboBox();
        HoverSelectionCheckBox = new CheckBox();
        SelectionChangedLabel = new Label();
        ItemCheckedLabel = new Label();
        SelectedProductsButton = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // ProductListView
        // 
        ProductListView.CheckBoxes = true;
        ProductListView.Columns.AddRange(new ColumnHeader[] { ProductColumn, SupplierColumn, PhoneColumn, UnitPriceColumn, UnitsInStockColumn });
        ProductListView.Dock = DockStyle.Fill;
        ProductListView.FullRowSelect = true;
        ProductListView.HoverSelection = true;
        ProductListView.Location = new Point(0, 0);
        ProductListView.Margin = new Padding(4, 5, 4, 5);
        ProductListView.MultiSelect = false;
        ProductListView.Name = "ProductListView";
        ProductListView.Size = new Size(854, 723);
        ProductListView.TabIndex = 3;
        ProductListView.UseCompatibleStateImageBehavior = false;
        ProductListView.View = View.Details;
        // 
        // ProductColumn
        // 
        ProductColumn.Text = "Product";
        ProductColumn.Width = 180;
        // 
        // SupplierColumn
        // 
        SupplierColumn.Text = "Supplier";
        SupplierColumn.Width = 210;
        // 
        // PhoneColumn
        // 
        PhoneColumn.Text = "Phone";
        PhoneColumn.Width = 85;
        // 
        // UnitPriceColumn
        // 
        UnitPriceColumn.Text = "Unit price";
        // 
        // UnitsInStockColumn
        // 
        UnitsInStockColumn.Text = "In stock";
        UnitsInStockColumn.TextAlign = HorizontalAlignment.Right;
        // 
        // panel1
        // 
        panel1.Controls.Add(IterateListViewGroupsButton);
        panel1.Controls.Add(GetGroupProductsButton);
        panel1.Controls.Add(GroupsComboBox);
        panel1.Controls.Add(HoverSelectionCheckBox);
        panel1.Controls.Add(SelectionChangedLabel);
        panel1.Controls.Add(ItemCheckedLabel);
        panel1.Controls.Add(SelectedProductsButton);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 723);
        panel1.Margin = new Padding(4, 5, 4, 5);
        panel1.Name = "panel1";
        panel1.Size = new Size(854, 183);
        panel1.TabIndex = 4;
        // 
        // IterateListViewGroupsButton
        // 
        IterateListViewGroupsButton.Location = new Point(660, 71);
        IterateListViewGroupsButton.Margin = new Padding(4, 5, 4, 5);
        IterateListViewGroupsButton.Name = "IterateListViewGroupsButton";
        IterateListViewGroupsButton.Size = new Size(165, 35);
        IterateListViewGroupsButton.TabIndex = 9;
        IterateListViewGroupsButton.Text = "Iterate Groups";
        IterateListViewGroupsButton.UseVisualStyleBackColor = true;
        IterateListViewGroupsButton.Click += IterateListViewGroupsButton_Click;
        // 
        // GetGroupProductsButton
        // 
        GetGroupProductsButton.Location = new Point(660, 18);
        GetGroupProductsButton.Margin = new Padding(4, 5, 4, 5);
        GetGroupProductsButton.Name = "GetGroupProductsButton";
        GetGroupProductsButton.Size = new Size(165, 35);
        GetGroupProductsButton.TabIndex = 8;
        GetGroupProductsButton.Text = "Get Products";
        GetGroupProductsButton.UseVisualStyleBackColor = true;
        GetGroupProductsButton.Click += GetGroupProductsButton_Click;
        // 
        // GroupsComboBox
        // 
        GroupsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        GroupsComboBox.FormattingEnabled = true;
        GroupsComboBox.Location = new Point(452, 22);
        GroupsComboBox.Margin = new Padding(4, 5, 4, 5);
        GroupsComboBox.Name = "GroupsComboBox";
        GroupsComboBox.Size = new Size(199, 28);
        GroupsComboBox.TabIndex = 5;
        // 
        // HoverSelectionCheckBox
        // 
        HoverSelectionCheckBox.AutoSize = true;
        HoverSelectionCheckBox.Checked = true;
        HoverSelectionCheckBox.CheckState = CheckState.Checked;
        HoverSelectionCheckBox.Location = new Point(20, 71);
        HoverSelectionCheckBox.Margin = new Padding(4, 5, 4, 5);
        HoverSelectionCheckBox.Name = "HoverSelectionCheckBox";
        HoverSelectionCheckBox.Size = new Size(136, 24);
        HoverSelectionCheckBox.TabIndex = 5;
        HoverSelectionCheckBox.Text = "Hover Selection";
        HoverSelectionCheckBox.UseVisualStyleBackColor = true;
        // 
        // SelectionChangedLabel
        // 
        SelectionChangedLabel.AutoSize = true;
        SelectionChangedLabel.Location = new Point(16, 146);
        SelectionChangedLabel.Margin = new Padding(4, 0, 4, 0);
        SelectionChangedLabel.Name = "SelectionChangedLabel";
        SelectionChangedLabel.Size = new Size(131, 20);
        SelectionChangedLabel.TabIndex = 7;
        SelectionChangedLabel.Text = "Selection changed";
        // 
        // ItemCheckedLabel
        // 
        ItemCheckedLabel.AutoSize = true;
        ItemCheckedLabel.Location = new Point(16, 112);
        ItemCheckedLabel.Margin = new Padding(4, 0, 4, 0);
        ItemCheckedLabel.Name = "ItemCheckedLabel";
        ItemCheckedLabel.Size = new Size(99, 20);
        ItemCheckedLabel.TabIndex = 6;
        ItemCheckedLabel.Text = "Item Checked";
        // 
        // SelectedProductsButton
        // 
        SelectedProductsButton.Location = new Point(16, 18);
        SelectedProductsButton.Margin = new Padding(4, 5, 4, 5);
        SelectedProductsButton.Name = "SelectedProductsButton";
        SelectedProductsButton.Size = new Size(165, 35);
        SelectedProductsButton.TabIndex = 5;
        SelectedProductsButton.Text = "Selected products";
        SelectedProductsButton.UseVisualStyleBackColor = true;
        SelectedProductsButton.Click += SelectedProductsButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(854, 906);
        Controls.Add(ProductListView);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(4, 5, 4, 5);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Group products by category";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private System.Windows.Forms.ListView ProductListView;
    private System.Windows.Forms.ColumnHeader ProductColumn;
    private System.Windows.Forms.ColumnHeader SupplierColumn;
    private System.Windows.Forms.ColumnHeader PhoneColumn;
    private System.Windows.Forms.ColumnHeader UnitPriceColumn;
    private System.Windows.Forms.ColumnHeader UnitsInStockColumn;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button SelectedProductsButton;
    private System.Windows.Forms.Label ItemCheckedLabel;
    private System.Windows.Forms.Label SelectionChangedLabel;
    private System.Windows.Forms.CheckBox HoverSelectionCheckBox;
    private System.Windows.Forms.ComboBox GroupsComboBox;
    private System.Windows.Forms.Button GetGroupProductsButton;
    private System.Windows.Forms.Button IterateListViewGroupsButton;
}
