using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year of birth?");

            string userInput = Console.ReadLine();

            

            int yearOfBirth = int.Parse(userInput);

            bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18;

            if (isUserOver18)
            {
                Console.WriteLine("Helo you are 18 years old");
            } else if(DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Today is Sunday");
            }
            else
            {
                Console.WriteLine("Helo you aren't 18 years old");
            }

            string[] cars = { "Volvo", "BMW", "Mazda" };

            int i = 0;
            while(i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                i++;
            }

            Console.WriteLine("To exit type 'x'");

            string userInput3;

            do
            {
                userInput3 = Console.ReadLine();
                Console.WriteLine($"Echo: {userInput3}");
            } while (userInput3 != "x");

            Console.WriteLine("What is your gender ? 1 - Male 2 - Female");
            string userInput4 = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput4);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("You aren't woman");
            }
            else
            {
                Console.WriteLine("You aren't male");
            }

            int? favoriteNumber = 23;
            Nullable<int> favoriteNumber2 = 14;

            Console.WriteLine("Favorite number: " + (favoriteNumber.HasValue ? favoriteNumber.Value.ToString() : ""));

            Console.ReadLine();
        }
    }
}
