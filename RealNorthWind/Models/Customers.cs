using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealNorthWind.Models
{
    public class Customers
    {
        #region Gets and Sets
        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string contactName;

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        private string  contactTitle;

        public string  ContactTitle
        {
            get { return contactTitle; }
            set { contactTitle = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string region;

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        private string postalCode;

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string  phone;

        public string  Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string fax;

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        #endregion

        #region Constructors
        public Customers()
            : this("N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId)
            : this(CustomerId, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName)
            : this(CustomerId, CompanyName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName)
            : this(CustomerId, CompanyName, ContactName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName, string ContactTitle)
            : this(CustomerId, CompanyName, ContactName, ContactTitle, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName, string ContactTitle, string Address)
            : this(CustomerId, CompanyName, ContactName, ContactTitle, Address, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName, string ContactTitle, string Address, string City)
            : this(CustomerId, CompanyName, ContactName, ContactTitle, Address, City, "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region)
            : this(CustomerId, CompanyName, ContactName, ContactTitle, Address, City, Region, "N/A", "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode)
            : this(CustomerId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, "N/A", "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country)
            : this(CustomerId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, "N/A", "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone) 
            : this(CustomerId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, "N/A") { }

        public Customers(string CustomerId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax)
        {
            this.CustomerId = CustomerId;
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.ContactTitle = ContactTitle;
            this.Address = Address;
            this.City = City;
            this.Region = Region;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.Phone = Phone;
            this.Fax = Fax;
        }
        #endregion

        #region Display
        public override string ToString()
        {
            string aMessage = "";

            aMessage = aMessage + "Customer Id: " + CustomerId + "\n";
            aMessage = aMessage + "Company Name: " + CompanyName + "\n";
            aMessage = aMessage + "Contact Name: " + ContactName + "\n";
            aMessage = aMessage + "Contact Title: " + ContactTitle + "\n";
            aMessage = aMessage + "Address: " + Address + "\n";
            aMessage = aMessage + "City: " + City + "\n";
            aMessage = aMessage + "Region: " + Region + "\n";
            aMessage = aMessage + "Postal Code: " + PostalCode + "\n";
            aMessage = aMessage + "Country: " + Country + "\n";
            aMessage = aMessage + "Phone: " + Phone + "\n";
            aMessage = aMessage + "Fax: " + Fax + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";

            aMessage = aMessage + "Customer Id: " + CustomerId + "<br />";
            aMessage = aMessage + "Company Name: " + CompanyName + "<br />";
            aMessage = aMessage + "Contact Name: " + ContactName + "<br />";
            aMessage = aMessage + "Contact Title: " + ContactTitle + "<br />";
            aMessage = aMessage + "Address: " + Address + "<br />";
            aMessage = aMessage + "City: " + City + "<br />";
            aMessage = aMessage + "Region: " + Region + "<br />";
            aMessage = aMessage + "Postal Code: " + PostalCode + "<br />";
            aMessage = aMessage + "Country: " + Country + "<br />";
            aMessage = aMessage + "Phone: " + Phone + "<br />";
            aMessage = aMessage + "Fax: " + Fax + "<br /><br />";

            return aMessage;
        }
        #endregion
    }
}