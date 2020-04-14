using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step164OutputParamsAndMore
{
    class DivideByTwo
    {
        public void Divide(out int result, int dividend)
        {
            result = dividend / 2;
        }
        public void Divide(out int result, string dividend)
        {
            result = Convert.ToInt32(dividend) / 2;
        }
    }
}
