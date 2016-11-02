using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestSample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSample.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        int firstNumber = 10;
        int secondNumber = 20;
        int expectNumber = 0;
        int actualNumber = 0;
        [TestMethod()]
        public void AddTest()
        {
            //arrange
            Calculator calc = new Calculator();
            expectNumber = 30;

            //act
            actualNumber = calc.Add(firstNumber, secondNumber);
            
            //assert
            Assert.AreEqual(expectNumber, actualNumber);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            //arrange
            Calculator calc = new Calculator();
            expectNumber = -11;

            //act
            actualNumber = calc.Subtract(firstNumber, secondNumber);
            
            //assert
            Assert.AreEqual(expectNumber, actualNumber);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //arragne
            Calculator calc = new Calculator();
            expectNumber = 200;

            //act
            actualNumber = calc.Multiply(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expectNumber, actualNumber);
        }
    }
}
