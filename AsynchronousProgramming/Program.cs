namespace AsynchronousProgramming
{
    public class Program
    {
        static async Task FooAsync()
        {
            Console.WriteLine("Foo start");

            await Task.Delay(2000);

            throw new Exception();
            Console.WriteLine("Foo end");
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main started");

            try
            {
               await FooAsync();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception");
            }
            

            Console.ReadKey();
        }
    }
}
