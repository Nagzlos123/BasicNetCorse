using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndAttributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class DisplayPropertyAttributes : Attribute
    {
        public string DisplayName { get; set; }

        public DisplayPropertyAttributes(string name)
        {
            DisplayName = name;
        }
    }
}
