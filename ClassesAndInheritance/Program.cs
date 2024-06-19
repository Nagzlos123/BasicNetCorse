using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesAndInheritance
{
    class Program
    {
        public static IEnumerable<int> GetYeldData()
        {
            for (int i = 0; i <= 9; i++)
            {
                // yield zwracza część kolekcji
                yield return i;
                if(i % 3 == 0)
                {
                    yield break;
                }
            }

        }

        public static IEnumerable<int> GetData()
        {
            var result = new List<int>();
            for (int i = 0; i <= 9; i++)
            {
                result.Add(i);
            }
            return result;
        }

        static Dictionary<string, Currency> GetCurrencies()
        {
            return new Dictionary<string, Currency>
            {
                {"usd", new Currency("usd", "United States Dollar", 1) },
                {"eur", new Currency("eur", "Euro", 0.83975) },
                { "gpb", new Currency("gpb", "British Pound", 0.74771) },
                { "cad", new Currency("cad", "Canadian Dollar", 1.30724) },
                { "inr", new Currency("inr", "Indian Rupee", 73.04) },
                { "mxn", new Currency("mxn", "Mexican Peso", 21.7571) },
            };

            
        }

        static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>()
            {
                new Person(new DateTime(1989, 7, 22), "Bill", "Shithead"),
                new Person(new DateTime(1981, 8, 5), "Will", "Assgiver"),
                new Person(new DateTime(1975, 10, 18), "Ed", "Willbreaker"),
                new Person(new DateTime(1999, 5, 27), "Jhon", "Wick"),
                new Person(new DateTime(2007, 1, 2), "Troy", "Smith"),
                new Person(new DateTime(2005, 2, 14), "May", "Parker"),

            };
            return employees;
        }
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Shithead");


            bill.SetDateOfBirth(new DateTime(1998, 2, 22));

            //Console.WriteLine($"{bill.FirstName} {bill.GetDateOfBirth()}");
            bill.SayHi();


            Person john = new Person(new DateTime(1990, 1, 20), "John", "Hellinass");

            john.SayHi();
            john.ContactNumber = "999888777";
            john.DayOfBirth = new DateTime(1992, 12, 17);

            Console.WriteLine(john.ContactNumber);
            Console.WriteLine(john.DayOfBirth);
            john.SayHi();

            Console.WriteLine($"Objects of Rerson type count: {Person.Count}");

            ExcelFile excelFile = new ExcelFile();
            excelFile.FileName = "excel-file";
            excelFile.CreateOn = DateTime.Now;
            excelFile.GenerateFileReport();

            WordDocumentFile wordDocumentFile = new WordDocumentFile();
            wordDocumentFile.FileName = "word-document-file";
            wordDocumentFile.CreateOn = DateTime.Now;
            wordDocumentFile.Print();

            Shape[] shapes = { new Circle(), new Rectangle(), new Triangle(), };

            foreach (Shape shape in shapes)
            {
                shape.Drawo();
            }


            List<Person> employees = GetEmployees();
            /*
            bool EmployeeIsYoung(Person employee)
            {
                return employee.GetDateOfBirth() > new DateTime(2000, 1, 1);
            }
        */
        List<Person> youngEnployees = employees.Where(e => e.GetDateOfBirth() > new DateTime(2000, 1, 1)).ToList();
            /*
             List<Person> youngEnployees = new List<Person>();
            foreach (Person employe in employees)
            {
                if (employe.GetDateOfBirth() > new DateTime(2000, 1, 1))
                {
                    youngEnployees.Add(employe);
                }
            }
            */
            /*
            bool EmployeeIsMay(Person employee)
            {
                return employee.FirstName == "May";
            }
            */
            Console.WriteLine($"Young employees count: {youngEnployees.Count}");
            Person may = youngEnployees.FirstOrDefault(e => e.FirstName == "May");
            /*
            Person may = null;
            foreach (Person youngEmployee in youngEnployees)
            {
                if (youngEmployee.FirstName == "May")
                {
                    may = youngEmployee;
                    break;
                }

            }
            */
            if (may != null)
            {
                may.SayHi();
            }
            else
            {
                Console.WriteLine("May not found!");
            }


           Dictionary<string, Currency> currencies = GetCurrencies();
            Console.WriteLine("Check rate for: ");
            string userInput = Console.ReadLine();

            Currency selectedCurrency = null;

            if(currencies.TryGetValue(userInput, out selectedCurrency))
            {
                Console.WriteLine($"Rate for USD to {selectedCurrency.FullName} is {selectedCurrency.Rate}");
            }
            else
            {
                Console.WriteLine("Currency not found!");
            }

            currencies.Remove("usd");
            currencies.Add("usd", new Currency("usd", "Dollar", 1));

            var yieldGata = GetYeldData();

            foreach (int element in yieldGata)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

        }

    }
}
