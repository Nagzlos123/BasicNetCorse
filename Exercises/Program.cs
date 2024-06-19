using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercises
{
    // zadanie 1
    public class GradeCalculator
    {
        public static string CalculateGrade(double percentage)
        {
            // przykładowy rezultat - zwracana jest ocena A
            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80 && percentage <= 89)
            {
                return "B";
            }
            else if (percentage >= 70 && percentage <= 79)
            {
                return "C";
            }
            else if (percentage >= 60 && percentage <= 69)
            {
                return "D";
            }
            else
            {
                return "F";
            }

            //return "F";

        }
    }
    //zadanie 2
    public class ParkingCalculator
    {
        public static double CalculateParkingFee(int hours)
        {
            double result = 0;
            double fee = 5;
            // TODO: Uzupełnij implementację kalkulatora opłat za parkowanie

            switch (hours)
            {
                case 1:
                    result = fee;
                    break;
                default:
                    result = fee + (hours - 1) * 3.0;

                    break;
            }

            return result;
        }
    }

    //zadanie 3 
    public class BMICalculator
    {
        public static string BodyMassIndexCalculate(int mass, double height)
        {
            double BMI = (double)mass / (height * height);

            Console.WriteLine($"Twoja wartość BMI wynosi: {BMI}");
            if (BMI < 18.5)
            {
                return "NIEDOWAGA";

            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                return "WAGA NORMALNA";

            }
            else if (BMI >= 24.9 && BMI <= 29.9)
            {
                return "NADWAGA";

            }
            else if (BMI >= 29.9 && BMI <= 34.9)
            {
                return "OTYŁOŚĆ";
            }
            else
            {
                return "OTYŁOŚĆ OLBRZYMIA";
            }
        }
    }

    // zadanie 4
    public class TemperatureAnalyzer
    {
        // Znajduje najwyższą temperaturę w tablicy temperatur
        public static int FindHighestTemperature(int[] temperatures)
        {
            // TODO: Uzupełnij implementację, znajdując najwyższą temperaturę
            // wśród wszystkich temperatur w tablicy.
            // Zwróć wartość najwyższej temperatury.

            int maxElement = temperatures[0];

            foreach (int temperature in temperatures)
            {
                if (temperature > maxElement)
                {
                    maxElement = temperature;
                }
            }
            return maxElement;

        }

        // Znajduje najniższą temperaturę w tablicy temperatur
        public static int FindLowestTemperature(int[] temperatures)
        {
            // TODO: Uzupełnij implementację, znajdując najniższą temperaturę
            // wśród wszystkich temperatur w tablicy.
            // Zwróć wartość najniższej temperatury.


            int minElement = temperatures[0];

            foreach (int temperature in temperatures)
            {
                if (temperature < minElement)
                {
                    minElement = temperature;
                }
            }
            return minElement;
        }
    }
    // zadanie 5
    //Iterowanie po danych wejściowych
    public class SumNumbers
    {
        public static int SumAllNumbers(List<int> numbersList)
        {
            int sum = 0;
            foreach (int number in numbersList)
            {
                sum = +number;
            }
            return sum;

        }
        public static int FindHighestNumber(List<int> numbersList)
        {
            int maxElement = numbersList.Max();

            return maxElement;
        }
    }

    // zadanie 6
    //A function that takes the user's date of birth and, based on it,
    //calculates how many days have passed since that date to the current day.
    public class DateParsing
    {
        public static int CalculateNumberOfDays(int year, int month, int day)
        {
            DateTime now = DateTime.Now;
            DateTime typedDate = new DateTime(year, month, day);

            TimeSpan timeSpan = now - typedDate;
            int numberOfDays = (int)timeSpan.TotalDays;


            return numberOfDays;

        }
    }


    // zadanie 7
    //Inheritance
    public abstract class Vehicle
    {
        // TODO: zdefiniuj wspólne części klas pochodnych
        public string Model { get; set; }

        public abstract void Start();
        public abstract void Stop();
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the car: {Model}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stopping the car: {Model}");
        }

    }

    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the motorcycle: {Model}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Stopping the motorcycle: {Model}");
        }
    }
    // zadanie 8
    //Interfaces

    public interface IShape
    {
        // TODO: Zadeklaruj metody CalculateArea i CalculatePerimeter w interfejsie IShape.

        void CalculateArea();
        void CalculatePerimeter();


    }

    public class Square : IShape
    {
        // TODO: Uzupełnij implementację klasy Square, aby implementowała interfejs IShape
        // i posiadała pola, konstruktor(y) oraz implementacje metod CalculateArea i CalculatePerimeter.
        private double area;
        private double perimeter;
        private double side;

        public Square(double side)
        {
            this.side = side;
        }
        public void CalculateArea()
        {


            area = Math.Pow(side, 2);



            Console.WriteLine($"Square area is : {area}");
        }

        public void CalculatePerimeter()
        {
            perimeter = 4 * side;

            Console.WriteLine($"Square perimeter is : {perimeter}");
        }

        public class Circle : IShape
        {

            private double area;
            private double perimeter;
            private double radius;
            // TODO: Uzupełnij implementację klasy Circle, aby implementowała interfejs IShape
            // i posiadała pola, konstruktor(y) oraz implementacje metod CalculateArea i CalculatePerimeter.

            public Circle( double radius)
            {
                this.radius = radius;
            }
            public void CalculateArea()
            {
                area = Math.PI * radius * radius;
               Console.WriteLine($"Circle area is : {area}");
            }

            public void CalculatePerimeter()
            {
                perimeter = 2 * Math.PI * radius; 
                Console.WriteLine($"Circle perimeter is : {perimeter}");
            }
        }

        // zadanie 9
        //task list management program
        public class TaskManager
        {
            private List<string> tasks = new List<string>();

            public void AddTask(string task)
            {
                // TODO: Uzupełnij implementację metody AddTask, aby dodawała nowe zadanie do listy.
                tasks.Add(task);
            }

            public void RemoveTask(string task)
            {
                // TODO: Uzupełnij implementację metody RemoveTask, aby usuwała zadanie z listy, jeśli istnieje.
                if (tasks.Contains(task))
                {
                    tasks.Remove(task);
                }
                
            }

            public List<string> GetTasks()
            {

                return tasks;
            }
        }

        // zadanie 10
        public class GradeManager
        {
            private Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();
            public void AddGrade(string studentName, int grade)
            {
                // TODO: Uzupełnij implementację metody AddGrade, aby dodawała nową ocenę do listy ocen ucznia.
                if (!grades.ContainsKey(studentName))
                {
                    grades[studentName] = new List<int>();
                }
                grades[studentName].Add(grade);
            }

            public void RemoveGrade(string studentName, int grade)
            {
                // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.
                if (grades.ContainsKey(studentName))
                {
                    grades[studentName].Remove(grade);
                }
            }

            public double CalculateAverageGrade(string studentName)
            {
                // TODO: Uzupełnij implementację metody CalculateAverageGrade, aby obliczała średnią ocen ucznia, jeśli istnieją oceny.
                if(grades.ContainsKey(studentName) && grades[studentName].Count > 0)
                {
                    return grades[studentName].Average();
                }
                return 0.0;
            }
        }
        // zadanie 11
        public class EvenNumberGenerator
        {
            public static IEnumerable<int> GenerateEvenNumbers()
            {
                for (int i = 0; i <= 40; i++)
                {
                    var result = i % 2 ;
                    if(result == 0)
                    {
                        yield return i;
                    }
                    
                }
                // TODO: Uzupełnij implementację metody GenerateEvenNumbers, używając konstrukcji yield,
                // aby generować kolejne liczby parzyste.
            }
        }
        //zadanie 12
        // Temperature conversion a program that will convert temperature from one scale (e.g. Celsius) to another scale (e.g. Fahrenheit)
        public class TemperatureConverter
        {
            public void ConvertCelsiusToFahrenheit(double celsius, out double fahrenheit)
            {
                // todo
                fahrenheit = (celsius * 9 / 5) + 32;

                
            }

            public void ConvertFahrenheitToCelsius(double fahrenheit, ref double celsius)
            {
                // todo
                celsius = (fahrenheit - 32) * 5 / 9; 
            }
        }
        // zadanie 13

        public class StringUtils
        {
            public string ReverseString(string input)
            {
                // TODO: Uzupełnij implementację metody ReverseString,
                // aby zwracała odwrócony łańcuch znaków.

                string reverseString = string.Join("", input.ToCharArray().Reverse());

                return reverseString;
            }

            public int CountOccurrences(string input, string fragment)
            {
                // TODO: Uzupełnij implementację metody CountOccurrences,
                // aby zwracała liczbę wystąpień fragmentu w łańcuchu.
                int count = 0;
                int index = 0;
                while((index = input.IndexOf(fragment, index)) != -1)
                {
                    index += fragment.Length;
                    count++;
                }
             
                return count;
            }

            public string RemoveWhitespace(string input)
            {
                // TODO: Uzupełnij implementację metody RemoveWhitespace,
                // aby zwracała łańcuch bez zbędnych białych znaków.


                return Regex.Replace(input, @"\s+", "");
                
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // zadanie 1

                //string resultGradeCalculator = GradeCalculator.CalculateGrade(6);
                //Console.WriteLine(resultGradeCalculator);

                //zadanie 2

                //double resultParkingCalculator = ParkingCalculator.CalculateParkingFee(2);
                //Console.WriteLine(resultParkingCalculator + " zł");

                // zadanie 3
                /*
                Console.WriteLine("This is BMI calculator");

                Console.WriteLine("What is your mass (Kg):");
                string userInputMass = Console.ReadLine();

                int mass;

                if (int.TryParse(userInputMass, out mass) )
                {


                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }


                Console.WriteLine("What is your height (m):");
                double height = Double.Parse(Console.ReadLine());
                string resultBMICalculator = BMICalculator.BodyMassIndexCalculate(mass, height);
                Console.WriteLine(resultBMICalculator);
                */
                // zadanie 4

                int[] temperatures = { 10, 15, 8, 9, 4, 35, 14, 22 };

                int resultFindHighestTemperature = TemperatureAnalyzer.FindHighestTemperature(temperatures);
                Console.WriteLine($"The highest temperature is {resultFindHighestTemperature}");

                int resultFindLowestTemperature = TemperatureAnalyzer.FindLowestTemperature(temperatures);
                Console.WriteLine($"The lowest temperature is {resultFindLowestTemperature}");

                // zadanie 5

                Console.WriteLine("To exit type '0'");

                Console.WriteLine("Type number: ");
                int userInput = int.Parse(Console.ReadLine());
                int sum = 0;
                int? maxNumber = null;
                while (userInput != 0)
                {
                    if (maxNumber == null || userInput > maxNumber)
                    {
                        maxNumber = userInput;
                    }
                    sum += userInput;

                    userInput = int.Parse(Console.ReadLine());

                }

                //int resultSumAllNumbers = SumNumbers.SumAllNumbers(NumbersList);
                Console.WriteLine($"Sum of all numbers: {sum}");

                Console.WriteLine($"Highest number: {maxNumber}");

                // zadanie 6
                Console.WriteLine("Type date of birth (dd.mm.yyyy): ");

                Console.WriteLine("Type year: ");
                int userInputYear = int.Parse(Console.ReadLine());

                Console.WriteLine("Type month: ");
                int userInputMonth = int.Parse(Console.ReadLine());

                Console.WriteLine("Type day: ");
                int userInputDay = int.Parse(Console.ReadLine());

                int resultDateParsing = DateParsing.CalculateNumberOfDays(userInputYear, userInputMonth, userInputDay);
                Console.WriteLine($"You where born {resultDateParsing} days ago");
                //Console.WriteLine(resultDateParsing);

                // zadanie 8

                Console.WriteLine("Type side length : ");
                double userInputSide = double.Parse(Console.ReadLine());
                Square square = new Square(userInputSide);
                square.CalculateArea();
                square.CalculatePerimeter();
                
                Console.WriteLine("Type radius length : ");
                double userInputRadius = double.Parse(Console.ReadLine());
                Circle circle = new Circle(userInputRadius);
                circle.CalculateArea();
                circle.CalculatePerimeter();
                // zadanie 9

                // zadanie 10

                // zadanie 11
                //int resultFindLowestTemperature
                var generateNumbers = EvenNumberGenerator.GenerateEvenNumbers();
                foreach (int element in generateNumbers)
                {
                    Console.WriteLine(element);
                }

                //zadanie 12
                TemperatureConverter temperatureConverter = new TemperatureConverter();
                double fahrenheit;
                double celsius = 2;
                Console.WriteLine($"Type celsius to convert");
                double userInputCelsius = double.Parse(Console.ReadLine());

                temperatureConverter.ConvertCelsiusToFahrenheit(userInputCelsius, out fahrenheit);
                Console.WriteLine($"Temperature convetion from {userInputCelsius} C' to {fahrenheit} F' ");

                Console.WriteLine($"Type fahrenheit to convert");
                double userInputfahrenheit = double.Parse(Console.ReadLine());

                temperatureConverter.ConvertFahrenheitToCelsius(fahrenheit, ref celsius);
                Console.WriteLine($"Temperature convetion from {userInputfahrenheit} F' to {celsius} C' ");


                // zadanie 13
                StringUtils stringUtils = new StringUtils();
                Console.WriteLine("Type string input:");

                string input = Console.ReadLine();
                string fragment = "This is";

                var resultReverseString = stringUtils.ReverseString(input).ToString();

                Console.WriteLine($"This is revered string: {resultReverseString} ");

                Console.ReadLine();
            }
        }
    }
}
