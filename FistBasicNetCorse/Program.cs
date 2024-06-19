using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FistBasicNetCorse
{
    #region FistClassRegion
    class Program
    {
        static void Main(string[] args)
        {
            //Typy zmiennych
            DateTime now = DateTime.Now;
            DateTime dateOfBirth = new DateTime(1990, 7, 6);
            DateTime dateOfDeath = new DateTime(2038, 5, 11);
            byte byteNumber = 200;
            double doubleNumber = 1.5;
            float floatNumber = 1.5f;
            decimal decimalNumber = 1.5m;

            string text = "Hello";

            string interpoladed = $" {text} to you";
            string concatenated = string.Concat(text, "to", "me");
            string concatenated2 = text + "to" + "me";

            StringBuilder stringBuilder = new StringBuilder("This");
            stringBuilder.Append("is");
            stringBuilder.Append("a");
            stringBuilder.Append("long");
            stringBuilder.Append("text");

            string result = stringBuilder.ToString();
            Console.WriteLine(result);



            // condition operator - used in conditional assigmment if condition is true/false
            // (condition) ? x : y
            double temperature = 20;
            String massage;

            massage = (temperature >= 15) ? "Is warm outsite!" : "Is colde outsite!";

            Console.WriteLine(massage);

            //casting types
            byte byteNumber2 = 100;
            int intNumber2 = (byte)byteNumber2;
            double doubleNumber2 = 4.5;
            int intNumber3 = (int)doubleNumber2;
            string stringValue = intNumber2.ToString();

            string userInput = Console.ReadLine();
            int yearOfBirth;
            if (int.TryParse(userInput, out yearOfBirth))
            {

                int age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine($"You have {age} years!");
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }

            //Regex
            Regex regex = new Regex(@"^([a-z0-9]+)\.?([a-z0-9]+)@([a-z]+)\.[a-z]{2,3}$");
            string email = "test.test2@gimal.com";

            bool isMach = regex.IsMatch(email);
            Console.WriteLine(isMach);

            // metods for strings
            Console.WriteLine("Insert input:");
            string userInputString = Console.ReadLine();

            StringFunctions stringFunctions = new StringFunctions();

            //stringFunctions.SubString(userInputString);
            //stringFunctions.Raplace(userInputString);
            //stringFunctions.Modify(userInputString);
            //stringFunctions.AlterTextCase(userInputString);
            stringFunctions.Slit(userInputString);
            //stringFunctions.CheckString(userInputString);


            //kebab case 
            // some-variable-name
            //camel case
            // someVariable

            Console.WriteLine("Insert kebab case variable: ");
            string kebabCase = Console.ReadLine();

            Console.WriteLine(stringFunctions.KebabToCamelCase(kebabCase));

            Console.WriteLine("Insert camel case variable: ");
            string camelCase = Console.ReadLine();

            Console.WriteLine(stringFunctions.CamelToKebabCase(camelCase));


            // metods for Date Time oprerations

           

            DateTimeFunctions.DateTimeModifications();
            DateTimeFunctions.DateTimeFormating();
            DateTimeFunctions.TimeMeasurement();
            DateTimeFunctions.Helpers();

            bool isDateBetween = DateTimeFunctions.IsDateBetween(now, dateOfBirth, dateOfDeath);
            bool isDateBetween2 = now.IsBetween( dateOfBirth, dateOfDeath);


            Console.ReadLine();
        }


        #endregion
    }
}
