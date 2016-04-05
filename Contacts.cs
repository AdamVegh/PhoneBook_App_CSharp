using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
	public partial class Contacts : Form
	{
		Person person;
		PhoneDirectory directory = new PhoneDirectory();

		public Contacts()
		{
			InitializeComponent();
			InitializeInputs();
		}

		private void InitializeInputs()
		{
			nameTextBox.Text = "";
			addressTextBox.Text = "";
			ageTextBox.Text = "";
			mobileTextBox.Text = "";
			typeComboBox.Text = null;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (nameTextBox.Text == "" || addressTextBox.Text == "" || ageTextBox.Text == "" || 
				mobileTextBox.Text == "" || typeComboBox.Text == null)
			{
				MessageBox.Show("És a hiányzó dógokat majd én tőccsem ki ecsém?", "Szomoroggyá...");
				return;
			}

			try
			{
				int ageToInt = int.Parse(ageTextBox.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("A korhu' számot aggyá, hee!", "Ejnye drága tesvírem!");
				return;
			}

			person = new Person(nameTextBox.Text, addressTextBox.Text, int.Parse(ageTextBox.Text), mobileTextBox.Text, typeComboBox.Text);
			directory.expandDirectory(person);
			MessageBox.Show(person.ToString(), "Added");

			InitializeInputs();
		}

		private void listButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show(directory.Directory.ToString());
		}
	}
}
