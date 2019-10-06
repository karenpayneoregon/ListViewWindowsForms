namespace BasicListViewGroupsExample
{
    partial class Form1
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
            this.ProductListView.Location = new System.Drawing.Point(0, 0);
            this.ProductListView.MultiSelect = false;
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.Size = new System.Drawing.Size(631, 507);
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
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 62);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 569);
            this.Controls.Add(this.ProductListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group products by category";
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
    }
}

