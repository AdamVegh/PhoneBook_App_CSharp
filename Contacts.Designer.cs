namespace PhoneBook
{
	partial class Contacts
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.addressLabel = new System.Windows.Forms.Label();
			this.ageLabel = new System.Windows.Forms.Label();
			this.mobileLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.ageTextBox = new System.Windows.Forms.TextBox();
			this.mobileTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.listButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(24, 43);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(35, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name";
			// 
			// addressLabel
			// 
			this.addressLabel.AutoSize = true;
			this.addressLabel.Location = new System.Drawing.Point(24, 86);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(45, 13);
			this.addressLabel.TabIndex = 1;
			this.addressLabel.Text = "Address";
			// 
			// ageLabel
			// 
			this.ageLabel.AutoSize = true;
			this.ageLabel.Location = new System.Drawing.Point(24, 111);
			this.ageLabel.Name = "ageLabel";
			this.ageLabel.Size = new System.Drawing.Size(26, 13);
			this.ageLabel.TabIndex = 2;
			this.ageLabel.Text = "Age";
			// 
			// mobileLabel
			// 
			this.mobileLabel.AutoSize = true;
			this.mobileLabel.Location = new System.Drawing.Point(24, 136);
			this.mobileLabel.Name = "mobileLabel";
			this.mobileLabel.Size = new System.Drawing.Size(38, 13);
			this.mobileLabel.TabIndex = 3;
			this.mobileLabel.Text = "Mobile";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(24, 178);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(31, 13);
			this.typeLabel.TabIndex = 4;
			this.typeLabel.Text = "Type";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(128, 40);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(164, 20);
			this.nameTextBox.TabIndex = 1;
			// 
			// typeComboBox
			// 
			this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Items.AddRange(new object[] {
            "Home",
            "Workplace",
            "Mobile"});
			this.typeComboBox.Location = new System.Drawing.Point(128, 175);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(164, 21);
			this.typeComboBox.TabIndex = 5;
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(128, 83);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(164, 20);
			this.addressTextBox.TabIndex = 2;
			// 
			// ageTextBox
			// 
			this.ageTextBox.Location = new System.Drawing.Point(128, 108);
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(164, 20);
			this.ageTextBox.TabIndex = 3;
			// 
			// mobileTextBox
			// 
			this.mobileTextBox.Location = new System.Drawing.Point(128, 133);
			this.mobileTextBox.Name = "mobileTextBox";
			this.mobileTextBox.Size = new System.Drawing.Size(164, 20);
			this.mobileTextBox.TabIndex = 4;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(128, 216);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// listButton
			// 
			this.listButton.Location = new System.Drawing.Point(217, 216);
			this.listButton.Name = "listButton";
			this.listButton.Size = new System.Drawing.Size(75, 23);
			this.listButton.TabIndex = 7;
			this.listButton.Text = "List";
			this.listButton.UseVisualStyleBackColor = true;
			this.listButton.Click += new System.EventHandler(this.listButton_Click);
			// 
			// Contacts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 261);
			this.Controls.Add(this.listButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.mobileTextBox);
			this.Controls.Add(this.ageTextBox);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.mobileLabel);
			this.Controls.Add(this.ageLabel);
			this.Controls.Add(this.addressLabel);
			this.Controls.Add(this.nameLabel);
			this.MaximumSize = new System.Drawing.Size(350, 300);
			this.MinimumSize = new System.Drawing.Size(350, 300);
			this.Name = "Contacts";
			this.Text = "Contents";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label addressLabel;
		private System.Windows.Forms.Label ageLabel;
		private System.Windows.Forms.Label mobileLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.TextBox mobileTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button listButton;
	}
}

