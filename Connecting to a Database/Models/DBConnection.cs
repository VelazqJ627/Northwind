using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace Connecting_to_a_Database.Models
{
    public class DBConnection
    {
        //list is like an array its just more modern, it adjust its size automatically com[ared to an array
        private List<Category> aListOfCategories = new List<Category>();


        //GetCategories() is a method
        public List<Category> GetCategories()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT CategoryId, CategoryName, Description FROM Categories;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aCategoryId = (int)aReader["CategoryId"];
                string aCategoryName = (string)aReader["CategoryName"];
                string aDescription = (string)aReader["Description"];

                Category aCategory = new Category();

                aCategory.CategoryId = aCategoryId;
                aCategory.CategoryName = aCategoryName;
                aCategory.Description = aDescription;


                aListOfCategories.Add(aCategory);
            }
            aConnection.Close();

            return aListOfCategories;
        }

        public bool UpdateCategory(int CatId, string CatName, string CatDesc)
        {
            bool aFlag = false;
            string aSQL = "EXEC UpdateCategory @CatId= '" + CatId + "', @CatName='" + CatName + "', @CatDesc='" + CatDesc + "' ";
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Product> aListOfProducts = new List<Product>();

        public List<Product> GetProducts()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT ProductId, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
             //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aProductId = (int)aReader["ProductId"];
                string aProductName = (string)aReader["ProductName"];
                string aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                decimal aUnitPrice = (decimal)aReader["UnitPrice"];
                int aUnitsInStock = Convert.ToInt16((aReader)["UnitsInStock"]);
                int aUnitsOnOrder = Convert.ToInt16((aReader)["UnitsOnOrder"]);
                int aReorderLevel = Convert.ToInt16((aReader)["ReorderLevel"]);
                bool aDiscontinued = (bool)aReader["Discontinued"];



                Product aProduct = new Product();

                aProduct.ProductId = aProductId;
                aProduct.ProductName = aProductName;
                aProduct.QuantityPerUnit = aQuantityPerUnit;
                aProduct.UnitPrice = aUnitPrice;
                aProduct.UnitsInStock = aUnitsInStock;
                aProduct.UnitsOnOrder = aUnitsOnOrder;
                aProduct.ReorderLevel = aReorderLevel;
                aProduct.Discontinued = aDiscontinued;





                aListOfProducts.Add(aProduct);
            }
            aConnection.Close();

            return aListOfProducts;
            }

        public bool UpdateProducts(int ProId ,string ProName , string QPU ,decimal UnPr ,int UIS  ,int UOO ,int ReLe ,bool Discon )
        {
            bool aFlag = false;
            string aSQL = "EXEC UpdateProducts @ProId= '" + ProId + "', @ProName='" + ProName + "', @QPU='" + QPU + "', @UnPr='" + UnPr + "', @UIS='" + UIS + "', @UOO='" + UOO + "', @ReLe='" + ReLe + "', @Discon='" + Discon + "'";
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Suppliers> aListOfSuppliers = new List<Suppliers>();

        public List<Suppliers> GetSuppliers()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aSupplierID = (int)aReader["SupplierId"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string aAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                //string aRegion = (string)aReader["Region"]; Theres a Null so If Statement
                string aRegion = "n/a";
                if (aReader["Region"] != System.DBNull.Value)
                { aRegion = (string)aReader["Region"]; }

                string aPostalCode = (string)aReader["PostalCode"];
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                //string aFax = (string)aReader["Fax"];
                string aFax = "n/a";
                if (aReader["Fax"] != System.DBNull.Value)
                { aFax = (string)aReader["Fax"]; }
                //string aHomePage = (string)aReader["HomePage"]; If statement to deal with null
                string aHomePage = "n/a";
                if (aReader["HomePage"] != System.DBNull.Value)
                { aHomePage = (string)aReader["HomePage"]; }



                Suppliers aSuppliers = new Suppliers();

                aSuppliers.SupplierId = aSupplierID;
                aSuppliers.CompanyName = aCompanyName;
                aSuppliers.ContactName = aContactName;
                aSuppliers.ContactTitle = aContactTitle;
                aSuppliers.Address = aAddress;
                aSuppliers.City = aCity;
                aSuppliers.Region = aRegion;
                aSuppliers.PostalCode = aPostalCode;
                aSuppliers.Country = aCountry;
                aSuppliers.Phone = aPhone;
                aSuppliers.Fax = aFax;
                aSuppliers.HomePage = aHomePage;








                aListOfSuppliers.Add(aSuppliers);
            }
            aConnection.Close();

            return aListOfSuppliers;

        }
        public bool UpdateSuppliers(int SupId,string CompName, string ContNam, string ConTi, string SAdd, string SCity,string SReg, string SPoCo, string SCou, string SPho, string SFax, string SHP)
        {
            bool aFlag = false;
            string aSQL = "EXEC UpdateSuppliers @SupId= '" + SupId + "', @CompName='" + CompName + "', @ContNam='" + ContNam + "', @ConTi='" + ConTi + "', @SAdd='" + SAdd + "', @SCity='" + SCity + "', @SReg='" + SReg + "', @SPoCo='" + SPoCo + "', @SCou='" + SCou + "', @SPho='" + SPho + "', @SFax='" + SFax + "', @SHP='" + SHP + "' ";
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<OrderDetails> aListOfOrderDetails = new List<OrderDetails>();

        public List<OrderDetails> GetOrderDetails()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT OrderId, ProductId, UnitPrice, Quantity, Discount FROM OrderDetails;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aOrderId = (int)aReader["OrderId"];
                int aProductId = (int)aReader["ProductId"];
                decimal aUnitPrice = (decimal)aReader["UnitPrice"];
                int aQuantity = Convert.ToInt16((aReader)["Quantity"]);
                int aDiscount = Convert.ToInt16((aReader)["Discount"]);




                OrderDetails aOrderDetails = new OrderDetails();

                aOrderDetails.OrderId = aOrderId;
                aOrderDetails.ProductId = aProductId;
                aOrderDetails.UnitPrice = aUnitPrice;
                aOrderDetails.Quantity = aQuantity;
                aOrderDetails.Discount = aDiscount;



                aListOfOrderDetails.Add(aOrderDetails);
            }
            aConnection.Close();

            return aListOfOrderDetails;

        }

        private List<Orders> aListOfOrders = new List<Orders>();

        public List<Orders> GetOrders()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT OrderId, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aOrderId = (int)aReader["OrderId"];
                string aCustomerId = (string)aReader["CustomerID"];
                int aEmployeeId = (int)aReader["EmployeeID"];
                string aOrderDate = Convert.ToString((aReader)["OrderDate"]);
                string aRequiredDate = Convert.ToString((aReader)["RequiredDate"]);
                string aShippedDate = Convert.ToString((aReader)["ShippedDate"]);
                int aShipVia = (int)aReader["ShipVia"];
                decimal aFreight = (decimal)aReader["Freight"];
                string aShipName = (string)aReader["ShipName"];
                string aShipAddress = (string)aReader["ShipAddress"];
                string aShipCity = (string)aReader["ShipCity"];
                //string aShipRegion = (string)aReader["ShipRegion"]; null so needs if statement
                string aShipRegion = "n/a";
                if (aReader["ShipRegion"] != System.DBNull.Value)
                { aShipRegion = (string)aReader["ShipRegion"]; }
                //string aShipPostalCode = (string)aReader["ShipPostalCode"]; null so needs if statement
                string aShipPostalCode = "n/a";
                if (aReader["ShipPostalCode"] != System.DBNull.Value)
                { aShipPostalCode = (string)aReader["ShipPostalCode"]; }
                string aShipCountry = (string)aReader["ShipCountry"];





                Orders aOrders = new Orders();

                aOrders.OrderId = aOrderId;
                aOrders.CustomerId = aCustomerId;
                aOrders.EmployeeId = aEmployeeId;
                aOrders.OrderDate = aOrderDate;
                aOrders.RequiredDate = aRequiredDate;
                aOrders.ShippedDate = aShippedDate;
                aOrders.ShipVia = aShipVia;
                aOrders.Freight = aFreight;
                aOrders.ShipName = aShipName;
                aOrders.ShipAddress = aShipAddress;
                aOrders.ShipCity = aShipCity;
                aOrders.ShipRegion = aShipRegion;
                aOrders.ShipPostalCode = aShipPostalCode;
                aOrders.ShipCountry = aShipCountry;






                aListOfOrders.Add(aOrders);
            }
            aConnection.Close();

            return aListOfOrders;

        }

        public bool UpdateOrders(int OrdId,string OrdDat,string ReqDat, string ShiDat,decimal OFri, string ShiNam, string ShiAdd, string ShiCit , string ShiReg , string ShiPosCo, string ShiCou)
        {
            bool aFlag = false;
            string aSQL = "EXEC UpdateOrders @OrdId= '" + OrdId + "', @OrdDat='" + OrdDat + "', @ReqDat='" + ReqDat + "', @ShiDat='" + ShiDat + "', @OFri='" + OFri + "', @ShiNam='" + ShiNam + "', @ShiAdd='" + ShiAdd + "', @ShiCit='" + ShiCit + "', @ShiReg='" + ShiReg + "', @ShiPosCo='" + ShiPosCo + "', @ShiCou='" + ShiCou + "' ";
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Customers> aListOfCustomers = new List<Customers>();

        public List<Customers> GetCustomers()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                string aCustomerId = (string)aReader["CustomerID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string aAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                //string aRegion = (string)aReader["Region"]; if statement because it is null
                string aRegion = "n/a";
                if (aReader["Region"] != System.DBNull.Value)
                { aRegion = (string)aReader["Region"]; }
                //string aPostalCode = (string)aReader["PostalCode"];
                string aPostalCode = "n/a";
                if (aReader["PostalCode"] != System.DBNull.Value)
                { aPostalCode = (string)aReader["PostalCode"]; }
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                //string aFax = (string)aReader["Fax"];if statement because it is null
                string aFax = "n/a";
                if (aReader["Fax"] != System.DBNull.Value)
                { aFax = (string)aReader["Fax"]; }


                Customers aCustomers = new Customers();

                aCustomers.CustomerId = aCustomerId;
                aCustomers.CompanyName = aCompanyName;
                aCustomers.ContactName = aContactName;
                aCustomers.ContactTitle = aContactTitle;
                aCustomers.Address = aAddress;
                aCustomers.City = aCity;
                aCustomers.Region = aRegion;
                aCustomers.PostalCode = aPostalCode;
                aCustomers.Phone = aPhone;
                aCustomers.Fax = aFax;
                






                aListOfCustomers.Add(aCustomers);
            }
            aConnection.Close();
            return aListOfCustomers;
        }

        public bool UpdateCustomers(string custId, string compName, string contName, string contTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            bool aFlag = false;
            string aSQL = "EXEC UpdateCustomers @custId= '" + custId + "', @compName='" + compName + "', @contName='" + contName + "', @contTitle='" + contTitle + "', @address='" + address + "', @city='" + city + "', @region='" + region + "', @postalCode='" + postalCode + "', @country='" + country + "', @phone='" + phone + "', @fax='" + fax + "' ";
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Employees> aListOfEmployees = new List<Employees>();

        public List<Employees> GetEmployees()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo FROM Employees;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aEmployeeId = (int)aReader["EmployeeID"];
                string aLastName = (string)aReader["LastName"];
                string aFirstName = (string)aReader["FirstName"];
                //string aTitle = (string)aReader["Title"];
                string aTitle = "n/a";
                if (aReader["Title"] != System.DBNull.Value)
                { aTitle = (string)aReader["Title"]; }
                //string aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                string aTitleOfCourtesy = "n/a";
                if (aReader["TitleOfCourtesy"] != System.DBNull.Value)
                { aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"]; }
                //string aBirthDate = (string)aReader["BirthDate"]; COnverted it toString
                string aBirthDate = Convert.ToString((aReader)["BirthDate"]);
                //string aHireDate = (string)aReader["HireDate"];
                string aHireDate = Convert.ToString((aReader)["HireDate"]);
                //string aAddress = (string)aReader["Address"];
                string aAddress = "n/a";
                if (aReader["Address"] != System.DBNull.Value)
                { aAddress = (string)aReader["Address"]; }
                //string aCity = (string)aReader["City"];
                string aCity = "n/a";
                if (aReader["City"] != System.DBNull.Value)
                { aCity = (string)aReader["City"]; }
                //string aRegion = (string)aReader["Region"];
                string aRegion = "n/a";
                if (aReader["Region"] != System.DBNull.Value)
                { aRegion = (string)aReader["Region"]; }
                //string aPostalCode = (string)aReader["PostalCode"]; 
                string aPostalCode = "n/a";
                if (aReader["PostalCode"] != System.DBNull.Value)
                { aPostalCode = (string)aReader["PostalCode"]; }
                //string aCountry = (string)aReader["Country"];
                string aCountry = "n/a";
                if (aReader["Country"] != System.DBNull.Value)
                { aCountry = (string)aReader["Country"]; }
                // string aHomePhone = (string)aReader["HomePhone"];
                string aHomePhone = "n/a";
                if (aReader["HomePhone"] != System.DBNull.Value)
                { aHomePhone = (string)aReader["HomePhone"]; }
                //string aExtension = (string)aReader["Extension"];
                string aExtension = "n/a";
                if (aReader["Extension"] != System.DBNull.Value)
                { aExtension = (string)aReader["Extension"]; }
                //string aPhoto = (string)aReader["Photo"];
                string aPhoto = "n/a";
                if (aReader["Photo"] != System.DBNull.Value)
                { aPhoto = (string)aReader["Photo"]; }
                //string aNotes = (string)aReader["Notes"];
                string aNotes = "n/a";
                if (aReader["Notes"] != System.DBNull.Value)
                { aNotes = (string)aReader["Notes"]; }
                //string aReportsTo = (string)aReader["ReportsTo"];
                string aReportsTo = Convert.ToString((aReader)["ReportsTo"]);
                



                Employees aEmployees = new Employees();

                aEmployees.EmployeeId = aEmployeeId;
                aEmployees.LastName = aLastName;
                aEmployees.FirstName = aFirstName;
                aEmployees.Title = aTitle;
                aEmployees.TitleOfCourtesy = aTitleOfCourtesy;
                aEmployees.BirthDate = aBirthDate;
                aEmployees.HireDate = aHireDate;
                aEmployees.Address = aAddress;
                aEmployees.City = aCity;
                aEmployees.Region = aRegion;
                aEmployees.PostalCode = aPostalCode;
                aEmployees.HomePhone = aHomePhone;
                aEmployees.Extension = aExtension;
                aEmployees.Photo = aPhoto;
                aEmployees.Notes = aNotes;
                aEmployees.ReportsTo = aReportsTo;
                aListOfEmployees.Add(aEmployees);
            }
            aConnection.Close();

            return aListOfEmployees;
        }

        public bool UpdateEmployees(int EmpId, string EmLa, string EmFi, string EmTi, string EmTOC, string EmBi, string EmpHD, string EmAd, string EmCi, string EmpRe, string EmPC, string EmCu, string EmpHP, string EmEx, string EmPh, string EmpNo, string EmRT  )
        {
            bool aFlag = false;
            string aSQL = "EXEC UpdateEmployees @EmpId= '" + EmpId + "', @EmLa='" + EmLa + "', @EmFi='" + EmFi + "', @EmTi='" + EmTi + "', @EmTOC='" + EmTOC + "', @EmBi='" + EmBi + "', @EmpHD='" + EmpHD + "', @EmAd='" + EmAd + "', @EmCi='" + EmCi + "', @EmpRe='" + EmpRe + "', @EmPC='" + EmPC + "', @EmCu='" + EmCu + "', @EmpHP='" + EmpHP + "', @EmEx='" + EmEx + "', @EmPh='" + EmPh + "', @EmpNo='" + EmpNo + "', @EmRT='" + EmRT + "' ";
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }

        private List<Shippers> aListOfShippers = new List<Shippers>();


        //Shippers() is a method
        public List<Shippers> GetShippers()
        {
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            //basic sql
            string aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers;";
            //@"provider etc = depends on your driver ;Data SOurce=connection to the database string 
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;

            //run sql and run it into aReader variable which turns it into a spreadsheet
            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aShipperId = (int)aReader["ShipperID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aPhone = (string)aReader["Phone"];

                Shippers aShippers = new Shippers();

                aShippers.ShipperId = aShipperId;
                aShippers.CompanyName = aCompanyName;
                aShippers.Phone = aPhone;


                aListOfShippers.Add(aShippers);
            }

            aConnection.Close();

            return aListOfShippers;
        }

        public bool UpdateShippers(int ShipId, string ShCN, string ShP)
        {
            bool aFlag = false;
            string aSQL = "EXEC UpdateShippers @ShipId= '" + ShipId + "', @ShCN='" + ShCN + "', @ShP='" + ShP + "' ";
            //oledb is a tool/technology which is the license to the DB
            OleDbConnection aConnection = new OleDbConnection();
            aConnection.ConnectionString = @"Provider=sqloledb;
            Data Source=SNAKE\SQLEXPRESS;Initial Catalog=NorthwindSQL;Integrated Security=SSPI";

            aConnection.Open();
            //aCommand tells the database what to do
            OleDbCommand aCommand = aConnection.CreateCommand();
            //which is to do the sql statement
            aCommand.CommandText = aSQL;
            aCommand.ExecuteNonQuery();

            aFlag = true;
            aConnection.Close();
            return aFlag;
        }


    }
}