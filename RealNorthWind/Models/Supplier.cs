using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealNorthWind.Models
{
    public class Supplier
    {
        #region Gets and Sets
        private int supplierId;

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
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

        private string contactTitle;

        public string ContactTitle
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

        private string phone;

        public string Phone
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

        private string homePage;

        public string HomePage
        {
            get { return homePage; }
            set { homePage = value; }
        }
        #endregion

        #region Constructors
        public Supplier()
            : this(0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId)
            : this(SupplierId, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName)
            : this(SupplierId, CompanyName, ContactName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle)
            : this(SupplierId, CompanyName, ContactName, ContactTitle, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle, string Address)
            : this(SupplierId, CompanyName, ContactName, ContactTitle, Address, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle, string Address, string City)
            : this(SupplierId, CompanyName, ContactName, ContactTitle, Address, City, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region)
            : this(SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode)
            : this(SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, "N/A", "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country)
            : this(SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, "N/A", "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone) 
            : this(SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, "N/A", "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax) 
            : this(SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, "N/A") { }

        public Supplier(int SupplierId, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage)
        {
            this.SupplierId = SupplierId;
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
            this.HomePage = HomePage;
        }
        #endregion

        #region Display
        public override string ToString()
        {
            string aMessage = "";

            aMessage = aMessage + "Supplier Id: " + SupplierId + "\n";
            aMessage = aMessage + "Company Name: " + CompanyName + "\n";
            aMessage = aMessage + "Contact Name: " + ContactName + "\n";
            aMessage = aMessage + "Contact Title: " + ContactTitle + "\n";
            aMessage = aMessage + "Address: " + Address + "\n";
            aMessage = aMessage + "City: " + City + "\n";
            aMessage = aMessage + "Region: " + Region + "\n";
            aMessage = aMessage + "Postal Code: " + PostalCode + "\n";
            aMessage = aMessage + "County: " + Country + "\n";
            aMessage = aMessage + "Phone: " + Phone + "\n";
            aMessage = aMessage + "Fax: " + Fax + "\n";
            aMessage = aMessage + "Home Page: " + HomePage + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";

            aMessage = aMessage + "Supplier Id: " + SupplierId + "<br />";
            aMessage = aMessage + "Company Name: " + CompanyName + "<br />";
            aMessage = aMessage + "Contact Name: " + ContactName + "<br />";
            aMessage = aMessage + "Contact Title: " + ContactTitle + "<br />";
            aMessage = aMessage + "Address: " + Address + "<br />";
            aMessage = aMessage + "City: " + City + "<br />";
            aMessage = aMessage + "Region: " + Region + "<br />";
            aMessage = aMessage + "Postal Code: " + PostalCode + "<br />";
            aMessage = aMessage + "County: " + Country + "<br />";
            aMessage = aMessage + "Phone: " + Phone + "<br />";
            aMessage = aMessage + "Fax: " + Fax + "<br />";
            aMessage = aMessage + "Home Page: " + "<br /><br />";

            return aMessage;
        }
        #endregion
    }
}