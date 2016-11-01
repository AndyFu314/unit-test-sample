using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    public interface ICalculator
    {
        int Add(int firstNumber, int secondNumber);
        int Subtract(int firstNumber, int secondNumber);
        int Multiply(int firstNumber, int secondNumber);
    }
}
