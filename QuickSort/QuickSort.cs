using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    public class QuickSort
    {
        private QuickSortComparer<int> comparer;

        public QuickSort()
        {
            comparer = new QuickSortComparer<int>();
        }

        public void quickSort(int[] array,int minArrayIndex,int maxArrayIndex)
        {
            int temp;
            int x = array[minArrayIndex + (maxArrayIndex - minArrayIndex) / 2];
            int i = minArrayIndex;
            int j = maxArrayIndex;
            while (i <= j)
            {
                while (array[i] < x)
                    i++;
                while (array[j] > x)
                    j--;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < maxArrayIndex)
                quickSort(array, i, maxArrayIndex);
            if (minArrayIndex < j)
                quickSort(array, minArrayIndex, j);
         }
    }
}
