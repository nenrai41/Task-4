using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garifullin_RE_Task_4
{
    public class TrapezoidalMethod : IIntegrationMethod
    {
        public double Integrate(Function function, double lowerBound, double upperBound, double tolerance)
        {
            double result = 0.0;
            int n = 1;
            double width;

            do
            {
                width = (upperBound - lowerBound) / n;
                result = 0.0;

                for (int i = 0; i < n; i++)
                {
                    result += (function(lowerBound + i * width) + function(lowerBound + (i + 1) * width)) / 2;
                }

                result *= width;
                n *= 2; // Увеличиваем количество трапеций
            } while (Math.Abs(result) > tolerance);

            return result;
        }

        public string MethodName => "Метод трапеций";
    }
}
