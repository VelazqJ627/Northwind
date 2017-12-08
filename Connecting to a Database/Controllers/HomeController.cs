using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Connecting_to_a_Database.Models;

namespace Connecting_to_a_Database.Controllers
{
    public class HomeController : Controller
    {
        DBConnection aConnection = new DBConnection();
        // GET: Home
        public ActionResult Index()
        {
            List<Category> aListOfCategories = new List<Category>();

            aListOfCategories = aConnection.GetCategories();

            ViewBag.ListOfCategories = aListOfCategories;

            return View();
        }

        public ActionResult Category()
        {
            List<Category> aListOfCategories = new List<Category>();

            

            aListOfCategories = aConnection.GetCategories();

            ViewBag.ListOfCategories = aListOfCategories;

            return View();
        }

        public ActionResult CategoryDetail(int CatId)
        {
            List<Category> aListOfCategories = new List<Category>();
            aListOfCategories = aConnection.GetCategories();

            var categoryDetails = from c in aListOfCategories
                                  where c.CategoryId == CatId
                                  select c;

            ViewBag.ListOfCategories = categoryDetails;
            ViewBag.catId = CatId;
            return View();
        }

        public ActionResult UpdateCategory(int CatId, string CatName, string CatDesc)
        {
            //So the end user knows his updates
            ViewBag.CatId = CatId;
            ViewBag.CatName = CatName;
            ViewBag.CatDesc = CatDesc;

            //backend
            aConnection.UpdateCategory(CatId, CatName, CatDesc);

            return View();
        }

        public ActionResult Product()
        {
            List<Product> aListOfProducts = new List<Product>();

            DBConnection aConnection = new DBConnection();

            aListOfProducts = aConnection.GetProducts();

            ViewBag.ListOfProducts = aListOfProducts;

            return View();
        }

        public ActionResult ProductDetails(int ProId)
        {
            List<Product> aListOfProducts = new List<Product>();
            aListOfProducts = aConnection.GetProducts();

            var productDetails = from p in aListOfProducts
                                  where p.ProductId == ProId
                                  select p;

            ViewBag.ListOfProducts = productDetails;
            ViewBag.ProId = ProId;
            return View();
        
        }

        public ActionResult UpdateProducts(int ProId, string ProName, string QPU, decimal UnPr, int UIS, int UOO, int ReLe, bool Discon)
        {
            //So the end user knows his updates
            ViewBag.ProId = ProId;
            ViewBag.ProName = ProName;
            ViewBag.QPU = QPU;
            ViewBag.UnPr = UnPr;
            ViewBag.UIS = UIS;
            ViewBag.UOO = UOO;
            ViewBag.ReLe = ReLe;
            ViewBag.Discon = Discon;

            //backend
            aConnection.UpdateProducts(ProId, ProName, QPU, UnPr, UIS, UOO, ReLe, Discon);

            return View();
        }
        public ActionResult Suppliers()
        {
            List<Suppliers> aListOfSuppliers = new List<Suppliers>();

            DBConnection aConnection = new DBConnection();

            aListOfSuppliers = aConnection.GetSuppliers();

            ViewBag.ListOfSuppliers = aListOfSuppliers;

            return View();
        }

        public ActionResult SupplierDetails(int SupId)
        {
            List<Suppliers> aListOfSuppliers = new List<Suppliers>();
            aListOfSuppliers = aConnection.GetSuppliers();

            var suppliersDetails = from s in aListOfSuppliers
                                   where s.SupplierId == SupId
                                 select s;

            ViewBag.ListOfSuppliers = suppliersDetails;
            ViewBag.SupId = SupId;
            return View();

        }

