using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step160OptionalMethodParameter
{
    class BagCosts
    {
        public double TotalPrice(double bag1, double bag2 = 0)
        {
            double total = (bag1 * 1.5) + (bag2 * 1.75);
            return total;
        }
    }
}
