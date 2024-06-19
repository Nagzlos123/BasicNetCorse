using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Drawo()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    class Circle : Shape
    {
        public override void Drawo()
        {
            Console.WriteLine("Drawing circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Drawo()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }

    class Triangle : Shape
    {
        public override void Drawo()
        {
            Console.WriteLine("Drawing triangle");
        }
    }
}
