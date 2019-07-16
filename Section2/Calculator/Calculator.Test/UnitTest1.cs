using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Demo"), TestCategory("Calculator")]
        [TestProperty("Test Group", "Performance")]
        [Owner("Techonolgy")]
        [Priority(2)]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test Group", "Security")]
        [Owner("Techonolgy")]
        [Priority(2)]
        public void TestMethod2()
        {
        }
    }
}
