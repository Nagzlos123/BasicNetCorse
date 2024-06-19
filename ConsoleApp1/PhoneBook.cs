using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContactToList()
        {
            Console.WriteLine("Adding contact...");
            Console.WriteLine("Type firstname: ");
            string userInputFirstName = Console.ReadLine();
            Console.WriteLine("Type lastname: ");
            string userInputLastName = Console.ReadLine();
            Console.WriteLine("Type phone number: ");
            string userInputPhoneNumber = Console.ReadLine();

            Contact newContact = new Contact(userInputFirstName, userInputLastName, userInputPhoneNumber);
            Contacts.Add(newContact);
        }

        private void DisplayContactInfo(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.FirstName} {contact.LastName} {contact.PhoneNumber}");
        }

        private void DisplayAllContactInfo(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                DisplayContactInfo(contact);
            }
        }

        //Console.WriteLine($"Contact: {contact.FirstName} {contact.LastName} {contact.PhoneNumber}");

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.PhoneNumber == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                DisplayContactInfo(contact);
            }
        }

        public void DisplayAllContacts()
        {
            Console.WriteLine("Displaing all contacts...");

            if (Contacts.Count != 0)
            {
                //DisplayAllContactInfo(Contacts);
                Contacts.ForEach(c => Console.WriteLine($"Contact: {c.FirstName} {c.LastName} {c.PhoneNumber}"));
            }
            else
            {
                Console.WriteLine("List is emty!");
            }

        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
         
            var matchingContacts = Contacts.Where(c => c.FirstName.Contains(searchPhrase)).ToList();
            DisplayAllContactInfo(matchingContacts);
        }

        public void DeleteContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.PhoneNumber == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                DisplayContactInfo(contact);
                Console.WriteLine("Do you want to delete this contact?");
                Console.WriteLine("If yes type 'y' and if no type 'n'");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "y":
                        Contacts.Remove(contact);
                        break;
                    case "n":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            }
    
        }
    }
}

