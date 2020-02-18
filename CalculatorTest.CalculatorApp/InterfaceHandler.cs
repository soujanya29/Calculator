using CalculatorTest.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.CalculatorApp
{
    public class InterfaceHandler
    {
        public MathRequest HandleRequest()
        {
            DisplayInstructions();

            int input = Convert.ToInt32(Console.ReadLine());
            var action = GetOperation(input);

            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
           

            return new MathRequest { Action = action, Input1 = input_1, Input2 = input_2 };                       
        }

        private void DisplayInstructions()
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
        }

        private MethodType GetOperation(int input)
        {
            if (input > 0 && input < 5)
                return (MethodType)input;

            throw new ApplicationException("Invalid input");
        }
    }
}
