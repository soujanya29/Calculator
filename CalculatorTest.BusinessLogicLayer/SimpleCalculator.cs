using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.BusinessLogicLayer
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            try
            { 
                return start + amount;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Subtract(int start, int amount)
        {
            try
            {
                return start - amount;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Multiply(int start, int by)
        {

            try
            {
                return start * by;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Divide(int start, int by)
        {
            try
            {
                return start / by;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
