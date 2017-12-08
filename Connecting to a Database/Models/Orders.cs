using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connecting_to_a_Database.Models
{
    public class Orders
    {
        //private
        private int orderId = 0;
        private string customerId = "n/a";
        private int employeeId = 0;
        private string orderDate = "n/a";
        private string requiredDate = "n/a";
        private string shippedDate = "n/a";
        private int shipVia = 0;
        private decimal freight = 0;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";

        //gets and sets
        public int OrderId
        {
            get { return this.orderId; }
            set { this.orderId = value; }
        }

        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }

        public int EmployeeId
        {
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }

        public string OrderDate
        {
            get { return this.orderDate; }
            set { this.orderDate = value; }
        }

        public string RequiredDate
        {
            get { return this.requiredDate; }
            set { this.requiredDate = value; }
        }

        public string ShippedDate
        {
            get { return this.shippedDate; }
            set { this.shippedDate = value; }
        }

        public int ShipVia
        {
            get { return this.shipVia; }
            set { this.shipVia = value; }
        }

        public decimal Freight
        {
            get { return this.freight; }
            set { this.freight = value; }
        }

        public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }

        public string ShipAddress
        {
            get { return this.shipAddress; }
            set { this.shipAddress = value; }
        }

        public string ShipCity
        {
            get { return this.shipCity; }
            set { this.shipCity = value; }
        }

        public string ShipRegion
        {
            get { return this.shipRegion; }
            set { this.shipRegion = value; }
        }

        public string ShipPostalCode
        {
            get { return this.shipPostalCode; }
            set { this.shipPostalCode = value; }
        }

        public string ShipCountry
        {
            get { return this.shipCountry; }
            set { this.shipCountry = value; }
        }

        //Tostring 
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + " OrderId: " + OrderId + "<br />";
            aMessage = aMessage + " CustomerId: " + CustomerId + "<br />";
            aMessage = aMessage + "EmployeeId: " + EmployeeId + "<br />";
            aMessage = aMessage + " OrderDate : " + OrderDate + "<br />";
            aMessage = aMessage + " RequiredDate:" + RequiredDate + "<br />";
            aMessage = aMessage + " SHippedDate: " + ShippedDate + "<br />";
            aMessage = aMessage + " ShipVia:" + ShipVia + "<br />";
            aMessage = aMessage + " Frieght" + Freight + "<br />";
            aMessage = aMessage + " ShipName :" + ShipName + "<br />";
            aMessage = aMessage + " SHipAddress:  :" + ShipAddress + "<br />";
            aMessage = aMessage + "SHipCity"+ ShipCity + "<br />";
            aMessage = aMessage + " SHipRegion :" + ShipRegion + "<br />";
            aMessage = aMessage + " ShipPostalCode:  :" + ShipPostalCode + "<br />";
            aMessage = aMessage + " Ship Country:" + ShipCountry + "<br />";
            return aMessage;
        }

        //Constructors

        public Orders()
        { }
        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, decimal aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)
            : this()
        {
            this.OrderId = aOrderId;
            this.CustomerId = aCustomerId;
            this.EmployeeId = aEmployeeId;
            this.OrderDate = aOrderDate;
            this.RequiredDate = aRequiredDate;
            this.ShippedDate = aShippedDate;
            this.ShipVia = aShipVia;
            this.Freight = aFreight;
            this.ShipName = aShipName;
            this.ShipAddress = aShipAddress;
            this.ShipCity = aShipCity;
            this.ShipRegion = aShipRegion;
            this.ShipPostalCode = aShipPostalCode;
            this.ShipCountry = aShipCountry;

        }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, decimal aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, decimal aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, decimal aFreight, string aShipName, string aShipAddress, string aShipCity)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, aShipCity, "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, decimal aFreight, string aShipName, string aShipAddress)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, decimal aFreight, string aShipName)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, decimal aFreight)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, 0, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, "n/a", 0, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate)
    : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, "n/a", "n/a", 0, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId, int aEmployeeId)
    : this(aOrderId, aCustomerId, aEmployeeId, "n/a", "n/a", "n/a", 0, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId, string aCustomerId)
    : this(aOrderId, aCustomerId, 0, "n/a", "n/a", "n/a", 0, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Orders(int aOrderId)
    : this(aOrderId, "n/a", 0, "n/a", "n/a", "n/a", 0, 0, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }



    }
}