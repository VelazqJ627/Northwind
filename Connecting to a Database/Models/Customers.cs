using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connecting_to_a_Database.Models
{
    public class Customers
    {
        //private variables
        private string customerId = "n/a";
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";

        //gets and sets
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }

        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }

        public string ContactTitle
        {
            get { return this.contactTitle; }
            set { this.contactTitle = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }

        //ToString

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + " CustomerId: " + CustomerId + "<br />";
            aMessage = aMessage + " CompanyName:" + CompanyName + "<br />";
            aMessage = aMessage + " ContactName:" + ContactName + "<br />";
            aMessage = aMessage + " ContactTitle:" + ContactTitle + "<br />";
            aMessage = aMessage + " Address:" + Address + "<br />";
            aMessage = aMessage + " City:" + City +"<br />";
            aMessage = aMessage + " Region:" + Region + "<br />";
            aMessage = aMessage + " PostalCode:" + PostalCode + "<br />";
            aMessage = aMessage + " Country:" + Country + "<br />";
            aMessage = aMessage + " Phone:" + Phone + "<br />";
            aMessage = aMessage + " Fax:" + Fax + "<br />";
            return aMessage;
        }

        //Constructors

        public Customers()
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone)
            : this(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry)
            : this(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, "n/a", "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode)
            : this(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, "n/a", "n/a", "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion)
            : this(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, "n/a", "n/a", "n/a", "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity)
            : this(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress)
            : this(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle)
            : this(aCustomerId, aCompanyName, aContactName, aContactTitle, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName)
            : this(aCustomerId, aCompanyName, aContactName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName)
            : this(aCustomerId, aCompanyName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Customers(string aCustomerId)
            : this(aCustomerId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        { }

        public Customers(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
            : this()
        {
            this.CustomerId = aCustomerId;
            this.CompanyName = aCompanyName;
            this.ContactName = aContactName;
            this.ContactTitle = aContactTitle;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Fax = aFax;
        }
    }
}