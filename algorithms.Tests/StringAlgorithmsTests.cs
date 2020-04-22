using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms.Tests
{
    [TestClass()]
    public class StringAlgorithmsTests
    {
        public StringAlgorithms strAlgo;

        [TestInitialize]
        public void Init()
        {
            strAlgo = new StringAlgorithms();
        }
        [TestMethod()]
        public void isValidParanthesis_Test_1()
        {
            string inputString = "{}{}[]()[]{}{}";
            Assert.IsTrue(strAlgo.isValidParanthesis(inputString));
        }

        [TestMethod()]
        public void isValidParanthesis_Test_2()
        {
            string inputString = "{[()()][]}";
            Assert.IsTrue(strAlgo.isValidParanthesis(inputString));
        }

        [TestMethod()]
        public void isValidParanthesis_Test_3()
        {
            string inputString = "{}{}[]()[]{}}{}";
            Assert.IsFalse(strAlgo.isValidParanthesis(inputString));
        }

        [TestMethod()]
        public void isValidParanthesis_Test_4()
        {
            string inputString = "{[()()][]}}";
            Assert.IsFalse(strAlgo.isValidParanthesis(inputString));
        }
        [TestMethod()]
        public void isValidParanthesis_Test_5()
        {
            string inputString = "{}{}[]()[]{}{{}";
            Assert.IsFalse(strAlgo.isValidParanthesis(inputString));
        }

        [TestMethod()]
        public void isValidParanthesis_Test_6()
        {
            string inputString = "{[()()][]}[";
            Assert.IsFalse(strAlgo.isValidParanthesis(inputString));
        }
    }
}