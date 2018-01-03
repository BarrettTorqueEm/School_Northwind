using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealNorthWind.Models
{
    public class OrderDetails
    {
        #region Gets and Sets
        private int orderId;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private decimal unitPrice;

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        private short quantity;

        public short Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private Single discount;

        public Single Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        #endregion

        #region Constructors
        public OrderDetails() : this(0, 0, 0, 0, 0) { }

        public OrderDetails(int OrderId) : this(OrderId, 0, 0, 0, 0) { }

        public OrderDetails(int OrderId, int ProductId) : this(OrderId, ProductId, 0, 0, 0) { }

        public OrderDetails(int OrderId, int ProductId, decimal UnitPrice) : this(OrderId, ProductId, UnitPrice, 0, 0) { }

        public OrderDetails(int OrderId, int ProductId, decimal UnitPrice, short Quantity) : this(OrderId, ProductId, UnitPrice, Quantity, 0) { }

        public OrderDetails(int OrderId, int ProductId, decimal UnitPrice, short Quantity, int Discount)
        {
            this.OrderId = OrderId;
            this.ProductId = ProductId;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quantity;
            this.Discount = Discount;
        }

        #endregion

        #region Display
        public override string ToString()
        {
            string aMessage = "";

            aMessage = aMessage + "Order Id: " + OrderId + "\n";
            aMessage = aMessage + "ProductId: " + ProductId + "\n";
            aMessage = aMessage + "Unit Price: " + UnitPrice + "\n";
            aMessage = aMessage + "Quantity: " + Quantity + "\n";
            aMessage = aMessage + "Discount: " + Discount + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";

            aMessage = aMessage + "Order Id: " + OrderId + "<br />";
            aMessage = aMessage + "ProductId: " + ProductId + "<br />";
            aMessage = aMessage + "Unit Price: " + UnitPrice + "<br />";
            aMessage = aMessage + "Quantity: " + Quantity + "<br />";
            aMessage = aMessage + "Discount: " + Discount + "<br /><br />";

            return aMessage;
        }
        #endregion

    }
}