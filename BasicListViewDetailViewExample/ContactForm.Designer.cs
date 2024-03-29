﻿namespace BasicListViewDetailViewExample
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
            this.ForumQuestionButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.CountLabel);
            this.panel1.Controls.Add(this.AddRowButton);
            this.panel1.Controls.Add(this.ForumQuestionButton);
            this.panel1.Controls.Add(this.MockedEditButton);
            this.panel1.Controls.Add(this.RemoveSelectedButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 70);
            this.panel1.TabIndex = 1;
            // 
            // MockedEditButton
            // 
            this.MockedEditButton.Location = new System.Drawing.Point(12, 35);
            this.MockedEditButton.Name = "MockedEditButton";
            this.MockedEditButton.Size = new System.Drawing.Size(106, 23);
            this.MockedEditButton.TabIndex = 2;
            this.MockedEditButton.Text = "Mock edit";
            this.MockedEditButton.UseVisualStyleBackColor = true;
            this.MockedEditButton.Click += new System.EventHandler(this.MockedEditButton_Click);
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(12, 6);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(106, 23);
            this.RemoveSelectedButton.TabIndex = 1;
            this.RemoveSelectedButton.Text = "Remove selected";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // ownerContactListView
            // 
            this.ownerContactListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CompanyName,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.PhoneColumn,
            this.CountryColumn});
            this.ownerContactListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownerContactListView.FullRowSelect = true;
            this.ownerContactListView.HideSelection = false;
            this.ownerContactListView.Location = new System.Drawing.Point(0, 0);
            this.ownerContactListView.Name = "ownerContactListView";
            this.ownerContactListView.Size = new System.Drawing.Size(566, 422);
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
            // ForumQuestionButton
            // 
            this.ForumQuestionButton.Location = new System.Drawing.Point(137, 6);
            this.ForumQuestionButton.Name = "ForumQuestionButton";
            this.ForumQuestionButton.Size = new System.Drawing.Size(106, 23);
            this.ForumQuestionButton.TabIndex = 3;
            this.ForumQuestionButton.Text = "Forum Question";
            this.ForumQuestionButton.UseVisualStyleBackColor = true;
            this.ForumQuestionButton.Click += new System.EventHandler(this.ForumQuestionButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(137, 35);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(106, 23);
            this.AddRowButton.TabIndex = 4;
            this.AddRowButton.Text = "Add mocked";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(261, 40);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(35, 13);
            this.CountLabel.TabIndex = 5;
            this.CountLabel.Text = "Count";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 492);
            this.Controls.Add(this.ownerContactListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts -Owners";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button ForumQuestionButton;
        private System.Windows.Forms.Label CountLabel;
    }
}

