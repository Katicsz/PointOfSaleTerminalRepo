using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Domain.Entities
{
    //Type of discount: 3 for 3 euros
    public class PricingInfoTypeA: BasePricingInfo
    {
        public PricingInfoTypeA(): base() { }

        public override void AddProduct(double pricePerUnit)
        {
            base.AddProduct(pricePerUnit);
            if (Quantity % 3 == 0)
            {
                TotalPrice -= 0.75;
            }
        }
    }
}
