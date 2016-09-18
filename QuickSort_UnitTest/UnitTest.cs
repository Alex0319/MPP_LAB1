using System;
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
            var qSort = new QuickSort.QuickSort();
            qSort.quickSort(array, 0, array.Length-1);
            CollectionAssert.AreEqual(sortedArray,array);
        }

        [TestMethod]
        public void TestMethod_CheckSortArrayWithNullElements()
        {
 
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
