using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms.Tests
{
    [TestClass()]
    public class SortAlgorithmsTests
    {
        private SortAlgorithms sortAlgos;

        [TestInitialize]
        public void Init()
        {
            sortAlgos = new SortAlgorithms();
        }

        [TestMethod()]
        public void BubbleSort_Test_1()
        {
            int[] nums = { 1, 3, 2 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.BubbleSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BubbleSort_Test_2()
        {
            int[] nums = { 1, 2, 7, 5, 4, 3, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.BubbleSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BubbleSort_Test_3()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.BubbleSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BubbleSort_Test_4()
        {
            int[] nums = { 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.BubbleSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinaryInsert_Test_1()
        {
            int[] nums = { 5, 6, 7 };
            int numToAdd = 4;
            int begin = 0;
            int end = 2;
            int expected = 0;
            int actual = sortAlgos.BinaryInsertIndex(nums, begin, end, numToAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinaryInsert_Test_2()
        {
            int[] nums = { 1, 3 };
            int numToAdd = 2;
            int begin = 0;
            int end = 1;
            int expected = 1;
            int actual = sortAlgos.BinaryInsertIndex(nums, begin, end, numToAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinaryInsert_Test_3()
        {
            int[] nums = { 1 };
            int numToAdd = 2;
            int begin = 0;
            int end = 0;
            int expected = 1;
            int actual = sortAlgos.BinaryInsertIndex(nums, begin, end, numToAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinaryInsert_Test_4()
        {
            int[] nums = { 2 };
            int numToAdd = 1;
            int begin = 0;
            int end = 0;
            int expected = 0;
            int actual = sortAlgos.BinaryInsertIndex(nums, begin, end, numToAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinaryInsert_Test_5()
        {
            int[] nums = { 2, 3 };
            int numToAdd = 1;
            int begin = 0;
            int end = 1;
            int expected = 0;
            int actual = sortAlgos.BinaryInsertIndex(nums, begin, end, numToAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinaryInsert_Test_6()
        {
            int[] nums = { 1, 2 };
            int numToAdd = 3;
            int begin = 0;
            int end = 1;
            int expected = 2;
            int actual = sortAlgos.BinaryInsertIndex(nums, begin, end, numToAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BinaryInsert_Test_7()
        {
            int[] nums = { 1, 1, 3, 3 };
            int numToAdd = 2;
            int begin = 0;
            int end = 3;
            int expected = 2;
            int actual = sortAlgos.BinaryInsertIndex(nums, begin, end, numToAdd);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InsertionSort_Test_1()
        {
            int[] nums = { 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.InsertionSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InsertionSort_Test_2()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.InsertionSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InsertionSort_Test_3()
        {
            int[] nums = { 1, 2, 7, 5, 4, 3, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.InsertionSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InsertionSort_Test_4()
        {
            int[] nums = { 1, 3, 2 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.InsertionSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SelectionSort_Test_1()
        {
            int[] nums = { 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.SelectionSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SelectionSort_Test_2()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.SelectionSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SelectionSort_Test_3()
        {
            int[] nums = { 1, 2, 7, 5, 4, 3, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = sortAlgos.SelectionSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SelectionSort_Test_4()
        {
            int[] nums = { 1, 3, 2 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.SelectionSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShellSort_Test_1()
        {
            int[] nums = { 1, 3, 2 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.ShellSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShellSort_Test_2()
        {
            int[] nums = { 4, 1, 8, 3, 7, 2, 5, 9, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] actual = sortAlgos.ShellSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShellSort_Test_3()
        {
            int[] nums = { 4, 1, 8, 3, 7, 2, 5, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = sortAlgos.ShellSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShellSort_Test_4()
        {
            int[] nums = { 4, 1, 8, 3, 7, 2, 5, 6, 12, 21, 32, 43, 54, 65, 76, 87, 98 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 12, 21, 32, 43, 54, 65, 76, 87, 98 };
            int[] actual = sortAlgos.ShellSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_1()
        {
            int[] nums = { 4, 1, 8, 3, 7, 2, 5, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_2()
        {
            int[] nums = { 1, 3, 2 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_3()
        {
            int[] nums = { 1, 2, 3 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_4()
        {
            int[] nums = { 3, 2, 1 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_5()
        {
            int[] nums = { 3, 1, 2 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_6()
        {
            int[] nums = { 2, 3, 1 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_7()
        {
            int[] nums = { 2, 1, 3 };
            int[] expected = { 1, 2, 3 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_8()
        {
            int[] nums = { 4, 1, 8, 3, 7, 2, 5, 6, 12, 21, 32, 43, 54, 65, 76, 87, 98 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 12, 21, 32, 43, 54, 65, 76, 87, 98 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_9()
        {
            int[] nums = { 7 };
            int[] expected = { 7 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_10()
        {
            int[] nums = { 8, 7 };
            int[] expected = { 7, 8 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void QuickSort_Test_11()
        {
            int[] nums = { 7, 8 };
            int[] expected = { 7, 8 };
            int[] actual = sortAlgos.QuickSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Merge_Test_1()
        {
            int[] left = { 7, 8};
            int[] right = { 6 };
            int[] expected = { 6, 7, 8 };
            int[] actual = sortAlgos.Merge(left, right);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Merge_Test_2()
        {
            int[] left = { 8 };
            int[] right = { 7 };
            int[] expected = { 7, 8 };
            int[] actual = sortAlgos.Merge(left, right);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Merge_Test_3()
        {
            int[] left = { 6 };
            int[] right = { 7, 8 };
            int[] expected = { 6, 7, 8 };
            int[] actual = sortAlgos.Merge(left, right);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Merge_Test_4()
        {
            int[] left = { 7 };
            int[] right = { 8 };
            int[] expected = { 7, 8 };
            int[] actual = sortAlgos.Merge(left, right);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeSort_Test_1()
        {
            int[] nums = { 8, 7, 6 };
            int[] expected = { 6, 7, 8 };
            int[] actual = sortAlgos.MergeSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeSort_Test_2()
        {
            int[] nums = { 7, 8, 6 };
            int[] expected = { 6, 7, 8 };
            int[] actual = sortAlgos.MergeSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeSort_Test_3()
        {
            int[] nums = { 6, 7, 8 };
            int[] expected = { 6, 7, 8 };
            int[] actual = sortAlgos.MergeSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeSort_Test_4()
        {
            int[] nums = { 8, 7 };
            int[] expected = { 7, 8 };
            int[] actual = sortAlgos.MergeSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeSort_Test_5()
        {
            int[] nums = { 7, 8 };
            int[] expected = { 7, 8 };
            int[] actual = sortAlgos.MergeSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeSort_Test_6()
        {
            int[] nums = { 4, 1, 8, 3, 7, 2, 5, 6, 12, 21, 32, 43, 54, 65, 76, 87, 98 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 12, 21, 32, 43, 54, 65, 76, 87, 98 };
            int[] actual = sortAlgos.MergeSort(nums);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}