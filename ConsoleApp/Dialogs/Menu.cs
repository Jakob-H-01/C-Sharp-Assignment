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
        Console.Clear();
    }

    public void ViewContacts()
    {
        Console.Clear();
    }
}
