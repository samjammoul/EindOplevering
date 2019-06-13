using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Logic
{
   public class ShoppingBasketLogic
    {
        public List<Product> products = new List<Product>();
       

        public List<Product> AddProductsToShoppingBasket(Product product)
        {
            //ShoppingBasketLogic Basket = new ShoppingBasketLogic();
           products.Add(product);

            return products;
        }
       

    }
}
