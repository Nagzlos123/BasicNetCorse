using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
         
    
        static void Main(string[] args)
        {

           
            Console.WriteLine("This is phone book aplication");
            Console.WriteLine("Select one of option: ");
            Console.WriteLine("Select 1 : Add contact");
            Console.WriteLine("Select 2 : Display contact based on phone number");
            Console.WriteLine("Select 3 : Display all contacts");
            Console.WriteLine("Select 4 : Search for contacts for a given name");
            Console.WriteLine("Select 5 : Delete contact based on phon number");
            Console.WriteLine("Select 0 : Quit app");

            string userInput = Console.ReadLine();

            PhoneBook phoneBook = new PhoneBook();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        phoneBook.AddContactToList();
                        break;

                    case "2":
                        Console.WriteLine("Type phone number: ");
                        string userInputPhoneNumber = Console.ReadLine();
                        phoneBook.DisplayContact(userInputPhoneNumber);
                        break;

                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;

                    case "4":
                        Console.WriteLine("Type search phrase: ");
                        string userInputSearchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(userInputSearchPhrase);
                        break;
                    case "5":
                        Console.WriteLine("Type phone number to delete: ");
                        string userInputContactToDelete = Console.ReadLine();
                        phoneBook.DeleteContact(userInputContactToDelete);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                userInput = Console.ReadLine();
            }


            Console.ReadLine();

        }
    }
}
