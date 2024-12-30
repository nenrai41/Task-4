using Garifullin_RE_Task_4;
using System.Diagnostics;

// Пример функции
Function f = x => Math.Sin(x); 
double lowerBound = 0;
double upperBound = Math.PI;
double tolerance = 1e-6;

IIntegrationMethod[] methods =
{
            new LeftRectangleMethod(),
            new RightRectangleMethod(),
            new TrapezoidalMethod()
};
foreach (var method in methods)
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    double result = method.Integrate(f, lowerBound, upperBound, tolerance);
    stopwatch.Stop();
    Console.WriteLine($"{method.MethodName}: Результат = {result}, Время = {stopwatch.ElapsedMilliseconds} мс");
}
    
