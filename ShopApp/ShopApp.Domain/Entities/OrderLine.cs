using ShopApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Domain.Entities
{
    public class OrderLine
    {
        public Product Product { get; set; }
        public IPricingInfo PricingInfo { get; set; }

        public OrderLine(Product product)
        {
            Product = product;

            if (product.Type.Equals("Type1"))
            {
                PricingInfo = new PricingInfoTypeA();
            }
            else if (product.Type.Equals("Type2"))
            {
                PricingInfo = new PricingInfoTypeB();
            }
            else
            {
                PricingInfo = new BasePricingInfo();
            }

            AddProduct();
        }

        public void AddProduct()
        {
            PricingInfo.AddProduct(Product.PricePerUnit);
        }
    }
}
