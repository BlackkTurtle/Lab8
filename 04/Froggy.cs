using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Froggy : IEnumerable<int>
    {
        private int[] ints;
        public Froggy(IEnumerable<int> stones)
        {
            ints = stones.ToArray();
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < ints.Length; i += 2)
            {
                yield return ints[i];
            }
            for (int i = ints.Length - (ints.Length % 2 == 0 ? 1 : 2); i > 0; i -= 2)
            {
                yield return ints[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
