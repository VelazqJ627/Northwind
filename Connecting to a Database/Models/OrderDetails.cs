using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connecting_to_a_Database.Models
{
    public class OrderDetails
    {
        //private variables
        private int orderId = 0;
        private int productId = 0;
        private decimal unitPrice = 0;
        private int quantity = 0;
        private int discount = 0; 

        // get and sets

        public int OrderId
        {
            get {return this.orderId; }
            set { this.orderId = value; }
        }

        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public decimal UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public int Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }

        //Tostring 
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + " OrderId: " + OrderId + "<br />";
            aMessage = aMessage + " ProductId: " + ProductId + "<br />";
            aMessage = aMessage + "Unit Price: " + UnitPrice + "<br />";
            aMessage = aMessage + "Quantity: " + Quantity + "<br />";
            aMessage = aMessage + " Discount:  :" + Discount + "<br />";
            return aMessage;
        }
        //Constructors

        public OrderDetails()
            {}
        public OrderDetails(int aOrderId, int aProductId, decimal aUnitPrice, int aQuantity, int aDiscount )
            : this()
        {
            this.OrderId = aOrderId;
            this.ProductId = aProductId;
            this.Quantity = aQuantity;
            this.UnitPrice = aUnitPrice;
            this.Discount = aDiscount;
        }
        public OrderDetails(int aOrderId, int aProductId, decimal aUnitPrice, int aQuantity)
           : this(aOrderId, aProductId, aUnitPrice, aQuantity, 0)
        { }

        public OrderDetails(int aOrderId, int aProductId, decimal aUnitPrice)
           : this(aOrderId, aProductId, aUnitPrice, 0, 0)
        { }

        public OrderDetails(int aOrderId, int aProductId)
           : this(aOrderId, aProductId, 0, 0, 0)
        { }

        public OrderDetails(int aOrderId)
           : this(aOrderId, 0, 0, 0, 0)
        { }

    }
}