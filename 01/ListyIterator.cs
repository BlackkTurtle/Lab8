using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int index=1;

        public ListyIterator(IEnumerable<T> elements)
        {
            list = new List<T>(elements);
        }
        public bool HasNext => index + 1 < list.Count;

        public void Move()
        {
            if (!HasNext)
            {
                Console.WriteLine(false);
            }
            else
            {
                index++;
                Console.WriteLine(true);
            }
        }
        public void Print()
        {
            if (list.Count == 1)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in list)
            {
                if (Convert.ToString(element) == "Create")
                {

                }
                else
                {
                    yield return element;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
