using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class SomeClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing some class!");
        }

        internal void Say(string input)
        {
            Console.Write(input);
        }
    }
}
