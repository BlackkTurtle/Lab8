using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons=new List<Person>();
            while (true)
            {
                string[] str=Console.ReadLine().Split(' ');
                if (str[0] == "END")
                {
                    break;
                }
                persons.Add(new Person(str));
            }
            int n=int.Parse(Console.ReadLine());
            Person person = persons[n-1];
            int result = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (person.CompareTo(persons[i])==0)
                {
                    result++;
                }
            }
            if(result <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(result + " " + (persons.Count - result) + " " + persons.Count);
            }
            Console.ReadLine();
        }
    }
}
