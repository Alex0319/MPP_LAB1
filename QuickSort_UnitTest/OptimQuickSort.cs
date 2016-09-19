using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class OptimQuickSort<T>
    {
        private QuickSortComparer<T> comparer;
        private QuickSortComparer<int> comparerInt;

        public OptimQuickSort()
        {
            comparer = new QuickSortComparer<T>();
            comparerInt = new QuickSortComparer<int>();
        }

        public void quickSort(T[] array, int minArrayIndex, int maxArrayIndex)
        {
            if (comparerInt.Compare(minArrayIndex, maxArrayIndex) > 0)
                return;
            T temp;
            T x = array[minArrayIndex + (maxArrayIndex - minArrayIndex) / 2];
            int i = minArrayIndex;
            int j = maxArrayIndex;
            while (comparerInt.Compare(i, j) <= 0)
            {
                while (comparer.Compare(array[i], x) < 0)
                    i++;
                while (comparer.Compare(array[j], x) > 0)
                    j--;
                if (comparerInt.Compare(i, j) <= 0)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (comparerInt.Compare(i, maxArrayIndex) < 0)
                quickSort(array, i, maxArrayIndex);
            if (comparerInt.Compare(minArrayIndex, j) < 0)
                quickSort(array, minArrayIndex, j);
        }
    }
}