        public ActionResult UpdateSuppliers(int SupId, string CompName, string ContNam, string ConTi, string SAdd, string SCity, string SReg, string SPoCo, string SCou, string SPho, string SFax, string SHP)
        {
            //So the end user knows his updates
            ViewBag.SupId = SupId;
            ViewBag.CompName = CompName;
            ViewBag.ContNam = ContNam;
            ViewBag.ConTi = ConTi;
            ViewBag.SAdd = SAdd;
            ViewBag.SCity = SCity;
            ViewBag.SReg = SReg;
            ViewBag.SPoCo = SPoCo;
            ViewBag.SCou = SCou;
            ViewBag.SPho = SPho;
            ViewBag.SFax = SFax;
            ViewBag.SAdd = SAdd;
            ViewBag.SHP = SHP;
            //backend
            aConnection.UpdateSuppliers(SupId, CompName, ContNam, ConTi, SAdd, SCity, SReg, SPoCo, SCou, SPho, SFax, SHP);

            return View();
        }

        public ActionResult OrderDetails()
        {
            List<OrderDetails> aListOfOrderDetails = new List<OrderDetails>();

            DBConnection aConnection = new DBConnection();

            aListOfOrderDetails = aConnection.GetOrderDetails();

            ViewBag.ListOfOrderDetails = aListOfOrderDetails;

            return View();
        }

        public ActionResult ODDetails(int OrdId)
        {
            List<OrderDetails> aListOfOrderDetails = new List<OrderDetails>();
            aListOfOrderDetails = aConnection.GetOrderDetails();

            var oDDetails = from od in aListOfOrderDetails
                            where od.OrderId == OrdId
                                   select od;

            ViewBag.ListOfOrderDetails = oDDetails;
            ViewBag.OrdId = OrdId;
            return View();

        }

        public ActionResult Orders()
        {
            List<Orders> aListOfOrders = new List<Orders>();

            DBConnection aConnection = new DBConnection();

            aListOfOrders = aConnection.GetOrders();

            ViewBag.ListOfOrders = aListOfOrders;

            return View();
        }

        public ActionResult OrdersDetail(int OrdId)
        {
            List<Orders> aListOfOrders = new List<Orders>();
            aListOfOrders = aConnection.GetOrders();

            var ordersDetails = from o in aListOfOrders
                                where o.OrderId == OrdId
                                  select o;

            ViewBag.ListOfOrders = ordersDetails;
            ViewBag.OrdId = OrdId;
            return View();
        }

        public ActionResult UpdateOrders(int OrdId, string OrdDat, string ReqDat, string ShiDat, decimal OFri, string ShiNam, string ShiAdd, string ShiCit, string ShiReg, string ShiPosCo, string ShiCou)
        {
            //So the end user knows his updates
            ViewBag.OrdId = OrdId;
            ViewBag.OrdDat = OrdDat;
            ViewBag.ReqDat = ReqDat;
            ViewBag.ShiDat = ShiDat;
            ViewBag.OFri = OFri;
            ViewBag.ShiNam = ShiNam;
            ViewBag.ShiAdd = ShiAdd;
            ViewBag.ShiCit = ShiCit;
            ViewBag.ShiReg = ShiReg;
            ViewBag.ShiPosCo = ShiPosCo;
            ViewBag.ShiCou = ShiCou;

            //backend
            aConnection.UpdateOrders(OrdId, OrdDat, ReqDat, ShiDat, OFri, ShiNam, ShiAdd, ShiCit, ShiReg, ShiPosCo, ShiCou);

            return View();
        }

        public ActionResult Customers()
        {
            List<Customers> aListOfCustomers = new List<Customers>();

            DBConnection aConnection = new DBConnection();

            aListOfCustomers = aConnection.GetCustomers();

            ViewBag.ListOfCustomers = aListOfCustomers;

            return View();
        }

        public ActionResult CustomersDetail(string custId)
        {
            List<Customers> aListOfCustomers = new List<Customers>();
            aListOfCustomers = aConnection.GetCustomers();

            var customersDetails = from cu in aListOfCustomers
                                   where cu.CustomerId == custId
                                select cu;

            ViewBag.ListOfCustomers = customersDetails;
            ViewBag.custId = custId;
            return View();
        }

