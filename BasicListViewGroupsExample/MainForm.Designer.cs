namespace BasicListViewGroupsExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.ProductListView = new System.Windows.Forms.ListView();
            this.ProductColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SupplierColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitsInStockColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectedProductsButton = new System.Windows.Forms.Button();
            this.ItemCheckedLabel = new System.Windows.Forms.Label();
            this.SelectionChangedLabel = new System.Windows.Forms.Label();
            this.HoverSelectionCheckBox = new System.Windows.Forms.CheckBox();
            this.GroupsComboBox = new System.Windows.Forms.ComboBox();
            this.GetGroupProductsButton = new System.Windows.Forms.Button();
            this.IterateListViewGroupsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductListView
            // 
            this.ProductListView.CheckBoxes = true;
            this.ProductListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductColumn,
            this.SupplierColumn,
            this.PhoneColumn,
            this.UnitPriceColumn,
            this.UnitsInStockColumn});
            this.ProductListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductListView.FullRowSelect = true;
            this.ProductListView.HoverSelection = true;
            this.ProductListView.Location = new System.Drawing.Point(0, 0);
            this.ProductListView.MultiSelect = false;
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.Size = new System.Drawing.Size(631, 470);
            this.ProductListView.TabIndex = 3;
            this.ProductListView.UseCompatibleStateImageBehavior = false;
            this.ProductListView.View = System.Windows.Forms.View.Details;
            // 
            // ProductColumn
            // 
            this.ProductColumn.Text = "Product";
            this.ProductColumn.Width = 180;
            // 
            // SupplierColumn
            // 
            this.SupplierColumn.Text = "Supplier";
            this.SupplierColumn.Width = 210;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.Text = "Phone";
            this.PhoneColumn.Width = 85;
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.Text = "Unit price";
            // 
            // UnitsInStockColumn
            // 
            this.UnitsInStockColumn.Text = "In stock";
            this.UnitsInStockColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IterateListViewGroupsButton);
            this.panel1.Controls.Add(this.GetGroupProductsButton);
            this.panel1.Controls.Add(this.GroupsComboBox);
            this.panel1.Controls.Add(this.HoverSelectionCheckBox);
            this.panel1.Controls.Add(this.SelectionChangedLabel);
            this.panel1.Controls.Add(this.ItemCheckedLabel);
            this.panel1.Controls.Add(this.SelectedProductsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 119);
            this.panel1.TabIndex = 4;
            // 
            // SelectedProductsButton
            // 
            this.SelectedProductsButton.Location = new System.Drawing.Point(12, 12);
            this.SelectedProductsButton.Name = "SelectedProductsButton";
            this.SelectedProductsButton.Size = new System.Drawing.Size(124, 23);
            this.SelectedProductsButton.TabIndex = 5;
            this.SelectedProductsButton.Text = "Selected products";
            this.SelectedProductsButton.UseVisualStyleBackColor = true;
            this.SelectedProductsButton.Click += new System.EventHandler(this.SelectedProductsButton_Click);
            // 
            // ItemCheckedLabel
            // 
            this.ItemCheckedLabel.AutoSize = true;
            this.ItemCheckedLabel.Location = new System.Drawing.Point(12, 73);
            this.ItemCheckedLabel.Name = "ItemCheckedLabel";
            this.ItemCheckedLabel.Size = new System.Drawing.Size(73, 13);
            this.ItemCheckedLabel.TabIndex = 6;
            this.ItemCheckedLabel.Text = "Item Checked";
            // 
            // SelectionChangedLabel
            // 
            this.SelectionChangedLabel.AutoSize = true;
            this.SelectionChangedLabel.Location = new System.Drawing.Point(12, 95);
            this.SelectionChangedLabel.Name = "SelectionChangedLabel";
            this.SelectionChangedLabel.Size = new System.Drawing.Size(96, 13);
            this.SelectionChangedLabel.TabIndex = 7;
            this.SelectionChangedLabel.Text = "Selection changed";
            // 
            // HoverSelectionCheckBox
            // 
            this.HoverSelectionCheckBox.AutoSize = true;
            this.HoverSelectionCheckBox.Checked = true;
            this.HoverSelectionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HoverSelectionCheckBox.Location = new System.Drawing.Point(15, 46);
            this.HoverSelectionCheckBox.Name = "HoverSelectionCheckBox";
            this.HoverSelectionCheckBox.Size = new System.Drawing.Size(102, 17);
            this.HoverSelectionCheckBox.TabIndex = 5;
            this.HoverSelectionCheckBox.Text = "Hover Selection";
            this.HoverSelectionCheckBox.UseVisualStyleBackColor = true;
            this.HoverSelectionCheckBox.CheckedChanged += new System.EventHandler(this.HoverSelectionCheckBox_CheckedChanged);
            // 
            // GroupsComboBox
            // 
            this.GroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupsComboBox.FormattingEnabled = true;
            this.GroupsComboBox.Location = new System.Drawing.Point(339, 14);
            this.GroupsComboBox.Name = "GroupsComboBox";
            this.GroupsComboBox.Size = new System.Drawing.Size(150, 21);
            this.GroupsComboBox.TabIndex = 5;
            // 
            // GetGroupProductsButton
            // 
            this.GetGroupProductsButton.Location = new System.Drawing.Point(495, 12);
            this.GetGroupProductsButton.Name = "GetGroupProductsButton";
            this.GetGroupProductsButton.Size = new System.Drawing.Size(124, 23);
            this.GetGroupProductsButton.TabIndex = 8;
            this.GetGroupProductsButton.Text = "Get Products";
            this.GetGroupProductsButton.UseVisualStyleBackColor = true;
            this.GetGroupProductsButton.Click += new System.EventHandler(this.GetGroupProductsButton_Click);
            // 
            // IterateListViewGroupsButton
            // 
            this.IterateListViewGroupsButton.Location = new System.Drawing.Point(495, 46);
            this.IterateListViewGroupsButton.Name = "IterateListViewGroupsButton";
            this.IterateListViewGroupsButton.Size = new System.Drawing.Size(124, 23);
            this.IterateListViewGroupsButton.TabIndex = 9;
            this.IterateListViewGroupsButton.Text = "Iterate Groups";
            this.IterateListViewGroupsButton.UseVisualStyleBackColor = true;
            this.IterateListViewGroupsButton.Click += new System.EventHandler(this.IterateListViewGroupsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 589);
            this.Controls.Add(this.ProductListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group products by category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
}

