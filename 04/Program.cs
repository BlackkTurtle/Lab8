using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] ints = Array.ConvertAll(input, int.Parse);
            Froggy froggy = new Froggy(ints);
            string result = string.Join(", ", froggy);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
