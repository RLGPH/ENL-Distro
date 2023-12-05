using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Controls;
using System.Data.SqlClient;
namespace ENL_Distrobution_Storage
{
    public class Database
    {
        //connecting string used to get a connection to a specifik server/database
        public string connectionString = "Data Source=LAPTOP-BOMR24KV;Initial Catalog=ENL-Distrobution;Integrated Security=True;User ID=\"LAPTOP-BOMR24KV\\Casper s. jensen\"";

        //contains list for products
        public List<Product> products = new();

        //this is used to get all the product's and after used to show whats in the server in a datagrid 
        /*public void AddPLocation(Location location)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();
            // Insert PLocation
            string sql = "INSERT INTO PLocation (PLocationID, Shelf, Row) VALUES (@PLocationID,@Shelf, @Row); SELECT SCOPE_IDENTITY()";

            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@PLocationID",location.PLocationID);
            cmd.Parameters.AddWithValue("@Shelf", location.Shelf);
            cmd.Parameters.AddWithValue("@Row", location.Row);
        }

        public void GetPLocation(Location location) 
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();
           
            string sql = "SELECT * FROM PLocation";
            using SqlCommand cmd = new(sql, connection);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                Location location1 = new(
                    (int)reader["PRow"],
                    (int)reader["PShelf"],
                    (string)reader["PLocationID"]
                    );
            }
        }*/

        public List<Product> GetAllProducts()
        {
            // checks if the list products if it does clear the list
            if (products == null)
            {
                products = new List<Product>();
            }
            else
            {
                products.Clear();
            }

            using (SqlConnection connection = new(connectionString))
            {
                //opens connection between server and the script
                connection.Open();

                string sql = "SELECT * FROM Products";
                using SqlCommand cmd = new(sql, connection);
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    //reads the elements in the Products table
                    Product product = new(
                        (int)reader["ID"],
                        (int)reader["Amount"],
                        (string)reader["ProductName"],
                        (string)reader["Description"],
                        (string)reader["PLocationID"]
                    );

                    // Adds the product to the product list
                    products.Add(product);
                }
            }
            //returns the products list
            return products;
        }
        //this is used to get all the products and after used to show whats in the server in a datagrid

        // Adds a new product to the database
        public void AddProduct(Product product)
        {

            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "INSERT INTO Products (Amount, ProductName, Description) " +
                         "VALUES (@Amount, @ProductName, @Description); " +
                         "SELECT SCOPE_IDENTITY()"; // Retrieve the inserted product ID
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Amount", product.Amount);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Description", product.Description);

            // Execute the command and retrieve the inserted product ID
            int productId = Convert.ToInt32(cmd.ExecuteScalar());

            // Set the product's ID to the retrieved value
            product.ID = productId;
        }
        // Adds a new product to the database

        //to be edited(is going to update the product in the database)
        public void UpdateProduct(Product product)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();
        }
        //to be edited(is going to update the product in the database

        // Remove a product from the database
        public void RemoveProduct(Product product)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "DELETE FROM Products WHERE ID = @ProductId";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@ProductId", product.ID);
            cmd.ExecuteNonQuery();
        }
        // Remove a product from the database


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
            using SqlConnection connection = new(connectionString);
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
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "DELETE FROM Orders WHERE OrdersID = @OrdersID";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@OrdersID", order_ID);
            cmd.ExecuteNonQuery();
        }

        public void UpdateOrdersByID(Order_s order_S)
        {
            using SqlConnection connection = new(connectionString);
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
        public void InsertProductAndAddToList(Product product)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "INSERT INTO Products (Amount, PLocation, ProductName, Description) " +
                         "VALUES (@Amount, @PLocation, @ProductName, @Description)";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Amount", product.Amount);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.ExecuteNonQuery();

            // After inserting into the database, add the product to the local list
            products.Add(product);
        }

        public void InsertEmployeeAndAddToList(Employee employee)
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

            // After inserting into the database, add the employee to the local list
            //employees.Add(employee);
        }

        public void InsertOrder_sAndAddToList(Order_s order_S)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "INSERT INTO Orders (ProduktID, OrderAmount, Status, Worker) " +
                         "VALUES (@ProduktID, @OrderAmount, @Status, @Worker)";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@ProduktID", order_S.ProduktID);
            cmd.Parameters.AddWithValue("@OrderAmount", order_S.OrderAmount);
            cmd.Parameters.AddWithValue("@Status", order_S.Status);
            cmd.Parameters.AddWithValue("@Worker", order_S.Worker);
            cmd.ExecuteNonQuery();

            // After inserting into the database, add the order to the local list
            //orders.Add(order_S);
        }
    }
}