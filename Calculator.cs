using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    public class Calculator:ICalculator
    {
        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public void SomeMethod()
        {
            throw new Exception();
        }

        public int Multiply(int firstNum, int secondNumber)
        {
            return firstNum * secondNumber;
        }
    }
}
