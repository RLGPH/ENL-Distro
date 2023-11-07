using System;
using System.Data;
using Microsoft.Data.SqlClient; // Use Microsoft.Data.SqlClient for .NET 7.0

namespace ENL_Distrobution_Storage
{
    public class Database
    {
        private string connectionString = "Data Source=LAPTOP-BOMR24KV;Initial Catalog=ENL-Distrobution;Integrated Security=True";

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Product? GetProductById(int productId)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "SELECT * FROM Products WHERE ID = @ProductId";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@ProductId", productId);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Product product = new(
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

            return null; // Product not found
        }

        public void InsertProduct(Product product)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "INSERT INTO Products (Amount, PLocation, ProductName, Description) " +
                         "VALUES (@Amount, @PLocation, @ProductName, @Description)";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Amount", product.Amount);
            cmd.Parameters.AddWithValue("@PLocation", product.PLocation);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.ExecuteNonQuery();
        }

        public void UpdateProduct(Product product)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "UPDATE Products " +
                         "SET Amount = @Amount, PLocation = @PLocation, ProductName = @ProductName, Description = @Description " +
                         "WHERE ID = @ProductId";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@ProductId", product.ID);
            cmd.Parameters.AddWithValue("@Amount", product.Amount);
            cmd.Parameters.AddWithValue("@PLocation", product.PLocation);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.ExecuteNonQuery();
        }


        public Employee? GetEmployeeById(int employeeId)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "SELECT * FROM Employees WHERE WorkerID = @EmployeeId";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Employee employee = new(
                    (int)reader["WorkerID"],
                    (int)reader["Amount"],
                    (string)reader["Tlf"],
                    (string)reader["FirstName"],
                    (string)reader["LastName"],
                    (string)reader["Email"],
                    (string)reader["Jobtitel"]
                );
                return employee;
            }

            return null; // Employee not found
        }

        public void InsertEmployee(Employee employee)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "INSERT INTO Employees (Amount, Tlf, FirstName, LastName, Email, Jobtitel) " +
                         "VALUES (@Amount, @Tlf, @FirstName, @LastName, @Email, @Jobtitel)";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Amount", employee.Amount);
            cmd.Parameters.AddWithValue("@Tlf", employee.Tlf);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@Jobtitel", employee.Jobtitel);
            cmd.ExecuteNonQuery();
        }

        public void DeleteEmployee(int employeeId)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "DELETE FROM Employees WHERE WorkerID = @EmployeeId";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
            cmd.ExecuteNonQuery();
        }

        public void UpdateEmployee(Employee employee)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "UPDATE Employees " +
                         "SET Amount = @Amount, Tlf = @Tlf, FirstName = @FirstName, LastName = @LastName, Email = @Email, Jobtitel = @Jobtitel " +
                         "WHERE WorkerID = @EmployeeId";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@EmployeeId", employee.WorkerID);
            cmd.Parameters.AddWithValue("@Amount", employee.Amount);
            cmd.Parameters.AddWithValue("@Tlf", employee.Tlf);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@Jobtitel", employee.Jobtitel);
            cmd.ExecuteNonQuery();
        }

        public Order_s? GetOrder_sByID(int OrdersId)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "SELECT * FROM Products WHERE ID = @OrdersID";
            using SqlCommand cmd = new(sql, connection);

            cmd.Parameters.AddWithValue("@OrdersID", OrdersId);
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Order_s order_S = new(
                    (int)reader["OrdersID"],
                    (int)reader["ProduktID"],
                    (int)reader["OrderAmount"],
                    (string)reader["Status"],
                    (string)reader["Worker"]
                    );

                return order_S;
            }
            return null; // Order not found
        }

        public void InsertOrder_sByID(Order_s order_S) 
        {
            using SqlConnection connection =new(connectionString);
            connection.Open();

            string sql = "INSERT INTO Orders(OrdersID,ProduktID,OrderAmount,Status,Worker)" + 
                         "(@OrdersID, @ProduktID, @OrderAmount, @Status, @Worker)";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@OrdersID", order_S.OrdersID);
            cmd.Parameters.AddWithValue("@ProduktID", order_S.ProduktID);
            cmd.Parameters.AddWithValue("@OrderAmount", order_S.OrderAmount);
            cmd.Parameters.AddWithValue("@Status", order_S.Status);
            cmd.Parameters.AddWithValue("@Worker", order_S.Worker);
            cmd.ExecuteNonQuery();
        }

        public void DeleteOrder_sByID(int order_ID) 
        {
            using SqlConnection connection =new(connectionString);
            connection.Open();

            string sql = "DELETE FROM Orders WHERE OrdersID = @OrdersID";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@OrdersID", order_ID);
            cmd.ExecuteNonQuery();
        }

        public void UpdateOrdersByID(Order_s order_S) 
        {
            using SqlConnection connection =new(connectionString);
            connection.Open();

            string sql = "UPDATE Orders" +
                         "SET OrdersID = @OrdersID, ProduktID = @ProduktID, OrderAmount = @OrderAmount, Status = @Status, Worker=@Worker";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@OrdersID", order_S.OrdersID);
            cmd.Parameters.AddWithValue("@ProduktID", order_S.ProduktID);
            cmd.Parameters.AddWithValue("@OrderAmount", order_S.OrderAmount);
            cmd.Parameters.AddWithValue("@Status", order_S.Status);
            cmd.Parameters.AddWithValue("@Worker", order_S.Worker);
        }
    }
}