using ShopApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Domain.Entities
{
    //No discount
    public class BasePricingInfo: IPricingInfo
    {
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public BasePricingInfo()
        {
            Quantity = 0;
            TotalPrice = 0;
        }

        public virtual void AddProduct(double pricePerUnit)
        {
            Quantity += 1;
            TotalPrice += pricePerUnit;
        }
    }
}
