﻿using System.Globalization;

namespace AulaCsharp.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        
        /*
        public Product(int id, string name, double price, Category category)
        {
            Name = name;
            Price = price;
        }
        */


        public override string ToString()
        {
            return Id + ", " + Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Category.Name
                + ", " + Category.Tier;
        }
        /*public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }
        */


        /*
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
        */
        
    }
}
