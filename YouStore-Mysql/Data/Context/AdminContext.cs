using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Data.Context
{
    public class AdminContext : IAdminContext
    {
        public Product product;
        readonly static string connectionString = @"Server=studmysql01.fhict.local;Uid=dbi401070;Database=dbi401070;Pwd=yourPassword;";
        //Methode om data van  user colum uit de database te halen.
        public void AddProduct(string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink)
        {
            //maak groep aan met ingelogde gebruiker als groepsadmin
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "INSERT INTO [Product] (ProductName, ProductDescription, ProductPrice, QuantityInStock, Image)" +
                                    "VALUES " +
                                    "('" + ProductName + "', '" + ProductDescription + "','" + ProductPrijs + "','" + QuantityInStock + "','" + Productimagelink + "')";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;

                        cmd.ExecuteNonQuery();
                    }
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        //Get Products from DataBase
        public List<Product> GetAllProducts()
        {
            List<Product> Productlist = new List<Product>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                     _conn.Open();
                    //string query = "SELECT * From [Product]";
                    using (SqlCommand cmd = new SqlCommand("GetAllProducts", _conn))
                    {
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                      //  cmd.CommandText = query;
                       
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Hier de string variables werken wel maar de int  variables werken niet .Ik weet niet waarom maar ik ga aan mijn docenten vragen
                                    int ProductId = Convert.ToInt32(reader["ProductId"]);
                                    string ProductDescription = Convert.ToString(reader["ProductDescription"]);
                                    int ProductPrice = Convert.ToInt32(reader["ProductPrice"]);
                                    int QuantityInStock = Convert.ToInt32(reader["QuantityInStock"]);
                                    string Image = Convert.ToString(reader["Image"]);
                                    string ProductCode = Convert.ToString(reader["ProductCode"]);
                                    string ProductName = Convert.ToString(reader["ProductName"]);
                                   

                                    Product Product = new Product(ProductName, ProductDescription, ProductPrice, QuantityInStock, Image, ProductCode, ProductId);

                                    Productlist.Add(Product);
                                 
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
             
            }

             return Productlist;
        }
        public List<Product> GetCountOdOrders()
        {
            List<Product> ordedProducts = new List<Product>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT count(Product.ProductId)  as NumbrsofOrders ,Product.ProductId,product.ProductName FROM [Product] inner JOIN [Order] ON [Product].ProductId = [Order].ProductId Group By Product.ProductId,Product.ProductName;";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                  
                                    int OrderedTimes = Convert.ToInt32(reader["NumbrsofOrders"]);
                                    string ProductName = Convert.ToString(reader["ProductName"]);


                                    Product Product = new Product(ProductName, OrderedTimes);

                                    ordedProducts.Add(Product);
                                }
                            }
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                
            }


            return ordedProducts;
        }
        public List<Product> GetAllProducts2()
        {
            List<Product> Productlist = new List<Product>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    //string query = "SELECT * From [Product]";
                    using (SqlCommand cmd = new SqlCommand("GetAllProducts", _conn))
                    {
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        //  cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Hier de string variables werken wel maar de int  variables werken niet .Ik weet niet waarom maar ik ga aan mijn docenten vragen
                                    int ProductId = Convert.ToInt32(reader["ProductId"]);
                                    string ProductDescription = Convert.ToString(reader["ProductDescription"]);
                                    int ProductPrice = Convert.ToInt32(reader["ProductPrice"]);
                                    int QuantityInStock = Convert.ToInt32(reader["QuantityInStock"]);
                                    string Image = Convert.ToString(reader["Image"]);
                                    string ProductCode = Convert.ToString(reader["ProductCode"]);
                                    string ProductName = Convert.ToString(reader["ProductName"]);


                                    Product Product = new Product(ProductName, ProductDescription, ProductPrice, QuantityInStock, Image, ProductCode, ProductId);

                                    Productlist.Add(Product);

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
            return Productlist;
        }
        public List<Order> GetAllOrders()
        {
            List<Order> Orderslist = new List<Order>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    
                     string query = "SELECT * FROM [Product] INNER JOIN [Order] ON [Product].ProductId = [Order].ProductId  INNER JOIN [User] ON [User].Userid = [Order].Userid;";
                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        

                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        
                         cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    int UserId = Convert.ToInt32(reader["UserId"]);
                                    string OrderNumber = Convert.ToString(reader["Image"]);
                                    string ProductName = Convert.ToString(reader["ProductCode"]);
                                    string UserFirstName = Convert.ToString(reader["UserFirstName"]);
                                    string UserLastName = Convert.ToString(reader["UserLastName"]);


                                    Order order = new Order( UserId,  OrderNumber,  ProductName,  UserFirstName,  UserLastName);

                                    Orderslist.Add(order);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                //nothing here
            }
            return Orderslist;
        }
        public void DeletProduct(int ProductId)
        {
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "DELETE FROM [Product] WHERE ProductId = @ProductId;";
                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.Add("@ProductId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ProductId"].Value = ProductId;
                        
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public bool EditProduct(int ProductId, string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink)
        {

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "UPDATE [Product] SET ProductDescription = @ProductDescription, ProductPrice = @ProductPrice, QuantityInStock = @QuantityInStock, Image = @Image" +
                        ", ProductCode = @ProductCode , ProductName = @ProductName WHERE ProductId = @ProductId";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.Add("@ProductDescription", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters["@ProductDescription"].Value = ProductDescription;

                        cmd.Parameters.Add("@ProductPrice", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ProductPrice"].Value = ProductPrijs;

                        cmd.Parameters.Add("@QuantityInStock", System.Data.SqlDbType.Int);
                        cmd.Parameters["@QuantityInStock"].Value = QuantityInStock;

                        cmd.Parameters.Add("@Image", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters["@Image"].Value = Productimagelink;

                        cmd.Parameters.Add("@ProductCode", System.Data.SqlDbType.NVarChar);
                        cmd.Parameters["@ProductCode"].Value = ProductCode;

                        // NVarChar
                        cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ProductName"].Value = ProductName;

                       
                        cmd.Parameters.Add("@ProductId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ProductId"].Value = ProductId;

                        cmd.ExecuteNonQuery();
                    }
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {
                return false; 
            }

            return true;
        }
    }

}
