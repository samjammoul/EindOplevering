using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Data.Context
{
    public class UserCollectionContext : IUserCollectionContext
    {
        public User user;
      
        readonly static string connectionString = @"Server=studmysql01.fhict.local;Uid=dbi401070;Database=dbi401070;Pwd=salam-SOSO-123;";
        // User user = new User(User.);
        public void SingUp(User user)
        {
            MySqlConnection connection = null;
            //maak groep aan met ingelogde gebruiker als groepsadmin
            
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "INSERT INTO `user`( `UserFirstName`, `UserLastName`, `City`, `Street`, `Province`, `Phone`, `PostalCode`, `Country`, `Email`, `Paswoord`, `Isadmin`)  VALUES " +
                                    "(@UserFirstName, @UserLastName, @City, @Street, @Province, @Phone, @PostalCode, @Country, @Email, @Paswoord, @Isadmin)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@UserFirstName", user.UserFirstName);
                    cmd.Parameters.AddWithValue("@UserLastName", user.UserLastName);
                    cmd.Parameters.AddWithValue("@City", user.City);
                    cmd.Parameters.AddWithValue("@Street", user.Street);
                    cmd.Parameters.AddWithValue("@Province", user.State);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@PostalCode", user.PostalCode);
                    cmd.Parameters.AddWithValue("@Country", user.Country);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Paswoord", user.Password);
                    cmd.Parameters.AddWithValue("@Isadmin", 0);

                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                string expection = ex.Message;
            }
           
        }
    }
}
