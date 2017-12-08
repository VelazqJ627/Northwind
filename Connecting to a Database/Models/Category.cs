using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connecting_to_a_Database.Models
{
    public class Category
    {
        //private variables
        private int categoryId = 0;
        private string categoryName = "n/a";
        private string description = "n/a";

        //gets and set

        public int CategoryId
        {
            get { return this.categoryId; }
            set { this.categoryId = value; }
        }

        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value ; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value ; }
        }

        //tostring

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "CategoryID=" + CategoryId + "</ br>";
            aMessage = aMessage + "CategoryName=" + CategoryName + "</ br>";
            aMessage = aMessage + "Description=" + Description + "</ br>";
            return aMessage;
        }

        //COnstructors
        public Category()
        { }

        public Category(int aCategoryId, string aCategoryName, string aDescription)
            :this()
        {
            this.CategoryId = aCategoryId;
            this.CategoryName = aCategoryName;
            this.Description = aDescription;

        }

        public Category(int aCategoryId, string aCategoryName)
            : this(aCategoryId, aCategoryName, "n/a")
        { }

        public Category(int aCategoryId)
            : this(aCategoryId, "n/a", "n/a")
        { }


    }
}