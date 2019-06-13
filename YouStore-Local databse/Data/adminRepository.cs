using Data.Context;
using Models;
using System.Collections.Generic;
using System.Threading;

namespace Data
{
    public class AdminRepository
    {
        private readonly CancellationTokenSource _source = new CancellationTokenSource();
        private IAdminContext context;

        public Product Product;
        public AdminRepository(IAdminContext context)
        {
            this.context = context;

        }



        public void AddProduct(string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink)
        {
            context.AddProduct(ProductName, ProductDescription, ProductPrijs, ProductCode, QuantityInStock, Productimagelink);
        }

        public List<Product> GetAllProducts() => context.GetAllProducts();

        public List<Product> GetCountOdOrders() => context.GetCountOdOrders();

        public List<Order> GetAllOrders() => context.GetAllOrders();

        public void DeletProduct(int ProductId) => context.DeletProduct(ProductId);

        public bool EditProduct(int ProductId, string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink) => context.EditProduct(ProductId, ProductName, ProductDescription, ProductPrijs, ProductCode, QuantityInStock, Productimagelink);




        }
}
