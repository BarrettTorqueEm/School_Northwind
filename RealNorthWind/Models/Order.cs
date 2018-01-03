using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealNorthWind.Models
{
    public class Order
    {
        #region//Gets and Sets
        private int orderId = 0;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        private string customerId;

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        private int employeeId;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        private string orderDate = "N/A";

        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        private string requiredDate;

        public string RequiredDate
        {
            get { return requiredDate; }
            set { requiredDate = value; }
        }

        private string shippedDate;

        public string ShippedDate
        {
            get { return shippedDate; }
            set { shippedDate = value; }
        }

        private string shipName;

        public string ShipName
        {
            get { return shipName; }
            set { shipName = value; }
        }

        private int shipVia;

        public int ShipVia
        {
            get { return shipVia; }
            set { shipVia = value; }
        }

        private decimal freight;

        public decimal Freight
        {
            get { return freight; }
            set { freight = value; }
        }

        private string shipAddress;

        public string ShipAddress
        {
            get { return shipAddress; }
            set { shipAddress = value; }
        }

        private string shipCity;

        public string ShipCity
        {
            get { return shipCity; }
            set { shipCity = value; }
        }

        private string shipRegion;

        public string ShipRegion
        {
            get { return shipRegion; }
            set { shipRegion = value; }
        }

        private string shipPostalCode;

        public string ShipPostalCode
        {
            get { return shipPostalCode; }
            set { shipPostalCode = value; }
        }

        private string shipCountry;

        public string ShipCountry
        {
            get { return shipCountry; }
            set { shipCountry = value; }
        }

        #endregion

        #region//Constructors
        public Order() : this(0, "N/A", 0, "N/A", "N/A", "N/A", "N/A", 0, 0, "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId) : this(aOrderId, "N/A", 0, "N/A", "N/A", "N/A", "N/A", 0, 0, "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId) : this(aOrderId, aCustomerId, 0, "N/A", "N/A", "N/A", "N/A", 0, 0, "N/A", "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId) : this(aOrderId, aCustomerId, aEmployeeId, "N/A", "N/A", "N/A", "N/A", 0, 0, "N/A", "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, "N/A", "N/A", "N/A", 0, 0, "N/A", "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, "N/A", "N/A", 0, 0, "N/A", "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipName) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, "N/A", 0, 0, "N/A", "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipName, int aShipVia) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipName, 0, 0, "N/A", "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipName, int aShipVia, decimal aFreight) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipName, aShipVia, 0, "N/A", "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipName, int aShipVia, decimal aFreight, string aShipAddress) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipName, aShipVia, aFreight, aShipAddress, "N/A", "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipName, int aShipVia, decimal aFreight, string aShipAddress, string aShipCity) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipName, aShipVia, aFreight, aShipAddress, aShipCity, "N/A", "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipName, int aShipVia, decimal aFreight, string aShipAddress, string aShipCity, string aShipRegion) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipName, aShipVia, aFreight, aShipAddress, aShipCity, aShipRegion, "N/A", "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipName, int aShipVia, decimal aFreight, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode) : this(aOrderId, aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipName, aShipVia, aFreight, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, "N/A") { }
        public Order(int aOrderId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipName, int aShipVia, decimal aFreight, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)
        {
            this.OrderId = aOrderId;
            this.CustomerId = aCustomerId;
            this.EmployeeId = aEmployeeId;
            this.OrderDate = aOrderDate;
            this.RequiredDate = aRequiredDate;
            this.ShippedDate = aShippedDate;
            this.ShipName = aShipName;
            this.ShipVia = aShipVia;
            this.Freight = aFreight;
            this.ShipAddress = aShipAddress;
            this.ShipCity = aShipCity;
            this.ShipRegion = aShipRegion;
            this.ShipPostalCode = aShipPostalCode;
            this.ShipCountry = aShipCountry;
        }
        #endregion

        #region Display
        //ToString() Method for cmd
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "Order Id = " + OrderId + "\n";
            aMessage = aMessage + "CustomerId = " + CustomerId + "\n";
            aMessage = aMessage + "EmployeeId = " + EmployeeId + "\n";
            aMessage = aMessage + "Order Date = " + OrderDate + "\n";
            aMessage = aMessage + "Required Date = " + RequiredDate + "\n";
            aMessage = aMessage + "Shipped Date = " + ShippedDate + "\n";
            aMessage = aMessage + "Ship Name = " + ShipName + "\n";
            aMessage = aMessage + "Ship Via = " + ShipVia + "\n";
            aMessage = aMessage + "Freight = " + Freight + "\n";
            aMessage = aMessage + "Ship Address = " + ShipAddress + "\n";
            aMessage = aMessage + "Ship City = " + ShipCity + "\n";
            aMessage = aMessage + "Ship Region = " + ShipRegion + "\n";
            aMessage = aMessage + "Ship Postal Code = " + ShipPostalCode + "\n";
            aMessage = aMessage + "Ship Country = " + ShipCountry + "\n";
            return aMessage;
        }

        //Display Method for web
        public string Display()
        {
            string aMessage = "";
            aMessage = aMessage + "Order Id = " + OrderId + "<br />";
            aMessage = aMessage + "CustomerId = " + CustomerId + "<br />";
            aMessage = aMessage + "EmployeeId = " + EmployeeId + "<br />";
            aMessage = aMessage + "Order Date = " + OrderDate + "<br />";
            aMessage = aMessage + "Required Date = " + RequiredDate + "<br />";
            aMessage = aMessage + "Shipped Date = " + ShippedDate + "<br />";
            aMessage = aMessage + "Ship Name = " + ShipName + "<br />";
            aMessage = aMessage + "Ship Via = " + ShipVia + "<br />";
            aMessage = aMessage + "Freight = " + Freight + "<br />";
            aMessage = aMessage + "Ship Address = " + ShipAddress + "<br />";
            aMessage = aMessage + "Ship City = " + ShipCity + "<br />";
            aMessage = aMessage + "Ship Region = " + ShipRegion + "<br />";
            aMessage = aMessage + "Ship Postal Code = " + ShipPostalCode + "<br />";
            aMessage = aMessage + "Ship Country = " + ShipCountry + "<br />";
            return aMessage;
        }
        #endregion
    }
}