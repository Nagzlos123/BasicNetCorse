using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    class WordDocumentFile : File 
    {
        public override void Compres()
        {
            Console.WriteLine($"Compresing {FileName}");
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} priting ...");
        }
    }
}
