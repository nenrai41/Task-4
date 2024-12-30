using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garifullin_RE_Task_4
{
    public delegate double Function(double x);

    public interface IIntegrationMethod
    {
        double Integrate(Function function, double lowerBound, double upperBound, double tolerance);
        string MethodName { get; }
    }
}
