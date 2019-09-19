using ShopApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Domain.Interfaces
{
    public interface IProductsRepository
    {
        Product GetProduct(string name);
    }
}
