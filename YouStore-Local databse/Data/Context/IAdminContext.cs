using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public interface IAdminContext
    {
        void AddProduct(string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink);
        List<Product> GetAllProducts();

        List<Product> GetCountOdOrders();

        List<Order> GetAllOrders();

        void DeletProduct(int ProductId);

        bool EditProduct(int ProductId, string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink);





    }
}
