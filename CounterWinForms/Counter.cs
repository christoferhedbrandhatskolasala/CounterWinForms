using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterWinForms
{
    internal class Counter
    {
        int count = 0;

        public Counter(int start)
        {
            count = start;
        }

        // ökar räknaren med ett
        public void Increment()
        {
            count++; // samma som count = count + 1;
        }

        // återställer värdet till noll
        public void Reset()
        {
            count = 0;
        }

        // ger värdet på räknaren
        public int GetValue()
        {
            return count;
        }
    }
}
