using CalculatorTest.DataAccessLayer.Repository;

namespace CalculatorTest.CalculatorApp
{
    public class MathRequest
    {
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public int Output { get; set; }
        public MethodType Action { get; set; } 
    }
}