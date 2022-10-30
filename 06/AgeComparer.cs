using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class AgeComparer : IComparer<Person>
    {
        public int Compare(Person person1, Person person2)
        {
            int result = person1.Age.CompareTo(person2.Age);
            return result;
        }
    }
}
