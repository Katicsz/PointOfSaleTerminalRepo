using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Domain.Interfaces
{
    public interface IPointOfSaleTerminalService
    {
        double CalculateOrderTotalPrice(string[] productsName);
    }
}
