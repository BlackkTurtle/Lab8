using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Person
    {
        public Person(string[]str)
        {
            Name = str[0];
            Age = Convert.ToInt32(str[1]);
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return (Name+" "+ Age);
        }
    }
}
