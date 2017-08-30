using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTrigonometric
{
    public class Trigonometric
    {
        public static double COS(double number)
        {
            // convert from a to radians the result comes back as degrees
            number = number * (Math.PI / 180);
            number = Math.Cos(number);
            return (number);
        }//Uses math cos on the data inserted, and then turns the data from radians to degrees

        public static double SIN(double number)
        {
            number = number * (Math.PI / 180);
            number = Math.Sin(number);
            return (number);
        }//Uses math Sin on the data inserted, and then turns the data from radians to degrees

        public static double TAN(double number)
        {
            number = Math.PI * number / 180.0;
            number = Math.Tan(number);
            return (number);
        }//Uses math Tan on the data inserted, and then turns the data from radians to degrees
    }
}
