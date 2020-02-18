using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.DataAccessLayer.Model
{
   public class CalculatorContext : DbContext
    {
        public CalculatorContext() : base("CalculatorContext")
        {
        }

        public DbSet<CalculatedResult> CalculatedResults { get; set; }    
    }
}
