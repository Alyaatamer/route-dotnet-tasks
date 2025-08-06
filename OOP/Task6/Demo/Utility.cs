using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Utility
    {

        public const double pi_1 = 3.14;

        public static double pi_2 { get { return pi_2; } }

        public static readonly double pi_3;

        static Utility()
        {
            pi_3 = 3.14;
        }


        public readonly double pi_4;

        
        public Utility(double pi)
        {
            pi_4= pi;
        }

        
        public static double MeterToCm(double m)
        {
            return m * 100;
        }


        public static double CalcCirleArea(double radius)
        {
            return pi_3 * radius * radius;
        }





    }
}
