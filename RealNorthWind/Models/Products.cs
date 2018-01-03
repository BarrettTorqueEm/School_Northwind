using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealNorthWind.Models
{
    public class Products
    {
        #region //Gets and Sets
        private int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private int supplierId;

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        private int categoryId;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        private string quantityPerUnit;

        public string QuantityPerUnit
        {
            get { return quantityPerUnit; }
            set { quantityPerUnit = value; }
        }

        private double unitPrice;

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        private int unitsInStock;

        public int UnitsInStock
        {
            get { return unitsInStock; }
            set { unitsInStock = value; }
        }

        private int unitsOnOrder;

        public int UnitsOnOrder
        {
            get { return unitsOnOrder; }
            set { unitsOnOrder = value; }
        }

        private int reorderLevel;

        public int ReorderLevel
        {
            get { return reorderLevel; }
            set { reorderLevel = value; }
        }

        private bool discontinued;

        public bool Discontinued
        {
            get { return discontinued; }
            set { discontinued = value; }
        }
        #endregion

        #region //Constructors
        public Products()
            : this(0, "N/A", 0, 0, "N/A", 0, 0, 0, 0, false) { }

        public Products(int ProductID)
            : this(ProductID, "N/A", 0, 0, "N/A", 0, 0, 0, 0, false) { }

        public Products(int ProductID, string ProductName)
            : this(ProductID, ProductName, 0, 0, "N/A", 0, 0, 0, 0, false) { }

        public Products(int ProductID, string ProductName, int SupplierIdId)
            : this(ProductID, ProductName, 0, 0, "N/A", 0, 0, 0, 0, false) { }

        public Products(int ProductID, string ProductName, int SupplierId, int CategoryId)
            : this(ProductID, ProductName, SupplierId, CategoryId, "N/A", 0, 0, 0, 0, false) { }

        public Products(int ProductID, string ProductName, int SupplierId, int CategoryId, string QuantityPerUnit)
            : this(ProductID, ProductName, SupplierId, CategoryId, QuantityPerUnit, 0, 0, 0, 0, false) { }

        public Products(int ProductID, string ProductName, int SupplierId, int CategoryId, string QuantityPerUnit, double UnitPrice)
            : this(ProductID, ProductName, SupplierId, CategoryId, QuantityPerUnit, UnitPrice, 0, 0, 0, false) { }

        public Products(int ProductID, string ProductName, int SupplierId, int CategoryId, string QuantityPerUnit, double UnitPrice, int UnitsInStock)
            : this(ProductID, ProductName, SupplierId, CategoryId, QuantityPerUnit, UnitPrice, UnitsInStock, 0, 0, false) { }

        public Products(int ProductID, string ProductName, int SupplierId, int CategoryId, string QuantityPerUnit, double UnitPrice, int UnitsInStock, int UnitsOnOrder)
            : this(ProductID, ProductName, SupplierId, CategoryId, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, 0, false) { }

        public Products(int ProductID, string ProductName, int SupplierId, int CategoryId, string QuantityPerUnit, double UnitPrice, int UnitsInStock, int UnitsOnOrder, int ReorderLevel, bool Discontinued)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.SupplierId = SupplierId;
            this.CategoryId = CategoryId;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitPrice = UnitPrice;
            this.UnitsInStock = UnitsInStock;
            this.UnitsOnOrder = UnitsOnOrder;
            this.ReorderLevel = ReorderLevel;
            this.Discontinued = Discontinued;
        }
        #endregion

        #region Display
        //ToString Method
        public override string ToString()
        {
            string aMessage = "";

            aMessage = aMessage + "Product Id: " + ProductID + "\n";
            aMessage = aMessage + "Product Name: " + ProductName + "\n";
            aMessage = aMessage + "SupplierId: " + SupplierId + "\n";
            aMessage = aMessage + "CategoryId: " + CategoryId + "\n";
            aMessage = aMessage + "Quantity Per Unit: " + QuantityPerUnit + "\n";
            aMessage = aMessage + "Unit Price: " + UnitPrice + "\n";
            aMessage = aMessage + "Units In Stock: " + UnitsInStock + "\n";
            aMessage = aMessage + "Units On Order: " + UnitsOnOrder + "\n";
            aMessage = aMessage + "Reorder Level: " + ReorderLevel + "\n";
            aMessage = aMessage + "Discontinued: " + Discontinued + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";

            aMessage = aMessage + "Product Id: " + ProductID + "<br />";
            aMessage = aMessage + "Product Name: " + ProductName + "<br />";
            aMessage = aMessage + "SupplierId: " + SupplierId + "<br />";
            aMessage = aMessage + "CategoryId: " + CategoryId + "<br />";
            aMessage = aMessage + "Quantity Per Unit: " + QuantityPerUnit + "<br />";
            aMessage = aMessage + "Unit Price: " + UnitPrice + "<br />";
            aMessage = aMessage + "Units In Stock: " + UnitsInStock + "<br />";
            aMessage = aMessage + "Units On Order: " + UnitsOnOrder + "<br />";
            aMessage = aMessage + "Reorder Level: " + ReorderLevel + "<br />";
            aMessage = aMessage + "Discontinued: " + Discontinued + "<br /><br />";

            return aMessage;
        }
        #endregion
    }
}