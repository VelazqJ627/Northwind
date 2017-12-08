using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connecting_to_a_Database.Models
{
    public class Product
    {
        //private varaibles
        private int productId = 0;
        private string productName = "n/a";
        private string quantityPerUnit = "n/a";
        private decimal unitPrice = 0;
        private int unitsInStock = 0;
        private int unitsOnOrder = 0;
        private int reorderLevel = 0;
        private bool discontinued = false;

        //gets and sets
        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }
        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value;}
        }
        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value; }
        }
        public decimal UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }
        public int UnitsInStock
        {
            get { return this.unitsInStock; }
            set { this.unitsInStock = value; }
        }
        public int UnitsOnOrder
        {
            get { return this.unitsOnOrder; }
            set { this.unitsOnOrder = value; }
        }

        public int ReorderLevel
        {
            get { return this.reorderLevel; }
            set { this.reorderLevel = value; }
        }
        public bool Discontinued
        {
            get { return this.discontinued; }
            set { this.discontinued = value; }
        }

        //ToString()
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + " ProductId: " + ProductId + "<br />";
            aMessage = aMessage + "ProductName" + ProductName + "<br />";
            aMessage = aMessage + "Quantity Per Unit :" + QuantityPerUnit + "<br />";
            aMessage = aMessage + "Unit Price:" + UnitPrice + "<br />";
            aMessage = aMessage + "Units in Stock :" + UnitsInStock + "<br />";
            aMessage = aMessage + "Units On Order:" + UnitsOnOrder + "<br />";
            aMessage = aMessage + "Reorder Level:" + ReorderLevel + "<br />";
            aMessage = aMessage + "Discontinued" + Discontinued + "<br />";
            return aMessage;
        }
        //Constructors
        public Product()
        { }
        public Product(int aProductId, string aProductName, string aQuantityPerUnit, decimal aUnitPrice, int aUnitsInStock, int aUnitsOnOrder, int aReorderLevel, bool aDiscontinued)
            : this()
        {
            this.ProductId = aProductId;
            this.ProductName = aProductName;
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.UnitsInStock = aUnitsInStock;
            this.UnitsOnOrder = aUnitsOnOrder;
            this.ReorderLevel = aReorderLevel;
            this.Discontinued = aDiscontinued;
        }

        public Product(int aProductId, string aProductName, string aQuantityPerUnit, decimal aUnitPrice, int aUnitsInStock, int aUnitsOnOrder, int aReorderLevel)
            : this(aProductId, aProductName, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, aReorderLevel, false)
        { }

        public Product(int aProductId, string aProductName, string aQuantityPerUnit, decimal aUnitPrice, int aUnitsInStock, int aUnitsOnOrder)
            : this(aProductId, aProductName, aQuantityPerUnit, aUnitPrice, aUnitsInStock, aUnitsOnOrder, 0, false)
        { }

        public Product(int aProductId, string aProductName, string aQuantityPerUnit, decimal aUnitPrice, int aUnitsInStock)
            : this(aProductId, aProductName, aQuantityPerUnit, aUnitPrice, aUnitsInStock, 0, 0, false)
        { }

        public Product(int aProductId, string aProductName, string aQuantityPerUnit, decimal aUnitPrice)
            : this(aProductId, aProductName, aQuantityPerUnit, aUnitPrice, 0, 0, 0, false)
        { }

        public Product(int aProductId, string aProductName, string aQuantityPerUnit)
            : this(aProductId, aProductName, aQuantityPerUnit, 0, 0, 0, 0, false)
        { }

        public Product(int aProductId, string aProductName)
            : this(aProductId, aProductName, "n/a", 0, 0, 0, 0, false)
        { }

        public Product(int aProductId)
            : this(aProductId, "n/a", "n/a", 0, 0, 0, 0, false)
        { }


    }
}