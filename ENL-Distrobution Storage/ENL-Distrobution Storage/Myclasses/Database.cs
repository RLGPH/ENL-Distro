using System;
using System.Data;
using System.Data.SqlClient;

namespace ENL_Distrobution_Storage
{
    public class Database
    {
        private string connectionString; // Connection string for your SQL Server database

        public Database(string connectionString)
        { 
            connectionString = "Data Source=LAPTOP-BOMR24KV;Initial Catalog=ENL-Distrobution;Integrated Security=True; version=16.00.1000";
        }
        
        public Product GetProductById(int productId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Products WHERE ID = @ProductId";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Product product = new Product
                            (
                                (int)reader["Amount"],
                                (int)reader["PLocation"],
                                (string)reader["ProductName"],
                                (string)reader["Description"]
                            )
                            {
                                ID = (int)reader["ID"]
                            };
                            return product;
                        }
                    }
                }
            }
            return null; // Product not found
        }

        public void InsertProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Products (Amount, PLocation, ProductName, Description) " +
                             "VALUES (@Amount, @PLocation, @ProductName, @Description)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Amount", product.Amount);
                    cmd.Parameters.AddWithValue("@PLocation", product.PLocation);
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Products " +
                             "SET Amount = @Amount, PLocation = @PLocation, ProductName = @ProductName, Description = @Description " +
                             "WHERE ID = @ProductId";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductId", product.ID);
                    cmd.Parameters.AddWithValue("@Amount", product.Amount);
                    cmd.Parameters.AddWithValue("@PLocation", product.PLocation);
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}