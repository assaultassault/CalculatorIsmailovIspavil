using CalculatorIsmailov.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorIsmailov.Tests
{
    [TestClass]
    public class Class1Tests
    {
        private Class1 calc = new Class1();

        [TestMethod]
        public void Add_Test()
        {
            double result = calc.Add(5, 5);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Subtract_Test()
        {
            double result = calc.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Multiply_Test()
        {
            double result = calc.Multiply(5, 5);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void Divide_Test()
        {
            double result = calc.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_By_Zero_Test()
        {
            calc.Divide(5, 0);
        }

        [TestMethod]
        public void Power_Test()
        {
            double result = calc.Power(2, 3);
            Assert.AreEqual(8, result);
        }
    }
}