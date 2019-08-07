using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_UnitTest
{
    class CalculatorDivideFunction
    {

        internal void GetResultByDivide(int p1, int p2)
        {
            if (p2 == 0)
            {
                throw new DivideByZeroException("Dividor can not be 0 !!");
            }
        }
    }
}
