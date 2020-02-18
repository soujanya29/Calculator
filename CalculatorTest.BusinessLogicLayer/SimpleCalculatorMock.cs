using System;

namespace CalculatorTest.BusinessLogicLayer
{
    public class SimpleCalculatorMock : ISimpleCalculator
    {
        private readonly ISimpleCalculator _simpleCalculator = null;
      
        public SimpleCalculatorMock(ISimpleCalculator simpleCalculator)
        {
            _simpleCalculator = simpleCalculator;
        }

        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
        public int Multiply(int start, int by)
        {
            return start * by;
        }
        public int Divide(int start, int by)
        {
            try
            {
                return start / by;
            }
            catch (DivideByZeroException)
            {
                return -999;
            }
        }
    }
}
