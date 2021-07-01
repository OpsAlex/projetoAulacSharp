using System;
using System.Collections.Generic;
using AulaCsharp.Services;
using AulaCsharp.Entities;

namespace AulaCsharp
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {

            //Predicate(exemplo Removeall) ----------

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // list.RemoveAll(p => p.Price >= 100.0);

            list.RemoveAll(Product.ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            // Aula Action

            Action<Product> act = UpdatePrice;

            // list.ForEach(p => { p.Price += p.Price * 0.1; });
            list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }


            // Aula Delegates ---------------------


            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
            
        }
        // Aula ACTION ---------------
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

    }
}
