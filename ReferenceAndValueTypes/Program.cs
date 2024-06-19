using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    class Program
    {
        static bool TryParseToNegative(string input, out int result)
        {
            if (int.TryParse(input, out result))
            {
                if(result < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                result = default;
                return false;
            }
        }
        static bool IsDivisible(int value, int factor, out int reminder)
        {
            reminder = value % factor;
            return reminder == 0;
        }
        static void Double(ref int value)// ref pozwala operować na orginale a nie kopi wartości zmienej
        {
            value = 2 * value;
            Console.WriteLine($"Double value: {value}");
        }
        static void Main(string[] args)
        {
            int someValue = 5;
            Double(ref someValue);

            Console.WriteLine($"some value: {someValue}");

            int value = 5;
            int factor = 2;
            int reminder;

            if (IsDivisible(value, factor, out reminder))
            {
                Console.WriteLine($"{value} is divisible by {factor}");
            }
            else
            {
                Console.WriteLine($"{value} is not divisible by {factor}. Reminder: {reminder}");
            }

            //parscing negative value
            int inputValue;

            while(!TryParseToNegative(Console.ReadLine(), out inputValue))
            {
                Console.WriteLine($"Insert negative number:");
            }

            Console.WriteLine($"Inserted negative number = {inputValue}");

            int hoursePower1 = 350;
            int hoursePower2 = 350;

            bool valueTypeEquality = hoursePower1 == hoursePower2;

            Car car1 = new Car(hoursePower1);
            Car car2 = new Car(hoursePower2);

            bool referenceTypeEquality = car1.Equals(car2);

            Console.WriteLine($"valueTypeEquality: {valueTypeEquality} ");
            Console.WriteLine($"referenceTypeEquality: {referenceTypeEquality} ");

            Console.ReadLine();
        }
    }

    class ApiClient
    {
        private readonly string baseURL1 = "https://our-api-dev.com"; // readonly można zmieniać tylko z poziomu kostruktora klasy
        private const string getUserEndPiont = "/api/users"; // const nie można zmieniać
        private readonly HttpClient client = new HttpClient();

        public ApiClient(string baseurl)
        {
            baseURL1 = baseurl;
        }
        public void GetUserURL()
        {
            var getUserUrl = $"{baseURL1} {getUserEndPiont}";

            client.GetAsync(getUserUrl);
        }
    }
    class Car
    {
        public int HousePower { get; set; }
        public Car(int housePower)
        {
            HousePower = housePower;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType()) return false;

            Car carObj = (Car)obj;

            return this.HousePower == carObj.HousePower;
        }

        public static bool operator ==(Car left, Car right)
        {
            return Equals(left, right); 
        }

        public static bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }
    }
}
