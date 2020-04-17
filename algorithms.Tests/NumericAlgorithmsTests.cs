using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms.Tests
{
    [TestClass()]
    public class NumericAlgorithmsTests
    {
        [TestMethod()]
        public void reverse_test_1()
        {
            int input = 10;
            NumericAlgorithms algos = new NumericAlgorithms();
            int actual = algos.Reverse(input);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void reverse_test_2()
        {
            int input = 1001;
            NumericAlgorithms algos = new NumericAlgorithms();
            int actual = algos.Reverse(input);
            int expected = 1001;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void reverse_test_3()
        {
            int input = 1234;
            NumericAlgorithms algos = new NumericAlgorithms();
            int actual = algos.Reverse(input);
            int expected = 4321;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void reverse_test_4()
        {
            int input = 670045235;
            NumericAlgorithms algos = new NumericAlgorithms();
            int actual = algos.Reverse(input);
            int expected = 532540076;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void reverse_test_5()
        {
            int input = 0;
            NumericAlgorithms algos = new NumericAlgorithms();
            int actual = algos.Reverse(input);
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}