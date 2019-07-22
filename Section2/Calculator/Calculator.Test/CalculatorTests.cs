using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Priority(1)]
        public void Divide_PositiveNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            // Act
            int actual = Calculator.Divide(numerator, denominator);
            System.Threading.Thread.Sleep(1000);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Owner("Albert")]
        [Priority(1)]
        public void Divide_PositiveNumeratorAndNegativeDenominator_ReturnsNegativeQuotient()
        {
            // Arrange
            int expected = -5;
            int numerator = 20;
            int denominator = -4;

            // Act
            int actual = Calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Performance")]
        [Owner("Albert")]
        [Priority(1)]
        public void Divide_NegativeNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            int expected = 5;
            int numerator = -20;
            int denominator = -4;

            // Act
            int actual = Calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///// THROWING EXECEPTION
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DenominatorIsZero_ReturnsZero()
        {
            // Arrange
            int numerator = -20;
            int denominator = 0;

            // Act
            try
            {
                Calculator.Divide(numerator, denominator);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Denominator cannot be zero", ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Testing Private
        /// </summary>
        [TestMethod]
        public void IsPositive_PositiveNumber_ReturnsTrue()
        {
            //Use this if method is not static
            //PrivateObject p = new PrivateObject(typeof(Calculator));
            //bool actual = (bool)p.Invoke("isPositive", -10);

            PrivateType p = new PrivateType(typeof(Calculator));
            bool actual = (bool)p.InvokeStatic("isPositive", 10);

            Assert.IsTrue(actual);
        }

    }
}
