using System;
namespace Ex_telephone_directory
{
	public class Contact
	{
		public string Name { get; set; }
		public string Number { get; set; }


		public Contact(string name,string number)
		{
			Name = name;
			Number = number;
		}

	}
}

