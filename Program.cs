using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
	public struct Person
	{
		public string name;
		public string address;
		public int age;
		public string telephoneNumber;
		public string phoneType;

		public Person(string name, string address, int age, string telephoneNumber, string phoneType)
		{
			this.name = name;
			this.address = address;
			this.age = age;
			this.telephoneNumber = telephoneNumber;
			this.phoneType = phoneType;
		}

		public override string ToString()
		{
			return string.Format("Name:\t\t{0}\nAddress:\t\t{1}\nAge:\t\t{2}\nTelephone:\t{3}\nType:\t\t{4}",
								  name, address, age, telephoneNumber, phoneType);
		}
	}

	public class PhoneDirectory //: IEnumerable<Person>
	{
		private List<Person> directory = new List<Person>(50);

		private string stringDirectory(List<Person> directory)
		{
			List<string> personData = new List<string>();
			foreach (Person person in directory)
			{
				personData.Add(person.ToString());
			}
			return string.Join("\n-------------\n", personData);
		}

		public string Directory
		{
			get { return stringDirectory(directory); }
		}


		public void expandDirectory(Person person)
		{
			directory.Add(person);
		}

		//public IEnumerator<Person> GetEnumerator()
		//{
		//	throw new NotImplementedException();
		//}

		//IEnumerator IEnumerable.GetEnumerator()
		//{
		//	throw new NotImplementedException();
		//}
	}

	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Contacts());
		}
	}
}
