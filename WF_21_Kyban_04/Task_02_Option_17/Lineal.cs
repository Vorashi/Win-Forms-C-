using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Option_17
{
    internal class Lineal
    {
        public double arg;

        public Lineal (double A)
        { 
            this.arg = A;
        }
 
        const double e = 22026.465794806718 - 5;
        
        private double f (double x) 
        { 
            return arg * x - Math.Cos(x); 
        }

        public double ComputeSolution(double upperBound, double lowerBound)
        {
            if (f(upperBound) * f(lowerBound) > 0)
                return 0;
            else
            {

                double c = (upperBound + lowerBound) / 2;


                while (Math.Abs(lowerBound - upperBound) >= e)
                {

                    if (f(upperBound) * f(c) < 0)
                        lowerBound = c;
                    else
                        upperBound = c;

                    c = (upperBound + lowerBound) / 2;
                }

                return c;
            }
        }
    }
}
