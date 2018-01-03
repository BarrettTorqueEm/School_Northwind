using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealNorthWind.Models
{
    public class Shipper
    {
        #region Gets and Sets
        private int shipperId;

        public int ShipperId
        {
            get { return shipperId; }
            set { shipperId = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        #endregion

        #region Constructors
        public Shipper() : this(0, "N/A", "N/A") { }

        public Shipper(int ShipperId) : this(ShipperId, "N/A", "N/A") { }

        public Shipper(int ShipperId, string CompanyName) : this(ShipperId, CompanyName, "N/A") { }

        public Shipper(int ShipperId, string CompanyName, string Phone)
        {
            this.ShipperId = ShipperId;
            this.CompanyName = CompanyName;
            this.Phone = Phone;
        }
        #endregion

        #region Display
        public override string ToString()
        {
            string aMessage = "";

            aMessage = aMessage + "Shipper Id: " + ShipperId + "\n";
            aMessage = aMessage + "Company Name: " + CompanyName + "\n";
            aMessage = aMessage + "Phone: " + Phone + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";

            aMessage = aMessage + "Shipper Id: " + ShipperId + "<br />";
            aMessage = aMessage + "Company Name: " + CompanyName + "<br />";
            aMessage = aMessage + "Phone: " + Phone + "<br /><br />";

            return aMessage;
        }
        #endregion
    }
}