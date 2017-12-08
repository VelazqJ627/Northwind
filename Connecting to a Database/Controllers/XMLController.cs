using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using Connecting_to_a_Database.Models;
using System.IO;

namespace Connecting_to_a_Database.Controllers
{
    public class XMLController : ApiController
    {
        DBConnection aConnection = new DBConnection();

        [Route("GetCategories")]
        public List<Category> GetCategories()
        {
            List<Category> aListOfCategories = new List<Category>();
            aListOfCategories = aConnection.GetCategories();
            return aListOfCategories;
        }
    
        [Route("GetProducts")]
        public List<Product> GetProducts()
        {
            List<Product> aListOfProducts = new List<Product>();
            aListOfProducts = aConnection.GetProducts();
            return aListOfProducts;
        }

        [Route("GetSuppliers")]
        public List<Suppliers> GetSuppliers()
        {
            List<Suppliers> aListOfSuppliers = new List<Suppliers>();
            aListOfSuppliers = aConnection.GetSuppliers();
            return aListOfSuppliers;
        }

        [Route("GetOrderDetails")]
        public List<OrderDetails> GetOrderDetails()
        {
            List<OrderDetails> aListOfOrderDetails = new List<OrderDetails>();
            aListOfOrderDetails = aConnection.GetOrderDetails();
            return aListOfOrderDetails;
        }

        [Route("GetOrders")]
        public List<Orders> GetOrders()
        {
            List<Orders> aListOfOrders = new List<Orders>();
            aListOfOrders = aConnection.GetOrders();
            return aListOfOrders;
        }

        [Route("GetCustomers")]
        public List<Customers> GetCustomers()
        {
            List<Customers> aListOfCustomers = new List<Customers>();
            aListOfCustomers = aConnection.GetCustomers();
            return aListOfCustomers;
        }

        [Route("GetEmployees")]
        public List<Employees> GetEmployees()
        {
            List<Employees> aListOfEmployees = new List<Employees>();
            aListOfEmployees = aConnection.GetEmployees();
            return aListOfEmployees;
        }

        [Route("GetShippers")]
        public List<Shippers> GetShippers()
        {
            List<Shippers> aListOfShippers = new List<Shippers>();
            aListOfShippers = aConnection.GetShippers();
            return aListOfShippers;
        }
    }
}
