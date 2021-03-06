using System.Collections.Generic;

namespace CompSciProbsC
{
    public class Towers
    {
        public Stack<int> First { get; } = new Stack<int>();
        public Stack<int> Second {get; } = new Stack<int>();
        public Stack<int> Third { get; } = new Stack<int>();

        public Towers()
        {
            First.Push(1);
            First.Push(2);
            First.Push(3);
        }

        private void Move(Stack<int> begin, Stack<int> end, Stack<int> temp, int n)
        {
            if (n == 1) end.Push(begin.Pop());
            else
            {
                Move(begin, temp, end,n - 1);
                Move(begin, end, temp, 1);
                Move(temp, end, begin, n - 1);
            }
        }

        public void Solve()
        {
            Move(First, Third, Second, 3);   
        }
    }
}
