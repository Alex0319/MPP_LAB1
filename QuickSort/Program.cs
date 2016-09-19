using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfElements=5;
            if (args.Count() == 1 && int.TryParse(args[0], out countOfElements))
            {
                int[] array = new int[countOfElements];
                Random rand = new Random();
                var qSort = new QuickSort.QuickSort<int>();
                for (int i = 0; i < countOfElements;i++)
                    array[i] = rand.Next(-100, 100);
                qSort.quickSort(array, 0, countOfElements - 1);
                for (int i = 0; i < countOfElements; i++)
                    Console.Write("{0} ", array[i]);
            }
            Console.ReadLine();
        }
    }
}
