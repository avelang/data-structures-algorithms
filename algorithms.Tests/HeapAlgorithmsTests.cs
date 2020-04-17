using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms.Tests
{
    [TestClass()]
    public class HeapAlgorithmsTests
    {
        [TestMethod()]
        public void MaxHeapify_Test_1()
        {
            int[] array = { 10, 12, 15, 6, 9, 8, 7 };
            HeapAlgorithms hpAlgos = new HeapAlgorithms();
            int[] actual = hpAlgos.MaxHeapify(array,0);
            int[] expected = { 15, 12, 10, 6, 9, 8, 7 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxHeapify_Test_2()
        {
            int[] array = { 8, 12, 9 };
            HeapAlgorithms hpAlgos = new HeapAlgorithms();
            int[] actual = hpAlgos.MaxHeapify(array, 0);
            int[] expected = { 12, 8, 9 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxHeapify_Test_3()
        {
            int[] array = { 15, 6, 10, 9, 12, 8, 7 };
            HeapAlgorithms hpAlgos = new HeapAlgorithms();
            int[] actual = hpAlgos.MaxHeapify(array, 1);
            int[] expected = { 15, 12, 10, 9, 6, 8, 7 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxHeapify_Test_4()
        {
            int[] array = { 1,2,3 };
            HeapAlgorithms hpAlgos = new HeapAlgorithms();
            int[] actual = hpAlgos.MaxHeapify(array, 0);
            int[] expected = { 3,2,1};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxHeapify_Test_5()
        {
            int[] array = { 2, 1, 3 };
            HeapAlgorithms hpAlgos = new HeapAlgorithms();
            int[] actual = hpAlgos.MaxHeapify(array, 0);
            int[] expected = { 3, 1, 2 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}