using CalculatorTest.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.DataAccessLayer.Model
{
   public class CalculatedResult
    {
        public int Id { get; set; }
        public MethodType MethodTypeId { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public double Result { get; set; }
    }
}
