using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Database
    {
        
        public List<Product> products = new List<Product>();

        // Add a product to the database not complete
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Get a product by its ID
        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.ID == id);
        }

        // Remove a product by its ID
        /*public void RemoveProductById(int id)
        {
            Product productToRemove = GetProductById(id);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
            }
        }*/

        // Update a product by its ID
        public void UpdateProductById(int id, Product updatedProduct)
        {
            Product existingProduct = GetProductById(id);
            if (existingProduct != null)
            {
                // Update the existing product properties
                existingProduct.Antal = updatedProduct.Antal;
                existingProduct.Location = updatedProduct.Location;
                existingProduct.ProductName = updatedProduct.ProductName;
                existingProduct.Description = updatedProduct.Description;
            }
        }

        public List<Employee> employees = new List<Employee>();

        // Add an employee to the database
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        // Get an employee by their worker ID
        public Employee GetEmployeeById(int workerID)
        {
            return employees.FirstOrDefault(e => e.workerID == workerID);
        }

        // Remove an employee by their worker ID
        /*public void RemoveEmployeeById(int workerID)
        {
            Employee employeeToRemove = GetEmployeeById(workerID);
            if (employeeToRemove != null)
            {
                employees.Remove(employeeToRemove);
            }
        }*/

        // Update an employee by their worker ID
        public void UpdateEmployeeById(int workerID, Employee updatedEmployee)
        {
            Employee existingEmployee = GetEmployeeById(workerID);
            if (existingEmployee != null)
            {
                // Update the existing employee properties
                existingEmployee.Amount = updatedEmployee.Amount;
                existingEmployee.Tlf = updatedEmployee.Tlf;
                existingEmployee.FirstName = updatedEmployee.FirstName;
                existingEmployee.LastName = updatedEmployee.LastName;
                existingEmployee.Email = updatedEmployee.Email;
                existingEmployee.Jobtitel = updatedEmployee.Jobtitel;
            }
        }

        public List<Order_s> order_S = new List<Order_s>();

        public void ADDOrder_s(Order_s order_s)
        {
            order_S.Add(order_s);
        }
        public Order_s GetOrder_SById(int OrdersID)
        {
            return order_S.FirstOrDefault(o => o.OrdersID == OrdersID);
        }

        /*public void RemoveOrder_SByID(int OrdersID) 
        {
            Order_s orderToRemove = GetOrder_SById(OrdersID);
            {
                order_S.Remove(orderToRemove);
            }
        }*/
        public void UpdateOrder_SByID(int OrderID, Order_s updateOrder_S)
        {
            Order_s existingOrder = GetOrder_SById(OrderID);
            if (existingOrder != null)
            {
                // Update the existing order properties
                existingOrder.OrderAmount = updateOrder_S.OrderAmount;
                existingOrder.Status = updateOrder_S.Status;
                existingOrder.Worker = updateOrder_S.Worker;
            }
        }
    }
}