using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Contact
    {
        public string FirstName {
            get {return firstName; }
            set {
                if (value.Length < 3)
                {
                    Console.WriteLine("Invalid contact first name!");
                }
                else
                {
                    firstName = value;
                }

                ; }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Invalid contact last name!");
                }
                else
                {
                    lastName = value;
                }

                ;
            }
        }

        public string PhoneNumber { 
            get { return contactNumber; }
            set {

                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number!");
                }
                else
                {
                    contactNumber = value;
                }

                ; } 
        }
        private string firstName;
        private string lastName;
        private string contactNumber;


        public Contact(string firstName, string lastname, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastname;
            PhoneNumber = phoneNumber;
        }
    }
}
