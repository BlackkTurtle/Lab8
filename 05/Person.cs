using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Person : IComparable<Person>
    {
        public Person(string[] str)
        {
            Name = str[0];
            Age = Convert.ToInt32(str[1]);
            Town = str[2];
        }
        public string Name { get; }
        public int Age { get; }
        public string Town { get; }
        public int CompareTo(Person person)
        {
            int result = Name.CompareTo(person.Name);
            if (result == 0)
            {
                result = Age.CompareTo(person.Age);
                if (result == 0)
                {
                    result = Town.CompareTo(person.Town);
                }
            }
            return result;
        }
    }
}
