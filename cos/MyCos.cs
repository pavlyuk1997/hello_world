using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCosinus
{
    public class MyCos
    {
        public static double Cos(double x, int n)
        {
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result = result + (Math.Pow((-1), i) * Math.Pow(x, (2 * i + 1))) / Cos(2 * i + 1);
            }
            return result;
        }
        public static double Cos(int n)
        {
            double tmp = 1; for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }
       
    }
}
