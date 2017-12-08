using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connecting_to_a_Database.Models
{
    public class Employees
    {
        //private variables
        private int employeeId = 0;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string photo = "n/a";
        private string notes = "n/a";
        private string reportsTo = "n/a";
        private bool active = false;

        //gets and sets
        public int EmployeeId
        {
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }

        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public string HireDate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }
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

        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }

        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }

        public string Photo
        {
            get { return this.photo; }
            set { this.photo = value; }
        }

        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public string ReportsTo
        {
            get { return this.reportsTo; }
            set { this.reportsTo = value; }
        }

        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }

        //ToString
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + " EmployeeId:" + EmployeeId + "<br />";
            aMessage = aMessage + " LastName:" + LastName + "<br />";
            aMessage = aMessage + " FirstName:" + FirstName + "<br />";
            aMessage = aMessage + " Title:" + Title + "<br />";
            aMessage = aMessage + " TitleOfCourtesy:" + TitleOfCourtesy + "<br />";
            aMessage = aMessage + " BirthDate:" + BirthDate + "<br />";
            aMessage = aMessage + " HireDate:" + HireDate + "<br />";
            aMessage = aMessage + " Address:" + Address + "<br />";
            aMessage = aMessage + " City:" + City + "<br />";
            aMessage = aMessage + " Region:" + Region + "<br />";
            aMessage = aMessage + " PostalCode:" + PostalCode + "<br />";
            aMessage = aMessage + " Country:" + Country + "<br />";
            aMessage = aMessage + " HomePhone:" + HomePhone + "<br />";
            aMessage = aMessage + " Extension:" + Extension + "<br />";
            aMessage = aMessage + " Photo:" + Photo + "<br />";
            aMessage = aMessage + " Notes:" + Notes + "<br />";
            aMessage = aMessage + " ReportsTo:" + ReportsTo + "<br />";
            aMessage = aMessage + " Active:" + Active + "<br />";
            return aMessage;
        }

        //constructors
        public Employees()
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aPhoto, string aNotes, string aReportsTo)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, aNotes, aReportsTo, false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aPhoto, string aNotes)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, aNotes, "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aPhoto)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle)
            : this(aEmployeeId, aLastName, aFirstName, aTitle, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName, string aFirstName)
            : this(aEmployeeId, aLastName, aFirstName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId, string aLastName)
            : this(aEmployeeId, aLastName, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }

        public Employees(int aEmployeeId)
            : this(aEmployeeId, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", false)
        { }
        public Employees(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aPhoto, string aNotes, string aReportsTo, bool aActive)
            : this()
        {
            this.EmployeeId = aEmployeeId;
            this.LastName = aLastName;
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.BirthDate = aBirthDate;
            this.HireDate = aHireDate;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.HomePhone = aHomePhone;
            this.Extension = aExtension;
            this.Photo = aPhoto;
            this.Notes = aNotes;
            this.ReportsTo = aReportsTo;
            this.Active = aActive;
        }




    }
}