using System;
using System.Collections.Generic;
using AulaCsharp.Services;
using AulaCsharp.Entities;
using System.Linq;

namespace AulaCsharp
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            // Aula LINQ


            // Especificar o Data Source
            int[] numbers = new int[] { 2, 3, 4, 5, 6 };

            // Definir a consulta

            // IEnumerable<int> resultL = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            var resultL = numbers.Where( x => x % 2 == 0).Select(x => x * 10);

            // Executar a consulta

            foreach (int x in resultL)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("__________________________________");
            //Predicate(exemplo Removeall) ----------

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // list.RemoveAll(p => p.Price >= 100.0);

           // list.RemoveAll(Product.ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            // Aula Func
            Console.WriteLine("__________________________________");
            Func<Product, string> func = NameUpper;

            // List<string> result = list.Select(p => p.Name.ToUpper()).ToList() ;
            List<string> result = list.Select(func).ToList() ;

            foreach (string s in result)
            {
                Console.WriteLine(s);

            }
            // Aula Action
            Console.WriteLine("__________________________________");
            Action<Product> act = UpdatePrice;

            // list.ForEach(p => { p.Price += p.Price * 0.1; });
            list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }


            // Aula Delegates ---------------------
            Console.WriteLine("__________________________________");

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
            
        }
        // Aula Func

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        // Aula ACTION ---------------
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

    }
}
