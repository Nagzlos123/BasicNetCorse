using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Program
    {
        public delegate void Display(string value);
        public delegate bool GenericPredicate<T>(T value);
        static void Main(string[] args)
        {
            var restaurant = new List<Restaurant>();

            var result = new PaginatedResult<Restaurant>();

            result.Results = restaurant;

            var user = new List<User>();

            //result.Results = user;


            //var stringRepository = new Repository<string>();

            //stringRepository.AddElemt("Some value");

            //string firstElement = stringRepository.GetElemet(0);


            var userRepository = new Repository<string, User>();

            userRepository.AddElemt("Bill", new User { Name = "Bill" });

            User bill = userRepository.GetElemet("Bill");


            int[] intNumbers = { 1, 2, 3 };

            Utils.Swap<int>(ref intNumbers[0], ref intNumbers[2]);

            Console.WriteLine(string.Join(",", intNumbers));

            Display display = (string value) => Console.Write(value + ",");
            display("text");

            var numbers = new int[] { 10, 20, 30 };

            //DisplayNumbers(numbers, display);

           var count = Count(numbers, (int value) => value > 15);
            Console.WriteLine(count);

            var strings = new string[] { "Bill", "Stu", "Harry" };
            var countString = Count(strings, value => value.Length > 3);
            Console.WriteLine($"countString: {countString}");

            Console.ReadLine();
        }

        static void DisplayNumbers(IEnumerable<int> numbers, Display display)
        {
            foreach (int number in numbers)
            {
                display(number.ToString());
            }
        }

        static int Count<T>(IEnumerable<T> elements, GenericPredicate<T> predicate)
        {
            int count = 0;

            foreach (T element in elements)
            {
                if (predicate(element))
                {
                    count++;
                }
            }

            return count;
        }

        static void WriteWithComa(string value)
        {
            Console.WriteLine(value + ",");
        }

    }
}
