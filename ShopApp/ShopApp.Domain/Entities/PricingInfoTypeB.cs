using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Domain.Entities
{
    //Type of discount: 5 plus 1 for free
    public class PricingInfoTypeB: BasePricingInfo
    {
        public PricingInfoTypeB(): base() { }

        public override void AddProduct(double pricePerUnit)
        {
            base.AddProduct(pricePerUnit);
            if (Quantity % 6 == 0)
            {
                TotalPrice -= pricePerUnit;
            }
        }
    }
}
