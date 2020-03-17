using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BLclass
    {
        int r = 0, r1 = 0;
        public int Divide(string numerator,string denominator)
        {
            bool n = int.TryParse(numerator, out r);
            bool n1 = int.TryParse(denominator, out r1);
            if (n && n1)
            { 
                if (r1 != 0)
                {
                    return r / r1;
                }
                else
                {
                    throw new DivideByZeroException("cannot divide by 0");
                }
            }
            else
                throw new FormatException("only numbers");
        }

    }

}
