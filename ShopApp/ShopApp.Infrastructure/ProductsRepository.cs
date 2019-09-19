using ShopApp.Domain.Entities;
using ShopApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Infrastructure
{
    public class ProductsRepository: IProductsRepository
    {
        public List<Product> products;

        public ProductsRepository()
        {
            products = new List<Product>
            {
                new Product("A", 1.25, "Type1"),
                new Product("B", 4.25, "Type3"),
                new Product("C", 1, "Type2"),
                new Product("D", 0.75, "Type4")
            };
        }
        public Product GetProduct(string name)
        { 
            foreach (Product product in products)
            {
                if (product.Name.Equals(name))
                    return product;
            }
            throw new ProductNotFoundException($"The product {name} was not found in our catalogue.");
        }
    }

    public class ProductNotFoundException: Exception
    {
        public ProductNotFoundException()
        {

        }

        public ProductNotFoundException(string message): base(message)
        {

        }
    }
}
