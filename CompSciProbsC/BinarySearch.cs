using System.Collections.Generic;

namespace CompSciProbsC
{
    public class BinarySearch
    {
        public int IterSearcher(List<int> list, int key)
        {
            var low = 0;
            var high = list.Count;

            while (low < high)
            {
                var mid = (high + low) / 2;
                if (list[mid] < key) low = mid + 1;
                else if (list[mid] > key) high = mid - 1;
                else return mid;
            }
            return -1;
        }

        public int RecurSearcher(int[] list, int key)
        {
            if (list.Length == 0) return -1;
            var mid = list.Length / 2;
            if (list[mid] == key) return mid;
            if (key < list[mid]) return RecurSearcher(list[0..(mid - 1)], key);
            else return RecurSearcher(list[(mid + 1)..], key);
        }
    }
}