using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    class Program
    {

        static void DisplayElemets(List<int> list)
        {
            Console.WriteLine("*** List ***");

            foreach (int element in list)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            int arrayLenght = intArray.Length;

            List<int> intList = new List<int>() {3, 5, 67, 185, 78, 4, 16 };
            intList.Add(2);
            DisplayElemets(intList);

            Console.WriteLine("New element:");
            string userInput = Console.ReadLine();
            int intValue = int.Parse(userInput);
            intList.Add(intValue);

            DisplayElemets(intList);
           

            Console.WriteLine("Remove range");
            intList.RemoveRange(1, 2);
            DisplayElemets(intList);

            Console.WriteLine("Sort");
            intList.Sort();
            DisplayElemets(intList);
            Console.ReadLine();
        }
    }
}
