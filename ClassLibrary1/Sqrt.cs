using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sqrt
    {
        public static double[] Calc(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            double[] result = new double[]
            {
                (-b + Math.Sqrt(d)) / (2 * a), (-b - Math.Sqrt(d)) / (2 * a)
            };
            return result;
        }
    }
}
