namespace Ex_telephone_directory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from the PhoneBook app");

        Console.WriteLine("1. Add contact");
        Console.WriteLine("2. Display contact by number");
        Console.WriteLine("3. Display all contact");
        Console.WriteLine("4. Search contact ");
        Console.WriteLine("5, Remove contact");
        Console.WriteLine("To exit insert 'x'");

        var user_input = Console.ReadLine();

        var phoneBook = new PhoneBook();


        while(true)
        {
            switch (user_input)
            {
                case "1":
                    Console.WriteLine("Insert number");
                    var number = Console.ReadLine();
                    Console.WriteLine("Insert name");
                    var name = Console.ReadLine();
                    var new_contact = new Contact(name, number);
                    phoneBook.AddContact(new_contact);
                    break;

                case "2":
                    Console.WriteLine("Insert number");
                    var numberToSearch = Console.ReadLine();
                    phoneBook.DisplayContact(numberToSearch);
                    break;
                case "3":
                    phoneBook.DisplayAllContact();
                    break;
                case "4":
                    Console.WriteLine("Insert search phrase :");
                    var searchPharse = Console.ReadLine();
                    phoneBook.DisplayMatchingContacts(searchPharse);
                    break;
                case "5":
                    Console.WriteLine("Enter number to delete :");
                    var numberToDelete = Console.ReadLine();
                    phoneBook.RemoveContact(numberToDelete);
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            Console.WriteLine("Select operation :");
            user_input = Console.ReadLine();

        }
    }
}

