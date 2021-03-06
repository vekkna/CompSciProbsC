using System.Collections.Generic;

namespace CompSciProbsC
{
    public class Towers
    {
        private readonly int numDisks = 3;
        private readonly Stack<int> first = new Stack<int>();
        private readonly Stack<int> second = new Stack<int>();
        private readonly Stack<int> third = new Stack<int>();

        public Towers()
        {
            first.Push(3);
            first.Push(2);
            first.Push(1);
        }

    }
}
