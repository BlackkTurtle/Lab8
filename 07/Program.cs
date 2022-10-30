using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            var personsHash=new HashSet<Person>();
            var personsSorted=new SortedSet<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] str=Console.ReadLine().Split(' ');
                personsHash.Add(new Person(str));
                personsSorted.Add(new Person(str));
            }
            Console.WriteLine(personsHash.Count);
            Console.WriteLine(personsSorted.Count);
            Console.ReadLine();
        }
    }
}
