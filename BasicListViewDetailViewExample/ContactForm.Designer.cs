namespace BasicListViewDetailViewExample
{
    partial class ContactForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MockedEditButton = new System.Windows.Forms.Button();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.ownerContactListView = new System.Windows.Forms.ListView();
            this.CompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(479, 23);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MockedEditButton);
            this.panel1.Controls.Add(this.RemoveSelectedButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 70);
            this.panel1.TabIndex = 1;
            // 
            // MockedEditButton
            // 
            this.MockedEditButton.Location = new System.Drawing.Point(136, 25);
            this.MockedEditButton.Name = "MockedEditButton";
            this.MockedEditButton.Size = new System.Drawing.Size(106, 23);
            this.MockedEditButton.TabIndex = 2;
            this.MockedEditButton.Text = "Mock edit";
            this.MockedEditButton.UseVisualStyleBackColor = true;
            this.MockedEditButton.Visible = false;
            this.MockedEditButton.Click += new System.EventHandler(this.MockedEditButton_Click);
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(13, 25);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(106, 23);
            this.RemoveSelectedButton.TabIndex = 1;
            this.RemoveSelectedButton.Text = "Remove selected";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Visible = false;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // ownerContactListView
            // 
            this.ownerContactListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ownerContactListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CompanyName,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.PhoneColumn,
            this.CountryColumn});
            this.ownerContactListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerContactListView.HideSelection = false;
            this.ownerContactListView.LabelEdit = true;
            this.ownerContactListView.Location = new System.Drawing.Point(0, 0);
            this.ownerContactListView.Name = "ownerContactListView";
            this.ownerContactListView.Size = new System.Drawing.Size(566, 245);
            this.ownerContactListView.TabIndex = 2;
            this.ownerContactListView.UseCompatibleStateImageBehavior = false;
            this.ownerContactListView.View = System.Windows.Forms.View.Details;
            // 
            // CompanyName
            // 
            this.CompanyName.Text = "Company";
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.Text = "First";
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Text = "Last";
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.Text = "Phone";
            // 
            // CountryColumn
            // 
            this.CountryColumn.Text = "Country";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 315);
            this.Controls.Add(this.ownerContactListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts -Owners";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView ownerContactListView;
        private System.Windows.Forms.ColumnHeader CompanyName;
        private System.Windows.Forms.ColumnHeader FirstNameColumn;
        private System.Windows.Forms.ColumnHeader LastNameColumn;
        private System.Windows.Forms.ColumnHeader PhoneColumn;
        private System.Windows.Forms.ColumnHeader CountryColumn;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.Button MockedEditButton;
    }
}

