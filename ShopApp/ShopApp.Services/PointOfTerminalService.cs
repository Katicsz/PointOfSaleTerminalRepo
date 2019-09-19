using ShopApp.Domain.Entities;
using ShopApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Services
{
    public class PointOfSaleTerminalService : IPointOfSaleTerminalService
    {
        private readonly IProductsRepository productsRepository;

        private List<OrderLine> order;
        public PointOfSaleTerminalService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
            order = new List<OrderLine>();
        }

        public double CalculateOrderTotalPrice(string[] productsNames)
        {
            double totalAmount = 0;
            foreach (string productName in productsNames)
            {
                AddProduct(productName);
            }
            foreach(OrderLine orderLine in order)
            {
                totalAmount += orderLine.PricingInfo.TotalPrice;
            }

            return totalAmount;
        }

        private OrderLine AddProduct(string productName)
        {
            OrderLine orderLine = GetOrderLine(productName);
            if (orderLine != null)
            {
                orderLine.AddProduct();
            } else
            {       
                Product product = productsRepository.GetProduct(productName);
                orderLine = new OrderLine(product);
                order.Add(orderLine);
            }
            return orderLine;
        }

        private OrderLine GetOrderLine(string productName)
        {
            foreach (OrderLine orderLine in order)
            {
                if (orderLine.Product.Name == productName)
                {
                    return orderLine;
                }
            }
            return null;
        }
    }
}
