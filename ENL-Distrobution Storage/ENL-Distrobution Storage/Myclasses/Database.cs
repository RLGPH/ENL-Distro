using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace ENL_Distrobution_Storage
{
    public class Database
    {
        //connecting string used to get a connection to a specifik server/database since its a local database this 
        //will probly be needed to be changed if it was used on some other laptop/PC/server
        public string connectionString = "Data Source=LAPTOP-BOMR24KV;Initial Catalog=ENL-Distrobution;Integrated Security=True;User ID=\"LAPTOP-BOMR24KV\\Casper s. jensen\"";

        //contains list for products
        public List<Product> products = new();
        public List<Location> locationlist = new();
        public List<Employee> employees = new();
        public List<Order_s> order_s = new();
        //---------------------------------------------------------------------//
        //-----------------------START OF PRODUCTT METHODS---------------------//
        //used to add Location to the database
        public void AddPLocation(Location location)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            
            string sql = "INSERT INTO PLocation (PShelf, PRow) VALUES (@PShelf, @PRow); SELECT SCOPE_IDENTITY()";

            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@PShelf", location.Shelf);
            cmd.Parameters.AddWithValue("@PRow", location.Row);

            // Execute the query and get the last inserted identity
            int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
        }
        //used to get the location
        public List<Location> GetPlocation(Location location)
        {
            using (SqlConnection connection = new(connectionString))
            {
                //opens connection between server and the script
                connection.Open();
                locationlist.Clear();
                string sql = "SELECT * FROM PLocation WHERE PlocationID = @ID";

                using SqlCommand cmd = new(sql, connection);
                cmd.Parameters.AddWithValue("@ID", location.LocationID);

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int row = reader.GetInt32(reader.GetOrdinal("PRow"));
                    int shelf = reader.GetInt32(reader.GetOrdinal("PShelf"));
                    int id = reader.GetInt32(reader.GetOrdinal("PLocationID"));
                    location = new Location(row, shelf, id);
                    locationlist.Add(location);
                    
                }
            }
            return locationlist;
        }
        //used to get all products
        public List<Product> GetAllProducts()
        {
            // checks if the list has anything it clears it just in case
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

                string sql = "SELECT * FROM Products " +
                     "INNER JOIN PLocation ON Products.PLocationID = PLocation.PLocationID";

                using SqlCommand cmd = new(sql, connection);
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productId = (int)reader["ID"];
                    int amount = (int)reader["Amount"];
                    string productName = (string)reader["ProductName"];
                    string description = (string)reader["Description"];
                    int pRow = (int)reader["PRow"];
                    int pShelf = (int)reader["PShelf"];

                    Location location = new(pRow, pShelf, 0);

                    Product product = new(productId, amount, productName, description, location);
                    products.Add(product);
                }
            }

            return products;
        }
        //used along side some other code for editing products to get a single product 
        public Product GetProductById(int productId)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return products.FirstOrDefault(product => product.ProductID == productId);
