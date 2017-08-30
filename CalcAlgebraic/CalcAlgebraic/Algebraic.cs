using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAlgebraic
{
    public class Algebraic
    {
        public static double SQRT(double number)
        {
            number = Math.Sqrt(number);
            return (number);
        }//Uses square root on data inputed

        public static double CBRT(double number)
        {
            number = Math.Pow(number, (1.0 / 3.0));
            return (number);
        }//Uses cube root on data inputed

        public static double INV(double number)
        {
            number = Math.Pow(number, -1);
            return (number);
        }//Uses inverse on data inputed
    }
}
