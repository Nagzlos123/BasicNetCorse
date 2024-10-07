using System.Reflection;

namespace ReflectionAndAttributes
{
    public class Program
    {
        static void Display(object obj)
        {
            Type type = obj.GetType();
            var propertes = type.GetProperties();

            foreach (var prop in propertes)
            {
                var probValue = prop.GetValue(obj);
                var propType = probValue.GetType();
                if (propType.IsPrimitive || propType == typeof(string)) // ther is no IsString property
                {
                    var displayProperty = prop.GetCustomAttribute<DisplayPropertyAttributes>();

                    if (displayProperty != null)
                    {
                        Console.WriteLine($"{displayProperty.DisplayName} : {probValue}");
                    }
                    else 
                    {
                        Console.WriteLine($"{prop.Name} : {probValue}");
                    }
                    
                }
            }
        }
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                City = "Staszów",
                Street = "Jana Pawła",
                PostCode = "28-200"
            };

            Person person = new Person()
            {
                FirstName = "Daniel",
                LastName = "Kowal",
                Address = address
            };

            Console.WriteLine("Person:");
            Display(person);

            Console.WriteLine("Address:");
            Display(address);

            Console.WriteLine("Insert property to update:");
            var propertyToUpdate = Console.ReadLine();

            Console.WriteLine("Insert new value:");
            var inputValue = Console.ReadLine();

            SetValue(person, propertyToUpdate, inputValue);
            Display(person);

        }

        static void SetValue<T>(T obj, string propName, string value)
        {
            Type objType = typeof(T);

            var propertyToUpdate = objType.GetProperty(propName);
            if (propertyToUpdate != null) 
            { 
                propertyToUpdate.SetValue(obj, value);
            }
        }
    }
}
