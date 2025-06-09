using System;
using System.Linq;

namespace Ex_telephone_directory
{
	public class PhoneBook
	{
		public List<Contact> Contacts { get; set; } = new List<Contact>();

		public void AddContact(Contact contact)
		{
			Contacts.Add(contact);
		}

		private void DisplayContactDetails(Contact contact)
		{
            Console.WriteLine($"Contact : {contact.Name} , {contact.Number}");
        }

		private void  DisplayContactDetails(List<Contact> contacs)
		{
            foreach (var contact in contacs)
            {
                DisplayContactDetails(contact);
            }
        }

		public void DisplayContact(string number)
		{
			var contact = Contacts.FirstOrDefault(c => c.Number == number);

			if (contact == null)
			{
				Console.WriteLine("Not found");
			}
			else
			{
				DisplayContactDetails(contact);
            }
		}

		public void  DisplayAllContact()
		{
			DisplayContactDetails(Contacts);
        }

		public void DisplayMatchingContacts(string searchPharse)
		{
			var machingContacts = Contacts.Where(c => c.Name.Contains(searchPharse)).ToList();
			DisplayContactDetails(machingContacts);

        }

		public void RemoveContact(string number)
		{
			var contactToRemove = Contacts.FirstOrDefault(c => c.Number == number);

			if(contactToRemove != null)
			{
				Contacts.Remove(contactToRemove);
				Console.WriteLine($"Contact {contactToRemove.Name} with number {contactToRemove.Number} removed");
			}
			else
			{
				Console.WriteLine("Contact not found");
			}
		}
	}
}

