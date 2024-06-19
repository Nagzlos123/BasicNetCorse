using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FistBasicNetCorse
{
    public class StringFunctions
    {
        public void SubString(string userInput)
        {
            if (userInput.Length > 10)
            {
                string startSubstring = userInput.Substring(0, 10);
                string endSubstring = userInput.Substring(userInput.Length - 10);
                Console.WriteLine($"{startSubstring}..., ...{endSubstring}");
                Console.WriteLine(startSubstring);
            }
        }

        public void Raplace(string userInput)
        {
            string tamplate = "Hello {name} how are you {name}?";
            string output = tamplate.Replace("{name}", userInput);
            Console.WriteLine(output);
        }

        public void Modify(string userInput)
        {
            string remoweString = userInput.Remove(5);
            string subString = userInput.Substring(5);
            string insertedString = userInput.Insert(2, "Insert");
            string trimString = userInput.Trim();

            Console.WriteLine($"remoweString: {remoweString}");
            Console.WriteLine($"subString: {subString}");
            Console.WriteLine($"insertedString: {insertedString}");
            Console.WriteLine($"trimString: {trimString}");
        }
        // Function alter text case
        public void AlterTextCase(string userInput)
        {
            string upperCased = userInput.ToUpper();
            string lowerCased = userInput.ToLower();

            Console.WriteLine($"upperCased: {upperCased}");
            Console.WriteLine($"lowerCased: {lowerCased}");
        }

        // Function is spliting string in to sepred parts
        public void Slit(string userInput)
        {
            string[] inputParts = userInput.Split(new char[] { ' ' });
            string firstName = inputParts[0];
            string lastName = inputParts[inputParts.Length - 1];
            Console.WriteLine($"FirstName: {firstName} LastName: {lastName}");
        }

        public void CheckString(string userInput)
        {
            bool isExitFile = userInput.EndsWith(".txt");
            bool startsWithDocPrefix = userInput.StartsWith("doc-");
            bool containsText = userInput.Contains("text");

            Console.WriteLine($"isExitFile: {isExitFile}");
            Console.WriteLine($"startsWithDocPrefix: {startsWithDocPrefix}");
            Console.WriteLine($"containsText: {containsText}");
        }

        public string KebabToCamelCase(string userInput)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < userInput.Length; i++)
            {
                char currentChar = userInput[i];

                if (currentChar != '-')
                {
                    stringBuilder.Append(currentChar);
                }
                else
                {
                    char nextChar = userInput[i + 1];
                    stringBuilder.Append(char.ToUpper(nextChar));
                    i++;
                }
            }

            return stringBuilder.ToString();
        }

        public string CamelToKebabCase(string userInput)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char currenChar in userInput)
            {
                if (char.IsUpper(currenChar))
                {
                    stringBuilder.Append("-");
                    stringBuilder.Append(char.ToLower(currenChar));
                }
                else
                {
                    stringBuilder.Append(currenChar);
                }


            }


            return stringBuilder.ToString();
        }
    }
}

