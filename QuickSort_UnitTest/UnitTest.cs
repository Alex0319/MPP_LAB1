﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;
using BenchmarkDotNet;
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

    }
    
    public class MyBenchmark
    {
        [Benchmark]
        public void Hello()
        {
 
        }
    }
}
