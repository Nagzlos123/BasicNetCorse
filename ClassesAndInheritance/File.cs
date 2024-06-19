using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance
{
    abstract class File
    {
        //prop for faster creation of propertis
        public string FileName { get; set; }
        public int Size { get; set; }

        public DateTime CreateOn { get; set; }

        private string priveteProp { get; set; }

        protected string protectedProp { get; set; }

        public abstract void Compres();
        
    }
}
