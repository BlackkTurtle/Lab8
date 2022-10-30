using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            var persons=new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] str=Console.ReadLine().Split(' ');
                persons.Add(new Person(str));
            }
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - 1; j++)
                {
                    if (persons[j].Name.CompareTo(persons[j+1].Name)>0)
                    {
                        var temp = persons[j + 1];
                        persons[j + 1] = persons[j];
                        persons[j] = temp;
                    }
                }
            }
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.Count - 1; j++)
                {
                    if (persons[j].Age.CompareTo(persons[j + 1].Age) <0)
                    {
                        var temp = persons[j + 1];
                        persons[j + 1] = persons[j];
                        persons[j] = temp;
                    }
                }
            }
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadLine();
        }
    }
}
