using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dayOfBirth;
        private string contactNumber;
        public static int Count = 0;

        public DateTime DayOfBirth
        {
            get { return dayOfBirth; }
            set { dayOfBirth = value; }
        }
        public string ContactNumber
        {
            get { return contactNumber; }
            set { 
                if(value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number!");
                }
                else
                {
                    contactNumber = value;
                }
                 }
        }

        public Person(string firstName, string lastName)
        {
            //Console.WriteLine("Constaraktor1");
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName) // wywułuje construktor w kostruktorze
        {
            //Console.WriteLine("Constaraktor2");
            SetDateOfBirth(dateOfBirth);
            
        }
        public void SetDateOfBirth(DateTime date)
        {
            if(date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth!");
            }
            else
            {
                dayOfBirth = date;
            }
        }

        public DateTime GetDateOfBirth()
        {
            return dayOfBirth;
        }

        //public DateTime GetDateOfBirth() => dayOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi, I am {FirstName} {GetDateOfBirth()}");
        }
    }
}
