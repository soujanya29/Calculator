﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.DataAccessLayer.Repository
{
  public interface ICalculatorRepository
    {
        bool SaveResult(int type, int input_1, int input_2, int result);        
    }
}
