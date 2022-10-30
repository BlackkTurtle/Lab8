using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strarray=Console.ReadLine().Split(' ');
            var listyIterator = new ListyIterator<string>(strarray);
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "Move")
                {
                    listyIterator.Move();
                }else if (str == "Print")
                {
                    listyIterator.Print();
                }else if (str == "HasNext")
                {
                    var a=listyIterator.HasNext;
                    Console.WriteLine(a);
                }else if (str == "PrintAll")
                {
                    var a=string.Join(" ", listyIterator);
                    Console.WriteLine(a);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
