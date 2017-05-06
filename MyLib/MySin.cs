using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MyLib
{
    ///Обчисленняматематичнихфунцій
    public class MySin
    {

        public static double Sin(double x, int n)
        {
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result = result + (Math.Pow((-1), i) * Math.Pow(x, (2 * i + 1))) / F(2 * i + 1);
            } 
            return result;
        }
        public static double F(int n)
        {
            double tmp = 1; for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }
        public static double rer(double n)
        {
            double tmp = Math.Sin(n); 
         
            return tmp;
        }

    }
}