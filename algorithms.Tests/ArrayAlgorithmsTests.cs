using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms.Tests
{
    [TestClass()]
    public class ArrayAlgorithmsTests
    {
        public ArrayAlgorithms arrayAlgo;

        [TestInitialize]
        public void Init()
        {
            arrayAlgo = new ArrayAlgorithms();
        }
        [TestMethod()]
        public void Merge_Test_1()
        {
            int[] a = { 1, 2 };
            int[] b = { 3, 4 };
            int[] expected = { 1, 2, 3, 4 };
            int[] actual = arrayAlgo.Merge(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Merge_Test_2()
        {
            int[] a = { 1, 3 };
            int[] b = { 2, 4 };
            int[] expected = { 1, 2, 3, 4 };
            int[] actual = arrayAlgo.Merge(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Merge_Test_3()
        {
            int[] a = { 1, 3, 4 };
            int[] b = { 2, 4 };
            int[] expected = { 1, 2, 3, 4, 4 };
            int[] actual = arrayAlgo.Merge(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Merge_Test_4()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = arrayAlgo.Merge(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}