using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Pet
    {
        public Pet(string[]str)
        {
            Name = str[2];
            Age = Convert.ToInt32(str[3]);
            Kind = str[4];
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }
        public override string ToString()
        {
            return Name+" "+Age+" "+Kind;
        }
    }
}
