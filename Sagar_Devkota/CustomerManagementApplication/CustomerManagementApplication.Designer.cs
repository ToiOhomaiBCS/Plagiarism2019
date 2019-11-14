namespace CustomerManagementApplication
{
  partial class CustomerManagementApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagementApplication));
            this.EnterCustomerNameLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CustomerDetailsListBox = new System.Windows.Forms.ListBox();
            this.CustomerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ListCustomersButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.CustomerDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterCustomerNameLabel
            // 
            this.EnterCustomerNameLabel.AutoSize = true;
            this.EnterCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCustomerNameLabel.Location = new System.Drawing.Point(43, 34);
            this.EnterCustomerNameLabel.Name = "EnterCustomerNameLabel";
            this.EnterCustomerNameLabel.Size = new System.Drawing.Size(113, 13);
            this.EnterCustomerNameLabel.TabIndex = 0;
            this.EnterCustomerNameLabel.Text = "Enter Customer Name:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(46, 51);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(206, 21);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(258, 50);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CustomerDetailsListBox
            // 
            this.CustomerDetailsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetailsListBox.FormattingEnabled = true;
            this.CustomerDetailsListBox.ItemHeight = 17;
            this.CustomerDetailsListBox.Location = new System.Drawing.Point(46, 104);
            this.CustomerDetailsListBox.Name = "CustomerDetailsListBox";
            this.CustomerDetailsListBox.Size = new System.Drawing.Size(287, 157);
            this.CustomerDetailsListBox.TabIndex = 13;
            this.CustomerDetailsListBox.Click += new System.EventHandler(this.CustomerDetailsListBox_SelectedIndexChanged);
            // 
            // CustomerDetailsGroupBox
            // 
            this.CustomerDetailsGroupBox.Controls.Add(this.PhoneTextBox);
            this.CustomerDetailsGroupBox.Controls.Add(this.LastNameTextBox);
            this.CustomerDetailsGroupBox.Controls.Add(this.FirstNameTextBox);
            this.CustomerDetailsGroupBox.Controls.Add(this.AddButton);
            this.CustomerDetailsGroupBox.Controls.Add(this.UpdateButton);
            this.CustomerDetailsGroupBox.Controls.Add(this.PhoneLabel);
            this.CustomerDetailsGroupBox.Controls.Add(this.LastNameLabel);
            this.CustomerDetailsGroupBox.Controls.Add(this.FirstNameLabel);
            this.CustomerDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetailsGroupBox.Location = new System.Drawing.Point(343, 98);
            this.CustomerDetailsGroupBox.Name = "CustomerDetailsGroupBox";
            this.CustomerDetailsGroupBox.Size = new System.Drawing.Size(287, 179);
            this.CustomerDetailsGroupBox.TabIndex = 4;
            this.CustomerDetailsGroupBox.TabStop = false;
            this.CustomerDetailsGroupBox.Text = "Customer Details";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(75, 91);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(206, 21);
            this.PhoneTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(75, 62);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(206, 21);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(75, 32);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(206, 21);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(150, 140);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(131, 24);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(9, 140);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(131, 24);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(27, 95);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Phone";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(7, 66);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 36);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name";
            // 
            // ListCustomersButton
            // 
            this.ListCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCustomersButton.Location = new System.Drawing.Point(46, 296);
            this.ListCustomersButton.Name = "ListCustomersButton";
            this.ListCustomersButton.Size = new System.Drawing.Size(137, 24);
            this.ListCustomersButton.TabIndex = 8;
            this.ListCustomersButton.Text = "LIST CUSTOMERS";
            this.ListCustomersButton.UseVisualStyleBackColor = true;
            this.ListCustomersButton.Click += new System.EventHandler(this.ListCustomersButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListButton.Location = new System.Drawing.Point(196, 296);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(137, 24);
            this.ClearListButton.TabIndex = 9;
            this.ClearListButton.Text = "CLEAR LIST";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(343, 296);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(140, 24);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(493, 296);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(137, 24);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.Image = ((System.Drawing.Image)(resources.GetObject("LogoLabel.Image")));
            this.LogoLabel.Location = new System.Drawing.Point(555, 9);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(75, 75);
            this.LogoLabel.TabIndex = 14;
            // 
            // CustomerManagementApplication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 358);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.ListCustomersButton);
            this.Controls.Add(this.CustomerDetailsGroupBox);
            this.Controls.Add(this.CustomerDetailsListBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.EnterCustomerNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(691, 397);
            this.MinimumSize = new System.Drawing.Size(691, 397);
            this.Name = "CustomerManagementApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management Application";
            this.Load += new System.EventHandler(this.CustomerManagementApplication_Load);
            this.CustomerDetailsGroupBox.ResumeLayout(false);
            this.CustomerDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label EnterCustomerNameLabel;
    private System.Windows.Forms.TextBox SearchTextBox;
    private System.Windows.Forms.Button SearchButton;
    private System.Windows.Forms.ListBox CustomerDetailsListBox;
    private System.Windows.Forms.GroupBox CustomerDetailsGroupBox;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button UpdateButton;
    private System.Windows.Forms.Label PhoneLabel;
    private System.Windows.Forms.Label LastNameLabel;
    private System.Windows.Forms.Label FirstNameLabel;
    private System.Windows.Forms.Button ListCustomersButton;
    private System.Windows.Forms.Button ClearListButton;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Button ClearButton;
    private System.Windows.Forms.TextBox PhoneTextBox;
    private System.Windows.Forms.TextBox LastNameTextBox;
    private System.Windows.Forms.TextBox FirstNameTextBox;
    private System.Windows.Forms.Label LogoLabel;
  }
}

