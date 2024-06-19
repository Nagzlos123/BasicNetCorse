using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FileHandling
{
    class Program
    {
        // metod is adding text to all files in the folder
        static void ScanAndAppend()
        {
           string[] files = Directory.GetFiles("C:/Users/Media/Desktop/Files", "*.txt", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                File.AppendAllText(file, "All rights reserved!");
            }
        }
        // metod is prenting up contents of files in the console
        static void ReadFiles()
        {
            var file1 = File.ReadAllText(@"C:\Users\Media\Desktop\Files\File1.txt");
            var file2 = File.ReadAllLines(@"C:\Users\Media\Desktop\Files\File2.txt");
            var file2String = string.Join(Environment.NewLine, file2);// Environment.NewLine dla wszystkich systemów opracyjnych

            Console.WriteLine("File 1");
            Console.WriteLine(file1);

            Console.WriteLine("File 2");
            Console.WriteLine(file2String);
        }
        //funtion is genereting file base on template and input data from user
        static void GenerateDocument()
        {
            Console.WriteLine("Insert name:");
            var name = Console.ReadLine();

            Console.WriteLine("Insert orderNumber:");
            var orderNumber = Console.ReadLine();

            var template = File.ReadAllText(@"C:\Users\Media\Desktop\Files\Template.txt");
            var document = template.Replace("{name}", name)
                .Replace("{orderNumber}", orderNumber)
                .Replace("{dateTime}", DateTime.Now.ToString());

            File.WriteAllText($"C:/Users/Media/Desktop/Files/document-{name}.txt", document);
        }
        //Operations on json format
        static void SaveToJson()
        {
            Player player = new Player()
            {
                Name = "Mario",
                Level = 1,
                HealthPoints = 100,
                Statistics = new List<Statistics>()
                {
                    new Statistics()
                    {
                        Name = "Strenght",
                        Points = 10,
                    },
                    new Statistics()
                    {
                        Name = "Intelligence",
                        Points = 10,
                    }

                }

            };

            player.Level++;

            string playerSerialised = JsonConvert.SerializeObject(player);

            File.WriteAllText(@"C:\Users\Media\Desktop\Files\JSON\playerSerialised.json", playerSerialised);

        }

        static void LoadToJson()
        {
            string playerSerialised = File.ReadAllText(@"C:\Users\Media\Desktop\Files\JSON\playerSerialised.json");
            Player player = JsonConvert.DeserializeObject<Player>(playerSerialised);
            Console.WriteLine(player.Name);
        }
        static void Main(string[] args)
        {
            //ReadFiles();
            //GenerateDocument();
            //ScanAndAppend();

            //SaveToJson();
            //LoadToJson();

            var filePath = "@\"C:\\Users\\Media\\Desktop\\Files\\JSON\\textFile.txt";
            var fileContent = File.ReadAllText(filePath);


            using(var someClass = new SomeClass())
            {
                someClass.Say("Hello");
            }

            using (var readFileStream = new FileStream(filePath, FileMode.Open))
            {
                //readFileStream.Read();
            }

            var writeFileStream = new FileStream(filePath, FileMode.Open);
            try
            {
                //writeFileStream.Read();
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            { 
                
            writeFileStream.Dispose(); 
            }
           Console.ReadLine();
        }
    }
}
