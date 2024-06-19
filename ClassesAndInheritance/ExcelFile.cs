using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    class ExcelFile : File
    {
        public override void Compres()
        {
            Console.WriteLine($"Compresing {FileName}");
        }
        public void GenerateFileReport()
        {
            Console.WriteLine($"{FileName} report ...");
        }
    }
}
