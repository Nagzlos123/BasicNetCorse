using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndAttributes
{
    //[DisplayPropertyAttributes("Text")]
    public class Person
    {
        [DisplayPropertyAttributes("Fist Name")]
        public string FirstName { get; set; }

        [DisplayPropertyAttributes("Last Name")]
        //[DisplayPropertyAttributes("Last Name2")]
        public string LastName { get; set; }

        public Address Address { get; set; }
        /*
        public void Work([DisplayPropertyAttributes("time")] string time)
        {

        }
        */
    }
}