        public ActionResult UpdateCustomers(string custId, string compName, string contName, string contTitle, string address, string city, string region, string postalCode, string country, string phone, string fax )
        {
            //So the end user knows his updates
            ViewBag.custId = custId;
            ViewBag.compName = compName;
            ViewBag.contName = contName;
            ViewBag.contTitle = contTitle;
            ViewBag.address = address;
            ViewBag.city = city;
            ViewBag.region = region;
            ViewBag.postalCode = postalCode;
            ViewBag.country = country;
            ViewBag.phone = phone;
            ViewBag.fax = fax;

            //backend
            aConnection.UpdateCustomers(custId, compName, contName, contTitle, address, city, region, postalCode, country, phone, fax);

            return View();
        }

        public ActionResult Employees()
        {
            List<Employees> aListOfEmployees = new List<Employees>();

            DBConnection aConnection = new DBConnection();

            aListOfEmployees = aConnection.GetEmployees();

            ViewBag.ListOfEmployees = aListOfEmployees;

            return View();
        }

        public ActionResult EmployeesDetail(int EmpId)
        {
            List<Employees> aListOfEmployees = new List<Employees>();
            aListOfEmployees = aConnection.GetEmployees();

            var employeesDetails = from em in aListOfEmployees
                                   where em.EmployeeId == EmpId
                                   select em;

            ViewBag.ListOfEmployees = employeesDetails;
            ViewBag.EmpId = EmpId;
            return View();
        }

        public ActionResult UpdateEmployees(int EmpId, string EmLa, string EmFi, string EmTi, string EmTOC, string EmBi, string EmpHD, string EmAd, string EmCi, string EmpRe, string EmPC, string EmCu, string EmpHP, string EmEx, string EmPh, string EmpNo, string EmRT)
        {
            //So the end user knows his updates
            ViewBag.EmpId = EmpId;
            ViewBag.EmLa = EmLa;
            ViewBag.EmFi = EmFi;
            ViewBag.EmTi = EmTi;
            ViewBag.EmTOC = EmTOC;
            ViewBag.EmBi = EmBi;
            ViewBag.EmpHD = EmpHD;
            ViewBag.EmAd = EmAd;
            ViewBag.EmCi = EmCi;
            ViewBag.EmpRe = EmpRe;
            ViewBag.EmPC = EmPC;
            ViewBag.EmCu = EmCu;
            ViewBag.EmpHP = EmpHP;
            ViewBag.EmEx = EmEx;
            ViewBag.EmPh = EmPh;
            ViewBag.EmpNo = EmpNo;
            ViewBag.EmRT = EmRT;
            //backend
            aConnection.UpdateEmployees(EmpId, EmLa, EmFi, EmTi, EmTOC, EmBi, EmpHD, EmAd, EmCi, EmpRe, EmPC, EmCu, EmpHP, EmEx, EmPh, EmpNo, EmRT);

            return View();
        }

        public ActionResult Shippers()
        {
            List<Shippers> aListOfShippers = new List<Shippers>();

            DBConnection aConnection = new DBConnection();

            aListOfShippers = aConnection.GetShippers();

            ViewBag.ListOfShippers = aListOfShippers;

            return View();
        }

        public ActionResult ShippersDetail(int ShipId)
        {
            List<Shippers> aListOfShippers = new List<Shippers>();
            aListOfShippers = aConnection.GetShippers();

            var shippersDetails = from sh in aListOfShippers
                                  where sh.ShipperId == ShipId
                                   select sh;

            ViewBag.ListOfShippers = shippersDetails;
            ViewBag.ShipId = ShipId;
            return View();
        }

        public ActionResult UpdateShippers(int ShipId, string ShCN, string ShP)
        {
            //So the end user knows his updates
            ViewBag.ShipId = ShipId;
            ViewBag.ShCN = ShCN;
            ViewBag.ShP = ShP;

            //backend
            aConnection.UpdateShippers(ShipId, ShCN, ShP);

            return View();
        }


    }
}