using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connecting_to_a_Database.Models
{
    public class Shippers
    {
        //private Variables
        private int shipperId = 0;
        private string companyName = "n/a";
        private string phone = "n/a";

        //gets and sets
        public int ShipperId
        {
            get { return this.shipperId; }
            set { this.shipperId = value; }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        //ToString
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + " ShipperId:" + ShipperId + "<br />";
            aMessage = aMessage + " COmpanyName:" + CompanyName + "<br />";
            aMessage = aMessage + "Phone:" + Phone + "<br />";
            return aMessage;
        }

        //COnstructors
        public Shippers()
        { }

        public Shippers(int aShipperId)
            : this(aShipperId, "n/a", "n/a")
        { }

        public Shippers(int aShipperId, string aCompanyName)
            : this(aShipperId, aCompanyName, "n/a")
        { }

        public Shippers(int aShipperId, string aCompanyName, string aPhone)
            : this()
        {
            this.ShipperId = aShipperId;
            this.CompanyName = aCompanyName;
            this.Phone = aPhone;

        }
    }
}