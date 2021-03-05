using System.Collections.Generic;

namespace CompSciProbsC
{
    public class Fibonacci
    {
        private Dictionary<int, int> fibMemo = new Dictionary<int, int>();

        public Fibonacci()
        {
            fibMemo.Add(0, 0);
            fibMemo.Add(1, 1);
        }

        public int FibRec(int n)
        {
            return n <= 1 ? n : FibRec(n - 1) + FibRec(n - 2);
        }

        public int FibRecMemo(int n)
        {
            if (!fibMemo.ContainsKey(n)) fibMemo.Add(n, FibRecMemo(n - 1) + FibRecMemo((n - 2)));
            return fibMemo[n];
        }

        public int FibIter(int n)
        {
            int last = 0, next = 1;
            for (int i = 0; i < n; i++)
                (last, next) = (next, next + last);
            return last;
        }
    }
}