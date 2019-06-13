using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public int UserId { get; set; }

        public string OrderNumber { get; set; }

        public string ProductName { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }


        public Order(int UserId, string OrderNumber, string ProductName, string UserFirstName, string UserLastName)
        {
            this.UserId = UserId;
            this.OrderNumber = OrderNumber;
            this.ProductName = ProductName;
            this.UserFirstName = UserFirstName;
            this.UserLastName = UserLastName;

        }
    }
}
