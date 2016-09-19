using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

namespace QuickSort_UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod_CheckSortArrayWithSixElements()
        {
            int[] array = new int[] {20,-10,15,32,11,7 };
            int [] sortedArray=new int[] {-10,7,11,15,20,32};
            var qSort = new QuickSort<int>();
            qSort.quickSort(array, 0, array.Length-1);
            CollectionAssert.AreEqual(sortedArray,array);
        }

        [TestMethod]
        public void TestMethod_CheckSortArrayWithNullElements()
        {
            int[] array = new int[] {};
            int[] sortedArray = new int[] {};
            var qSort = new QuickSort<int>();
            qSort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(sortedArray, array); 
        }

        [TestMethod]
        public void TestMethod_CheckSortArrayWithNegativeElements()
        {
            int[] array = new int[] { -39, -100, -15, -1, -45, -29 };
            int[] sortedArray = new int[] { -100, -45, -39, -29, -15, -1 };
            var qSort = new QuickSort<int>();
            qSort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(sortedArray, array);
        }

        [TestMethod]
        public void TestMethod_CheckSortArrayWithCharElements()
        {
            char[] array = new char[] { 'b', 'a', 'd', 'c', 'f', 'e' };
            char[] sortedArray = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };
            var qSort = new QuickSort<char>();
            qSort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(sortedArray, array);
        }

        [TestMethod]
        public void TestMethod_CheckSortArrayWithStringElements()
        {
            string[] array = new string[] { "gdsjh", "euyiewr", "gsdjh", "true", "false", "skdkdj" };
            string[] sortedArray = new string[] { "euyiewr","false", "gdsjh", "gsdjh", "skdkdj", "true" };
            var qSort = new QuickSort<string>();
            qSort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(sortedArray, array);
        }

        [TestMethod]
        public void TestMethod_CheckSortArrayWithDoubleElements()
        {
            double[] array = new double[] { 2.35, 1.2, -0.5, 3.4, 2.1, 3.2 };
            double[] sortedArray = new double[] {-0.5, 1.2, 2.1, 2.35, 3.2, 3.4 };
            var qSort = new QuickSort<double>();
            qSort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(sortedArray, array);
        }

        [TestMethod]
        public void TestSpeed()
        {
            BenchmarkRunner.Run<BenchMark>();
        }
    }

    [Config("columns=Max")]
    public class BenchMark
    {
       [Benchmark(Description = "DefaultSorted")]
        public static void CallDefaultSort()
        {
            int[] array = new int[] { 20, -10, 15, 32, 11, 7 };
            var qSort = new QuickSort<int>();
            qSort.quickSort(array, 0, array.Length - 1);
        }

        [Benchmark(Description = "CustomSorted")]
        public static void CallOptimQuickSort()
        {
            int[] array = new int[] { 20, -10, 15, 32, 11, 7 };
            var qSort = new OptimQuickSort<int>();
            qSort.quickSort(array, 0, array.Length - 1);
        }
    }
}
