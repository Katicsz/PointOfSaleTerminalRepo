using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Domain.Interfaces
{
    public interface IPricingInfo
    {
        int Quantity { get; set; }
        double TotalPrice { get; set; }
        void AddProduct(double pricePerUnit);
    }
}