#pragma warning restore CS8603 // Possible null reference return.
        }

        // Adds a new product to the database
        public void AddProduct(Product product)
        {

            using SqlConnection connection = new(connectionString);
            connection.Open();

            string getPlocationId = "SELECT TOP 1 PLocationID FROM PLocation ORDER BY PLocationID DESC";
            using SqlCommand getPlocationIdCmd = new(getPlocationId, connection);
            int plocationID = Convert.ToInt32(getPlocationIdCmd.ExecuteScalar());


            string sql = "INSERT INTO Products (Amount, ProductName, Description,PLocationID)" +
                         "VALUES (@Amount, @ProductName, @Description, @PLocationID)"+
                         "SELECT SCOPE_IDENTITY()"; // Retrieve the inserted product ID
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Amount", product.ProductAmount);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Description", product.ProductDescription);
            cmd.Parameters.AddWithValue("@PLocationID", plocationID);

            // Execute the command and retrieve the inserted product ID
            int productId = Convert.ToInt32(cmd.ExecuteScalar());
            
            // Set the product's ID to the retrieved value
            product.ProductID = productId;
        }

        //it update the product and the location together 
        public void UpdateProductandlocation(Product product,Location location)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            // Update Products table
            string updateProductSql = "UPDATE Products SET Amount = @Amount, ProductName = @ProductName, Description = @Description WHERE ID = @ProductID";

            using SqlCommand updateProductCmd = new(updateProductSql, connection);
            updateProductCmd.Parameters.AddWithValue("@Amount", product.ProductAmount);
            updateProductCmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            updateProductCmd.Parameters.AddWithValue("@Description", product.ProductDescription);
            updateProductCmd.Parameters.AddWithValue("@ProductID", product.ProductID);


            updateProductCmd.ExecuteNonQuery();

            // Update PLocation table
            string updateLocationSql = "UPDATE PLocation SET PShelf = @Shelf, PRow = @Row WHERE PLocationID = @LocationID";

            using SqlCommand updateLocationCmd = new(updateLocationSql, connection);
            updateLocationCmd.Parameters.AddWithValue("@Shelf", location.Shelf);
            updateLocationCmd.Parameters.AddWithValue("@Row", location.Row);
            updateLocationCmd.Parameters.AddWithValue("@LocationID", location.LocationID);

            updateLocationCmd.ExecuteNonQuery();
        }


        // Remove a product from the database
        public void RemoveProduct(Product product)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "DELETE FROM Products WHERE ID = @ProductId";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@ProductId", product.ProductID);
            cmd.ExecuteNonQuery();
        }
        //-----------------------END OF PRODUCTS METHODS-----------------------//
        //---------------------------------------------------------------------//

        //---------------------------------------------------------------------//
        //-----------------------START OF EMPLOYEE METHODS---------------------//
        //gets all employees allready in the databasse
        public List<Employee> GetAllEmployees()
        {
            if (employees == null)
            {
                employees = new List<Employee>();
            }
            else
            {
                employees.Clear();
            }

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Employees";

                using SqlCommand cmd = new(sql, connection);
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = (int)reader["WorkerID"];
                    int amountOrdersDone = (int)reader["Amount"];
                    int workStatus = (int)reader["WStatus"];
                    string Tlf = (string)reader["Tlf"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Jobtitel = (string)reader["Jobtitel"];
                    string UserName = "";
                    string Password = "";
                    string AdminPassword = "";

                    Employee.WorkStatus status = (Employee.WorkStatus)workStatus;

                    Employee employee = new(Id, amountOrdersDone, Tlf, FirstName, LastName, Email, Jobtitel, status, UserName, Password, AdminPassword);
                    employees.Add(employee);
                }
            }

            return employees;
        }
        //adds employee to the database
        public void ADDEmployee(Employee employee)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "INSERT INTO Employees (Amount, Tlf, FirstName, LastName, Email, Jobtitel, WStatus) " +
                         "VALUES (@Amount, @Tlf, @FirstName, @LastName, @Email, @Jobtitel, @WStatus)";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Amount", employee.Amount);
            cmd.Parameters.AddWithValue("@Tlf", employee.Tlf);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@Jobtitel", employee.Jobtitel);
            cmd.Parameters.AddWithValue("@WStatus", (int)employee.Status);

            int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
        }
        //used in deleting employees from the database
        public void DeleteEmployee(Employee employee)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "DELETE FROM Employees WHERE WorkerID = @WorkerID";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@WorkerID", employee.WorkerID);
            cmd.ExecuteNonQuery();
        }
        //used to update the employees database after they have been editted 
        public void UpdateEmployee(Employee employee)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string updateEmployeeSql = "UPDATE Employees " +
                                       "SET Amount = @Amount, Tlf = @Tlf, FirstName = @FirstName, LastName = @LastName, " +
                                       "Email = @Email, Jobtitel = @Jobtitel, WStatus = @WStatus " +
                                       "WHERE WorkerID = @EmployeeId";

            using SqlCommand updateEmployeeCmd = new(updateEmployeeSql, connection);
            updateEmployeeCmd.Parameters.AddWithValue("@EmployeeId", employee.WorkerID);
            updateEmployeeCmd.Parameters.AddWithValue("@Amount", employee.Amount);
            updateEmployeeCmd.Parameters.AddWithValue("@Tlf", employee.Tlf);
            updateEmployeeCmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            updateEmployeeCmd.Parameters.AddWithValue("@LastName", employee.LastName);
            updateEmployeeCmd.Parameters.AddWithValue("@Email", employee.Email);
            updateEmployeeCmd.Parameters.AddWithValue("@Jobtitel", employee.Jobtitel);
            updateEmployeeCmd.Parameters.AddWithValue("@WStatus", (int)employee.Status);

            updateEmployeeCmd.ExecuteNonQuery();
        }
        //-----------------------END OF EMPLOYEE METHODS---------------------//
        //-------------------------------------------------------------------//

        //-------------------------------------------------------------------//
        //-----------------------START OF ORDERS METHODS---------------------//
        //used to get all Orders and then put them in a list
        public List<Order_s> GetAllOrders()
        {
            if (order_s == null)
            {
                order_s = new List<Order_s>();
            }
            else
            {
                order_s.Clear();
            }

            using (SqlConnection connection = new(connectionString))
            {
                
                connection.Open();

                string sql = "SELECT * FROM Orders";

                using SqlCommand cmd = new(sql, connection);
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int orderId = (int)reader["OrdersID"];
                    int quantity = (int)reader["OrderAmount"];
                    int orderStatus = (int)reader["WStatus"];
                    string wname = (string)reader["WName"];
                    int productid = (int)reader["ProductID"];
                    string pname = (string)reader["NProduct"];
                    int WorkerID = (int)reader["WorkerID"];


                    Order_s.OrderStatus status = (Order_s.OrderStatus)orderStatus;
                    Order_s order = new(orderId, productid, quantity, pname, wname, status,WorkerID);
                    order_s.Add(order);
                }
            }

            return order_s;
        }
        //used to delete orders
        public void DeleteOrder_sByID(Order_s order_S)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "DELETE FROM Orders WHERE OrdersID = @OrdersID";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@OrdersID", order_S.OrdersID);
            cmd.ExecuteNonQuery();
        }
        //used to update orders after they have been editted
        public void UpdateOrdersByID(Order_s order_S)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "UPDATE Orders " +
                         "SET ProductID = @ProductID, OrderAmount = @OrderAmount, WName = @WName, " +
                         "NProduct = @NProduct, WStatus = @WStatus, WorkerID = @WorkerID " +
                         "WHERE OrdersID = @OrdersID";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@OrdersID", order_S.OrdersID);
            cmd.Parameters.AddWithValue("@ProductID", order_S.ProduktID);
            cmd.Parameters.AddWithValue("@OrderAmount", order_S.OrderAmount);
            cmd.Parameters.AddWithValue("@WName", order_S.NWorker);
            cmd.Parameters.AddWithValue("@NProduct", order_S.NProduct);
            cmd.Parameters.AddWithValue("@WStatus", (int)order_S.OStatus);
            cmd.Parameters.AddWithValue("@WorkerID", order_S.WorkerID);
            cmd.ExecuteNonQuery();
        }
        //is used to add orders to the database
        public void AddOrder_s(Order_s order_S)
        {
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = "INSERT INTO Orders (ProductID, OrderAmount, WName, NProduct, WStatus, WorkerID) " +
                         "VALUES (@ProductID, @OrderAmount, @WName, @NProduct, @WStatus, @WorkerID)";
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@ProductID", order_S.ProduktID);
            cmd.Parameters.AddWithValue("@OrderAmount", order_S.OrderAmount);
            cmd.Parameters.AddWithValue("@WName", order_S.NWorker);
            cmd.Parameters.AddWithValue("@NProduct", order_S.NProduct);
            cmd.Parameters.AddWithValue("@WStatus", (int)order_S.OStatus);
            cmd.Parameters.AddWithValue("@WorkerID", order_S.WorkerID);
            cmd.ExecuteNonQuery();
        }
        //-------END-------END-------END-------END-------END-------END-------//
        //-------------------------------------------------------------------//
    }
}