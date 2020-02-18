using CalculatorTest.DataAccessLayer.Model;
using System;
using System.Configuration;


namespace CalculatorTest.DataAccessLayer.Repository
{
    public class CalculatorRepository : ICalculatorRepository
    {
        private readonly CalculatorContext _context;
        
        public CalculatorRepository(CalculatorContext context)
        {
            _context = context;
         
        }

        public bool SaveResult(int type, int input_1, int input_2, int result)
        {
            try
            {

                CalculatedResult data = new CalculatedResult();
                data.MethodTypeId = (MethodType)type;
                data.Value1 = input_1;
                data.Value2 = input_2;
                data.Result = result;
                _context.CalculatedResults.Add(data);
                 _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
