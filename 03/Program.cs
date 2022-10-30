using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack=new Stack<int>();
            while (true)
            {
                string[] str=Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (str[0] == "Push")
                {
                    if(str.Length > 1)
                    {
                        for (int i = 1; i < str.Length; i++)
                        {
                            stack.Push(Convert.ToInt32(str[i]));
                        }
                    }
                }else if(str[0] == "Pop")
                {
                    stack.Pop();
                }
                else { break; }
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var j in stack)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadLine();
        }
    }
}
