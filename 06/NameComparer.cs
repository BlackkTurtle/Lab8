using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class NameComparer : IComparer<Person>
    {
        public int Compare(Person person1, Person person2)
        {
            int result = person1.Name.Length.CompareTo(person2.Name.Length);
            if (result == 0)
            {
                result = char.ToLower(person1.Name[0]).CompareTo(char.ToLower(person2.Name[0]));
            }
            return result;
        }
    }
}
