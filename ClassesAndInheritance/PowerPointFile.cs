using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    class PowerPointFile : File
    {
        public override void Compres()
        {
            Console.WriteLine($"Compresing {FileName}");
        }
        public void Presentation()
        {
            Console.WriteLine($"{FileName} presenting ...");
        }
    }
}
