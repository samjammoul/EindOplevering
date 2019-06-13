using System;
using Data;
using Models;
using System.Collections.Generic;
using Data.Context;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace Logic
{
    public class ClientLogic : UserLogic
    {
        Product product;

 
        public ClientLogic()
        {
        }

        //public ClientLogic(int userID)
        //{
        //    UserID = userID;
        //}

        private ClientRepository clientRepository = new ClientRepository(new ClientContext());

        private ShoppingBasketLogic Basket = new ShoppingBasketLogic();

        public List<Client> GetAllUsers() => clientRepository.GetAllUsers();

       // public void AddProductsToShoppingBasket(Product product) => Basket.AddProductsToShoppingBasket(product);
        public void AddProductToShoppingBasket(int ClienntId, int ProductId) => clientRepository.AddProductToShoppingBasket(ClienntId, ProductId);

        public List<Product> GetAllProductsForUser(int ClientId) => clientRepository.GetAllProductsForUser(ClientId);

        public void DeletProduct(int id, int Clientid) => clientRepository.DeletProduct(id, Clientid);

        public void SetOrder(int ClientId, int ProductId, string UserEmail, string UserFirstname)
        {
            clientRepository.SetOrder(ClientId, ProductId, CreatOrderNumber(ClientId));
            SendOrderConformEmail(UserEmail, UserFirstname, CreatOrderNumber(ClientId));

        }

        public List<Product> GetAllOrders(int ClientId) => clientRepository.GetAllOrders(ClientId);

        public int GetShoppinBasketCount() => clientRepository.GetShoppinBasketCount();

        public int GetOrdersCount() => clientRepository.GetOrdersCount();

        public int GetShoppinBasketCountById(int ClientId) => clientRepository.GetShoppinBasketCountById(ClientId);

        public int GetProductsCount() => clientRepository.GetProductsCount();

        public int GetUsersCount() => clientRepository.GetUsersCount();

        public int GetProdctsCountOfUserInShoppingBasket(int ClientId) => clientRepository.GetProdctsCountOfUserInShoppingBasket(ClientId);

        public int GetOrdersOfClient(int ClientId) => clientRepository.GetOrdersOfClient(ClientId);

        public string  CreatOrderNumber(int ClientId)
        {
            string OrderNumber = Convert.ToString(ClientId);
            
            for (int i = 0; i < 6; i++)
            {
                Random rnd = new Random();
                int rndom = rnd.Next(10, 99);
                OrderNumber += Convert.ToString(rndom);


            }

            return OrderNumber;
        }

        public void SendOrderConformEmail(string email, string name,string OrderNumber)
        {
            try
            {
                string subject = "Welcome to YouStore!";
                StringBuilder sbEmailBody = new StringBuilder();
                sbEmailBody.Append("Dear " + name + ",<br/><br/>");
                sbEmailBody.Append("We are glad that you have Orderded from YouStore! Your Order number"+ OrderNumber + ".");
                sbEmailBody.Append("<br/><br/>");
                sbEmailBody.Append("Team YouStore");

                string message = sbEmailBody.ToString();
                var senderEmail = new MailAddress("Aquatest.2803@gmail.com", "");
                var receiverEmail = new MailAddress(email, "Email");
                var password = "Aqua-AQUA-9999";
                var sub = subject;
                var body = message;
                var smtp = new SmtpClient
                {
                    //smtp.gmail.com
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var mess = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    mess.IsBodyHtml = true;

                    smtp.Send(mess);
                }
            }
            catch { }
        }

        public void EditClientProfile(int ClientId, string name, string email, string lastname, string City, string Street, string Province, string Phone, string PostalCode, string Country) => clientRepository.EditClientProfile(ClientId, name, email, lastname, City, Street, Province, Phone, PostalCode, Country);

        public void DeletAccount(int Clientid) => clientRepository.DeletAccount(Clientid);

    }
}
