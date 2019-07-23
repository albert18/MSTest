using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Priority(1)]
        public void Divide_PositiveNumbers_ReturnsPositiveQuotient_1()
        {
            // Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            // Act
            int actual = Calculator.Divide(numerator, denominator);
            System.Threading.Thread.Sleep(1000);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Owner("Venkat")]
        [Priority(1)]
        public void Divide_PositiveNumeratorAndNegativeDenominator_ReturnsNegativeQuotient_2()
        {
            // Arrange
            int expected = -5;
            int numerator = 20;
            int denominator = -4;

            // Act
            int actual = Calculator.Divide(numerator, denominator);
            System.Threading.Thread.Sleep(400);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Performance")]
        [Owner("Venkat")]
        [Priority(1)]
        public void Divide_NegativeNumbers_ReturnsPositiveQuotient_3()
        {
            // Arrange
            int expected = -5;
            int numerator = -20;
            int denominator = -4;

            // Act
            int actual = Calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DenominatorIsZero_ThorwsDivideByZeroException_4()
        {
            // Arrange
            int numerator = 20;
            int denominator = 0;

            // Act
            try
            {
                Calculator.Divide(numerator, denominator);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Denominator cannot be ZERO", ex.Message);
                throw;
            }
        }

        [TestMethod]
        public void IsPositive_PositiveNumber_ReturnsTrue_5()
        {
            PrivateObject p = new PrivateObject(typeof(Calculator));
            bool actual = (bool)p.Invoke("IsPositive", -10);

            Assert.IsFalse(actual);
        }
    }
}