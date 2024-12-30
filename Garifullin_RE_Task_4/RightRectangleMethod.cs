using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garifullin_RE_Task_4
{
    public class RightRectangleMethod : IIntegrationMethod
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

                for (int i = 1; i <= n; i++)
                {
                    result += function(lowerBound + i * width);
                }

                result *= width;
                n *= 2; // Увеличиваем количество прямоугольников
            } while (Math.Abs(result) > tolerance);

            return result;
        }

        public string MethodName => "Метод правых прямоугольников";
    }
}
