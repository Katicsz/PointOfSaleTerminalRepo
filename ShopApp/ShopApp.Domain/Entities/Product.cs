using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Domain.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double PricePerUnit { get; set; }

        public Product(string name, double pricePerUnit, string type)
        {
            Name = name;
            PricePerUnit = pricePerUnit;
            Type = type;
        }
    }
}
