using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Person : IComparable<Person>
    {
        public Person(string[]str)
        {
            Name = str[0];
            Age = Convert.ToInt32(str[1]);
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person other)
        {
            var result= GetHashCode().CompareTo(other.GetHashCode());
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return Name == other.Name && Age == other.Age;
            }
            return false;
        }
        public override int GetHashCode()
        {
            var result = Name.GetHashCode();
            return result;
        }
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
