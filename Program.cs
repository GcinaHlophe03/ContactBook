using System;
using System.Collections.Generic;  // This is necessary for using List<T>

namespace ContactBook
{
    class Program
    {
        public class Contact
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

            public Contact(string name, string phoneNumber, string email)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }

        // List to store contacts
        static List<Contact> contacts = new List<Contact>();

        // Display Menu
        public static void DisplayMenu()
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("3. Search Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Update Contact");
            Console.WriteLine("6. Exit");
        }

        // Add a new contact
        public static void AddContact()
        {
            Console.Write("Enter full name: ");
            string name = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            // Create new contact and add it to the list
            Contact newContact = new Contact(name, phoneNumber, email);
            contacts.Add(newContact);

            Console.WriteLine("Contact added successfully!");
        }

        // View all contacts
        public static void ViewContact()
        {
            if (contacts.Count == 0)  // Check if there are no contacts
            {
                Console.WriteLine("No contacts found!");
            }
            else
            {
                Console.WriteLine("Contacts: ");
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine($"Name: {contact.Name}");
                    Console.WriteLine($"Phone Number: {contact.PhoneNumber}");  // Fixed typo here
                    Console.WriteLine($"Email: {contact.Email}");
                    Console.WriteLine("-------------------------------------");
                }
            }
        }

        static void Main(String[] args)
        {
            int choice;

            do
            {
                DisplayMenu();
                choice = int.Parse(Console.ReadLine());

                // Handle user's choice
                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        ViewContact();
                        break;
                    case 3:
                        Console.WriteLine("Search functionality is not yet implemented.");
                        break;
                    case 4:
                        Console.WriteLine("Delete functionality is not yet implemented.");
                        break;
                    case 5:
                        Console.WriteLine("Update functionality is not yet implemented.");
                        break;
                    case 6:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (choice != 6);  // Correct placement of the while condition
        }
    }
}
