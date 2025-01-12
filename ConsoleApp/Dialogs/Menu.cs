using Business.Factories;
using Business.Interfaces;

namespace ConsoleApp.Dialogs;

public class Menu(IContactService contactService)
{
    private readonly IContactService _contactService = contactService;

    public void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("3. Quit");
            Console.Write("\nSelect Action: ");

            var action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    AddContact();
                    break;
                
                case "2":
                    ViewContacts();
                    break;
                
                case "3":
                    break;
            }
        }
    }

    public void AddContact()
    {
        var contact = ContactFactory.Create();

        Console.Clear();
        Console.WriteLine("*** ADD CONTACT ***");

        Console.Write("First Name: ");
        contact.FirstName = Console.ReadLine();

        Console.Write("Last Name: ");
        contact.LastName = Console.ReadLine();

        Console.Write("Email: ");
        contact.Email = Console.ReadLine();

        Console.Write("Phone Number: ");
        contact.PhoneNumber = Console.ReadLine();

        Console.Write("Street Address: ");
        contact.StreetAddress = Console.ReadLine();

        Console.Write("Zip Code: ");
        contact.ZipCode = Console.ReadLine();

        Console.Write("City: ");
        contact.City = Console.ReadLine();

        var result = _contactService.Add(contact);

        if (!result)
        {
            Console.WriteLine("Something went wrong, unable to add contact");
        }
        else
        {
            Console.WriteLine("Contact successfully added!");
        }

        Console.ReadKey();
    }

    public void ViewContacts()
    {
        var contacts = _contactService.GetAll();

        Console.Clear();
        Console.WriteLine("*** CONTACTS ***");

        var index = 0;
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{index + 1}. {contact.FirstName} {contact.LastName} {contact.Email} {contact.PhoneNumber} {contact.StreetAddress} {contact.ZipCode} {contact.City}");
            index++;
        }

        Console.ReadKey();
    }
}
