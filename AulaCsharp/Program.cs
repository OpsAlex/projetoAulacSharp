using System;
using AulaCsharp.Services;

namespace AulaCsharp
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {



            // Aula Delegates
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;

            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
