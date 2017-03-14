using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Factorial
    {

        // The "Calc" static method calculates the factorial value for the
        // specified integer passed in:
        public static int Calc(int i)
        {
            return ((i <= 1) ? 1 : (i * Calc(i - 1)));
        }

    }
}
