using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisectionmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double xl = 1, xu =2;
            double fxu, fxl, xm, fxm, xmNew=0, xmOld=1, cond;

            while (true)
            {
                fxu = fx(xu);
                fxl = fx(xl);

                xm = midPoint(xl, xu);

                fxm = fx(xm);
                xmNew = xm;
                cond = Math.Abs((xmNew - xmOld));
                xmOld = xmNew;
                if ((fxl * fxm) > 0)
                {
                    xl = xm;
                }
                else
                {
                    xu = xm;
                }
                if (cond < 0.001)
                    break;
            }
           
            Console.WriteLine(xm);
            Console.ReadLine();
        }

        static double fx (double x)
        {
            double result = (x * x) - 3;
            return result; 
        }

        static double midPoint (double a, double b)
        {
            double result = (a + b) / 2;
            return result;

        }

    }
}
