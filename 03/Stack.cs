using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] array=new T[0];
        private int index = 0;
        public void Push(T element)
        {
            Array.Resize(ref array, index+1);
            array[index]=element;
            index++;
        }
        public void Pop()
        {
            if (array.Length==0)
            {
                Console.WriteLine("No Elements");
            }
            else
            {
                T[] newArray = array.Take(array.Length - 1).ToArray();
                array = newArray;
                index--;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (var i = index - 1; i >= 0; i--)
            {
                yield return array[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
