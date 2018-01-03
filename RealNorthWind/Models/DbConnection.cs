using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace RealNorthWind.Models
{
    public sealed class DbConnection
    {
        //Creating things
        private List<Category> aListOfCategories = new List<Category>();
        private List<Order> aListOfOrders = new List<Order>();
        private List<Shipper> aListOfShipper = new List<Shipper>();
        private List<Supplier> aListOfSupplier = new List<Supplier>();
        private List<Customers> aListOfCustomer = new List<Customers>();
        private List<OrderDetails> aListOfOrderDetail = new List<OrderDetails>();
        private List<Employees> aListOfEmployee = new List<Employees>();
        private List<Products> aListOfProducts = new List<Products>();
        private static OleDbConnection aConnection = null;

        public static OleDbConnection Instance()
        {
            OleDbConnection myConnection;

            if( DbConnection.aConnection != null)
            {
                myConnection = DbConnection.aConnection;
            }
            else
            {
                myConnection = new OleDbConnection();

            }

            return myConnection;
        }

        #region Get Lists
        public List<Category> GetCategories()
        {

            //OleDbConnection aConnection = new OleDbConnection();

            string aSQL = "SELECT CategoryID, CategoryName, Description FROM Categories;";

            aConnection = DbConnection.Instance();

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aCategoryId = (int)aReader["CategoryID"];
                string aCategoryName = (string)aReader["CategoryName"];
                string aDescription = (string)aReader["Description"];

                Category aCategory = new Category();

                aCategory.CategoryId = aCategoryId;
                aCategory.CategoryName = aCategoryName;
                aCategory.Description = aDescription;


                aListOfCategories.Add(aCategory);
            }

            aConnection.Close();

            return aListOfCategories;

        }

        public List<Order> GetOrder()
        {
            aConnection = DbConnection.Instance();

            string aSQL = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {
                int aOrderID = (int)aReader["OrderID"];
                string aCustomer = (string)aReader["CustomerID"];
                int aEmployee = (int)aReader["EmployeeID"];
                string aOrderDate = aReader["OrderDate"].ToString();
                string aRequiredDate = aReader["RequiredDate"].ToString();
                string aShippedDate = aReader["ShippedDate"].ToString();
                string aShipName = (string)aReader["ShipName"];
                int aShipVia = (int)aReader["ShipVia"];
                decimal aFreight = (decimal)aReader["Freight"];
                string aShipAddress = (string)aReader["ShipAddress"];
                string aShipCity = (string)aReader["ShipCity"];
                string aShipRegion = "N/A";
                string aShipPostalCode = "N/A";
                string aShipCountry = (string)aReader["ShipCountry"];

                if (aReader["ShipRegion"] != System.DBNull.Value)
                {
                    aShipRegion = (string)aReader["ShipRegion"];
                }

                if (aReader["ShipPostalCode"] != System.DBNull.Value)
                {
                    aShipPostalCode = (string)aReader["ShipPostalCode"];
                }

                Order aOrder = new Order();

                aOrder.OrderId = aOrderID;
                aOrder.CustomerId = aCustomer;
                aOrder.EmployeeId = aEmployee;
                aOrder.OrderDate = aOrderDate;
                aOrder.RequiredDate = aRequiredDate;
                aOrder.ShippedDate = aShippedDate;
                aOrder.ShipName = aShipName;
                aOrder.ShipVia = aShipVia;
                aOrder.Freight = aFreight;
                aOrder.ShipAddress = aShipAddress;
                aOrder.ShipCity = aShipCity;
                aOrder.ShipRegion = aShipRegion;
                aOrder.ShipPostalCode = aShipPostalCode;
                aOrder.ShipCountry = aShipCountry;

                aListOfOrders.Add(aOrder);
            }

            aConnection.Close();

            return aListOfOrders;

        }

        public List<Shipper> GetShipper()
        {

            aConnection = DbConnection.Instance();

            string aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aShipperID = (int)aReader["ShipperID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aPhone = (string)aReader["Phone"];

                Shipper aShipper = new Shipper();

                aShipper.ShipperId = aShipperID;
                aShipper.CompanyName = aCompanyName;
                aShipper.Phone = aPhone;

                aListOfShipper.Add(aShipper);
            }
            aConnection.Close();

            return aListOfShipper;
        }

        public List<Supplier> GetSupplier()
        {
            aConnection = DbConnection.Instance();

            string aSQL = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {
                int aSupplierId = (int)aReader["SupplierID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string aAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "n/a";
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                string aFax = "n/a";
                string aHomePage = "n/a";

                if (aReader["Region"] != System.DBNull.Value)
                {
                    aRegion = (string)aReader["Region"];
                }

                if (aReader["Fax"] != System.DBNull.Value)
                {
                    aFax = (string)aReader["Fax"];
                }

                if (aReader["HomePage"] != System.DBNull.Value)
                {
                    aHomePage = (string)aReader["HomePage"];
                }

                Supplier aSupplier = new Supplier();

                aSupplier.SupplierId = aSupplierId;
                aSupplier.CompanyName = aCompanyName;
                aSupplier.ContactName = aContactName;
                aSupplier.ContactTitle = aContactTitle;
                aSupplier.Address = aAddress;
                aSupplier.City = aCity;
                aSupplier.Country = aCountry;
                aSupplier.Phone = aPhone;
                aSupplier.Fax = aFax;
                aSupplier.HomePage = aHomePage;

                aListOfSupplier.Add(aSupplier);
            }

            aConnection.Close();

            return aListOfSupplier;
         }

        public List<Customers> GetCustomers()
        {

            //OleDbConnection aConnection = new OleDbConnection();

            string aSQL = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers;";

            aConnection = DbConnection.Instance();

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                string aCustomerId = (string)aReader["CustomerID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string aAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "N/A";
                string aPostalCode = "N/A";
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                string aFax = "N/A";

                if (aReader["Region"] != System.DBNull.Value) 
                {
                    aRegion = (string)aReader["Region"];
                }

                if (aReader["PostalCode"] != System.DBNull.Value)
                {
                    aPostalCode = (string)aReader["PostalCode"];
                }

                if (aReader["Fax"] != System.DBNull.Value)
                {
                    aFax = (string)aReader["Fax"];
                }

                Customers aCustomer = new Customers();

                aCustomer.CustomerId = aCustomerId;
                aCustomer.CompanyName = aCompanyName;
                aCustomer.ContactName = aContactName;
                aCustomer.ContactTitle = aContactTitle;
                aCustomer.Address = aAddress;
                aCustomer.City = aCity;
                aCustomer.Region = aRegion;
                aCustomer.PostalCode = aPostalCode;
                aCustomer.Country = aCountry;
                aCustomer.Phone = aPhone;
                aCustomer.Fax = aFax;


                aListOfCustomer.Add(aCustomer);
            }

            aConnection.Close();

            return aListOfCustomer;

        }

        public List<OrderDetails> GetOrderDetails()
         {

             aConnection = DbConnection.Instance();

             string aSQL = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details];";

             aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
 Data Source=N:\Northwind1023.mdb";

             aConnection.Open();

             OleDbCommand aCommand = aConnection.CreateCommand();

             aCommand.CommandText = aSQL;

             OleDbDataReader aReader = aCommand.ExecuteReader();

             // Read the data and store it in a list
             while (aReader.Read())
             {

                 int aOrderId = (int)aReader["OrderID"];
                int aProduct = (int)aReader["ProductID"];
                decimal aUnitPrice = (decimal)aReader["UnitPrice"];
                short aQuantity = (short)aReader["Quantity"];
                 Single aDiscount = (Single)aReader["Discount"];

                 OrderDetails aOrderDetails = new OrderDetails();

                 aOrderDetails.OrderId = aOrderId;
                 aOrderDetails.ProductId = aProduct;
                 aOrderDetails.UnitPrice = aUnitPrice;
                 aOrderDetails.Quantity = aQuantity;
                 aOrderDetails.Discount = aDiscount;

                 aListOfOrderDetail.Add(aOrderDetails);
             }
             aConnection.Close();

             return aListOfOrderDetail;
         }

        public List<Employees> GetEmployee()
        {
            aConnection = DbConnection.Instance();

            string aSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, Birthdate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo FROM Employees;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {
                int aEmployeeId = (int)aReader["EmployeeID"];
                string aFirstName = (string)aReader["FirstName"];
                string aLastName = (string)aReader["LastName"];
                string aTitle = (string)aReader["Title"];
                string aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                string aBirthDate = aReader["BirthDate"].ToString();
                string aHireDate = aReader["HireDate"].ToString();
                string aAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "N/A";
                string aPostalCode = (string)aReader["PostalCode"];
                string aCountry = (string)aReader["Country"];
                string aHomePhone = (string)aReader["HomePhone"];
                string aExtension = (string)aReader["Extension"];
                string aPhoto = (string)aReader["Photo"];
                string aNotes = (string)aReader["Notes"];
                string aReportsTo = aReader["ReportsTo"].ToString();

                if (aReader["Region"] != System.DBNull.Value)
                {
                    aRegion = (string)aReader["Region"];
                }

                Employees aEmployee = new Employees();

                aEmployee.EmployeeId = aEmployeeId;
                aEmployee.FirstName = aFirstName;
                aEmployee.LastName = aLastName;
                aEmployee.Title = aTitle;
                aEmployee.TitleOfCourtesy = aTitleOfCourtesy;
                aEmployee.BirthDate = aBirthDate;
                aEmployee.HireDate = aHireDate;
                aEmployee.Address = aAddress;
                aEmployee.City = aCity;
                aEmployee.Region = aRegion;
                aEmployee.PostalCode = aPostalCode;
                aEmployee.Country = aCountry;
                aEmployee.HomePhone = aHomePhone;
                aEmployee.Extension = aExtension;
                aEmployee.Photo = aPhoto;
                aEmployee.Notes = aNotes;
                aEmployee.ReportsTo = aReportsTo;

                aListOfEmployee.Add(aEmployee);
            }

            aConnection.Close();

            return aListOfEmployee;
        }

        public List<Products> GetProduct()
        {
            aConnection = DbConnection.Instance();

            string aSQL = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {
                int aProductId = (int)aReader["ProductID"];
                string aProductName = (string)aReader["ProductName"];
                int aSupplier = (int)aReader["SupplierID"];
                int aCategory = (int)aReader["CategoryID"];
                string aQuantityPerUnit = (string)aReader["QuantityPerUnit"];
                double aUnitPrice = (double)aReader["UnitPrice"];
                int aUnitsInStock = (int)aReader["UnitsInStock"];
                int aUnitsOnOrder = (int)aReader["UnitsOnOrder"];
                int aReorderLevel = (int)aReader["ReorderLevel"];
                bool aDiscontinued = (bool)aReader["Discontinued"];

                Products aProducts = new Products();

                aProducts.ProductID = aProductId;
                aProducts.ProductName = aProductName;
                aProducts.SupplierId = aSupplier;
                aProducts.CategoryId = aCategory;
                aProducts.QuantityPerUnit = aQuantityPerUnit;
                aProducts.UnitPrice = aUnitPrice;
                aProducts.UnitsInStock = aUnitsInStock;
                aProducts.UnitsOnOrder = aUnitsOnOrder;
                aProducts.ReorderLevel = aReorderLevel;
                aProducts.Discontinued = aDiscontinued;

                aListOfProducts.Add(aProducts);
            }

            aConnection.Close();

            return aListOfProducts;
        }

        #endregion

        #region Select Item
        public Category SelectCategory(int id)
        {
            //OleDbConnection aConnection = new OleDbConnection();

            string aSQL = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID = " + id + ";";

            aConnection = DbConnection.Instance();

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            Category aCategory = new Category();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aCategoryId = (int)aReader["CategoryID"];
                string aCategoryName = (string)aReader["CategoryName"];
                string aDescription = (string)aReader["Description"];

                aCategory.CategoryId = aCategoryId;
                aCategory.CategoryName = aCategoryName;
                aCategory.Description = aDescription;
            }

            aConnection.Close();

            return aCategory;

        }

        public Customers SelectCustomer(string id)
        {
            //OleDbConnection aConnection = new OleDbConnection();

            string aSQL = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE CustomerID = '" + id + "';";

            aConnection = DbConnection.Instance();

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            Customers aCustomer = new Customers();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                string aCustomerId = (string)aReader["CustomerID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aContactName = (string)aReader["ContactName"];
                string aContactTitle = (string)aReader["ContactTitle"];
                string aAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "N/A";
                string aPostalCode = "N/A";
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                string aFax = "N/A";

                if (aReader["Region"] != System.DBNull.Value)
                {
                    aRegion = (string)aReader["Region"];
                }

                if (aReader["PostalCode"] != System.DBNull.Value)
                {
                    aPostalCode = (string)aReader["PostalCode"];
                }

                if (aReader["Fax"] != System.DBNull.Value)
                {
                    aFax = (string)aReader["Fax"];
                }



                aCustomer.CustomerId = aCustomerId;
                aCustomer.CompanyName = aCompanyName;
                aCustomer.ContactName = aContactName;
                aCustomer.ContactTitle = aContactTitle;
                aCustomer.Address = aAddress;
                aCustomer.City = aCity;
                aCustomer.Region = aRegion;
                aCustomer.PostalCode = aPostalCode;
                aCustomer.Country = aCountry;
                aCustomer.Phone = aPhone;
                aCustomer.Fax = aFax;


                aListOfCustomer.Add(aCustomer);
            }

            aConnection.Close();

            return aCustomer;

        }

        public Employees SelectEmployee(string id)
        {
            //OleDbConnection aConnection = new OleDbConnection();

            string aSQL = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, Birthdate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo FROM Employees WHERE EmployeeID= " + id + "; ";

            aConnection = DbConnection.Instance();

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            Employees aEmployee = new Employees();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aEmployeeId = (int)aReader["EmployeeID"];
                string aFirstName = (string)aReader["FirstName"];
                string aLastName = (string)aReader["LastName"];
                string aTitle = (string)aReader["Title"];
                string aTitleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                string aBirthDate = aReader["BirthDate"].ToString();
                string aHireDate = aReader["HireDate"].ToString();
                string aAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aRegion = "N/A";
                string aPostalCode = (string)aReader["PostalCode"];
                string aCountry = (string)aReader["Country"];
                string aHomePhone = (string)aReader["HomePhone"];
                string aExtension = (string)aReader["Extension"];
                string aPhoto = (string)aReader["Photo"];
                string aNotes = (string)aReader["Notes"];
                string aReportsTo = aReader["ReportsTo"].ToString();

                if (aReader["Region"] != System.DBNull.Value)
                {
                    aRegion = (string)aReader["Region"];
                }

                aEmployee.EmployeeId = aEmployeeId;
                aEmployee.FirstName = aFirstName;
                aEmployee.LastName = aLastName;
                aEmployee.Title = aTitle;
                aEmployee.TitleOfCourtesy = aTitleOfCourtesy;
                aEmployee.BirthDate = aBirthDate;
                aEmployee.HireDate = aHireDate;
                aEmployee.Address = aAddress;
                aEmployee.City = aCity;
                aEmployee.Region = aRegion;
                aEmployee.PostalCode = aPostalCode;
                aEmployee.Country = aCountry;
                aEmployee.HomePhone = aHomePhone;
                aEmployee.Extension = aExtension;
                aEmployee.Photo = aPhoto;
                aEmployee.Notes = aNotes;
                aEmployee.ReportsTo = aReportsTo;
            }

            aConnection.Close();

            return aEmployee;

        }

        public Shipper SelectShipper(int id)
        {
            //OleDbConnection aConnection = new OleDbConnection();

            string aSQL = "SELECT ShipperID, CompanyName, Phone FROM Shippers WHERE ShipperID = " + id + ";";

            aConnection = DbConnection.Instance();

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            Shipper aShipper = new Shipper();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aShipperId = (int)aReader["ShipperID"];
                string aCompanyName = (string)aReader["CompanyName"];
                string aPhone = (string)aReader["Phone"];

                aShipper.ShipperId = aShipperId;
                aShipper.CompanyName = aCompanyName;
                aShipper.Phone = aPhone;
            }

            aConnection.Close();

            return aShipper;

        }

        public Order SelectOrder(int id)
        {
            //OleDbConnection aConnection = new OleDbConnection();

            string aSQL = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders WHERE OrderID = " + id + "; ";

            aConnection = DbConnection.Instance();

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            Order aOrder = new Order();

            // Read the data and store it in a list
            while (aReader.Read())
            {
                int aOrderID = (int)aReader["OrderID"];
                string aCustomer = (string)aReader["CustomerID"];
                int aEmployee = (int)aReader["EmployeeID"];
                string aOrderDate = aReader["OrderDate"].ToString();
                string aRequiredDate = aReader["RequiredDate"].ToString();
                string aShippedDate = aReader["ShippedDate"].ToString();
                int aShipVia = (int)aReader["ShipVia"];
                decimal aFreight = (decimal)aReader["Freight"];
                string aShipName = (string)aReader["ShipName"];
                string aShipAddress = (string)aReader["ShipAddress"];
                string aShipCity = (string)aReader["ShipCity"];
                string aShipRegion = "N/A";
                string aShipPostalCode = "N/A";
                string aShipCountry = (string)aReader["ShipCountry"];

                if (aReader["ShipRegion"] != System.DBNull.Value)
                {
                    aShipRegion = (string)aReader["ShipRegion"];
                }

                if (aReader["ShipPostalCode"] != System.DBNull.Value)
                {
                    aShipPostalCode = (string)aReader["ShipPostalCode"];
                }

                aOrder.OrderId = aOrderID;
                aOrder.CustomerId = aCustomer;
                aOrder.EmployeeId = aEmployee;
                aOrder.OrderDate = aOrderDate;
                aOrder.RequiredDate = aRequiredDate;
                aOrder.ShippedDate = aShippedDate;
                aOrder.ShipVia = aShipVia;
                aOrder.Freight = aFreight;
                aOrder.ShipName = aShipName;
                aOrder.ShipAddress = aShipAddress;
                aOrder.ShipCity = aShipCity;
                aOrder.ShipRegion = aShipRegion;
                aOrder.ShipPostalCode = aShipPostalCode;
                aOrder.ShipCountry = aShipCountry;
            }

            aConnection.Close();

            return aOrder;

        }
        #endregion

        #region Update Item
        public bool UpdateCategory(int id, string theName, string theDescription)
         {
             aConnection = DbConnection.Instance();

             string aSQL = "UPDATE Categories SET CategoryName='" + theName + "', Description='" + theDescription + "' WHERE CategoryID = " + id + " ;";

             aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
 Data Source=N:\Northwind1023.mdb";

             aConnection.Open();

             OleDbCommand aCommand = aConnection.CreateCommand();

             aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aCategoryId = (int)aReader["CategoryID"];
                string aCategoryName = (string)aReader["CategoryName"];
                string aDescription = (string)aReader["Description"];

                Category aCategory = new Category();

                aCategory.CategoryId = aCategoryId;
                aCategory.CategoryName = aCategoryName;
                aCategory.Description = aDescription;


                aListOfCategories.Add(aCategory);
            }

            aConnection.Close();

             return true;
         }

        public bool UpdateCustomer(string aId, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
        {
            aConnection = DbConnection.Instance();

            string aSQL = "UPDATE Customers SET CompanyName= '" + aCompanyName + "', ContactName= '" + aContactName + "', ContactTitle= '" + aContactTitle+ "', Address= '" + anAddress + "', City= '" + aCity+ "', Region= '" + aRegion + "', PostalCode= '" + aPostalCode + "', Country= '" + aCountry + "', Phone= '" + aPhone + "', Fax= '" + aFax + "' WHERE CustomerID = '" + aId + "';";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                string customerId = (string)aReader["CustomerID"];
                string companyName = (string)aReader["CompanyName"];
                string contactName = (string)aReader["ContactName"];
                string contactTitle = (string)aReader["ContactTitle"];
                string address = (string)aReader["Address"];
                string city = (string)aReader["City"];
                string region = "N/A";
                string postalCode = "N/A";
                string country = (string)aReader["Country"];
                string phone = (string)aReader["Phone"];
                string fax = "N/A";

                if (aReader["Region"] != System.DBNull.Value)
                {
                    region = (string)aReader["Region"];
                }

                if (aReader["PostalCode"] != System.DBNull.Value)
                {
                    postalCode = (string)aReader["PostalCode"];
                }

                if (aReader["Fax"] != System.DBNull.Value)
                {
                    fax = (string)aReader["Fax"];
                }

                Customers aCustomer = new Customers();

                aCustomer.CustomerId = customerId;
                aCustomer.CompanyName = companyName;
                aCustomer.ContactName = contactName;
                aCustomer.ContactTitle = contactTitle;
                aCustomer.Address = address;
                aCustomer.City = city;
                aCustomer.Region = region;
                aCustomer.PostalCode = postalCode;
                aCustomer.Country = country;
                aCustomer.Phone = phone;
                aCustomer.Fax = fax;


                aListOfCustomer.Add(aCustomer);
            }

            aConnection.Close();

            return true;
        }

        public bool UpdateEmployee(string aId, string aLastName, string aFirstName, string aTitle, string aTitleOfCurtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtention, string aPhoto, string aNotes, string aReportsTo)
        {
            aConnection = DbConnection.Instance();

            string aSQL = "Update Employees Set LastName= '" + aLastName + "', FirstName= '" + aFirstName + "', Title= '" + aTitle + "', TitleOfCourtesy= '" + aTitleOfCurtesy + "', Birthdate= '" + aBirthDate + "', HireDate= '" + aHireDate + "', Address= '" + anAddress + "', City= '" + aCity + "', Region= '" + aRegion + "', PostalCode= '" + aPostalCode + "', Country= '" + aCountry + "', HomePhone= '" + aHomePhone + "', Extension= '" + aExtention + "', Photo= '" + aPhoto + "', Notes= '" + aNotes + "', ReportsTo= '" + aReportsTo + "' WHERE EmployeeID= " + aId + "; ";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int employeeId = (int)aReader["EmployeeID"];
                string firstName = (string)aReader["FirstName"];
                string lastName = (string)aReader["LastName"];
                string title = (string)aReader["Title"];
                string titleOfCourtesy = (string)aReader["TitleOfCourtesy"];
                string birthDate = aReader["BirthDate"].ToString();
                string hireDate = aReader["HireDate"].ToString();
                string address = (string)aReader["Address"];
                string city = (string)aReader["City"];
                string region = "N/A";
                string postalCode = (string)aReader["PostalCode"];
                string country = (string)aReader["Country"];
                string homePhone = (string)aReader["HomePhone"];
                string extension = (string)aReader["Extension"];
                string photo = (string)aReader["Photo"];
                string notes = (string)aReader["Notes"];
                string reportsTo = aReader["ReportsTo"].ToString();

                if (aReader["Region"] != System.DBNull.Value)
                {
                    region = (string)aReader["Region"];
                }

                Employees aEmployee = new Employees();

                aEmployee.EmployeeId = employeeId;
                aEmployee.FirstName = firstName;
                aEmployee.LastName = lastName;
                aEmployee.Title = title;
                aEmployee.TitleOfCourtesy = titleOfCourtesy;
                aEmployee.BirthDate = birthDate;
                aEmployee.HireDate = hireDate;
                aEmployee.Address = address;
                aEmployee.City = city;
                aEmployee.Region = region;
                aEmployee.PostalCode = postalCode;
                aEmployee.Country = country;
                aEmployee.HomePhone = homePhone;
                aEmployee.Extension = extension;
                aEmployee.Photo = photo;
                aEmployee.Notes = notes;
                aEmployee.ReportsTo = reportsTo;
            }

            aConnection.Close();

            return true;
        }

        public bool UpdateShipper(int aId, string aCompanyName, string aPhone)
        {
            aConnection = DbConnection.Instance();

            string aSQL = "UPDATE Shippers SET CompanyName='" + aCompanyName + "', Phone='" + aPhone + "' WHERE ShipperID = " + aId + " ;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
 Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aShipperId = (int)aReader["ShipperID"];
                string companyName = (string)aReader["CompanyName"];
                string phone= (string)aReader["Phone"];

                Shipper aShipper = new Shipper();

                aShipper.ShipperId = aShipperId;
                aShipper.CompanyName = companyName;
                aShipper.Phone = phone;


                aListOfShipper.Add(aShipper);
            }

            aConnection.Close();

            return true;
        }

        public bool UpdateOrder(int aId, string aCustomerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, double aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)
        {
            aConnection = DbConnection.Instance();

            string aSQL = "Update Orders Set CustomerID = '" + aCustomerId + "', EmployeeID = " + aEmployeeId+ ", OrderDate = '" + aOrderDate + "', RequiredDate = '" + aRequiredDate + "', ShippedDate = '" + aShippedDate+ "', ShipVia = " + aShipVia + ", Freight = " + aFreight + ", ShipName = '" + aShipName + "', ShipAddress = '" + aShipAddress + "', ShipCity = '" + aShipCity + "', ShipRegion = '" + aShipRegion + "', ShipPostalCode = '" + aShipPostalCode + "', ShipCountry = '" + aShipCountry + "' WHERE OrderId = " + aId + "; ";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=N:\Northwind1023.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int OrderID = (int)aReader["OrderID"];
                string Customer = (string)aReader["CustomerID"];
                int Employee = (int)aReader["EmployeeID"];
                string OrderDate = aReader["OrderDate"].ToString();
                string RequiredDate = aReader["RequiredDate"].ToString();
                string ShippedDate = aReader["ShippedDate"].ToString();
                int ShipVia = (int)aReader["ShipVia"];
                decimal Freight = (decimal)aReader["Freight"];
                string ShipName = (string)aReader["ShipName"];
                string ShipAddress = (string)aReader["ShipAddress"];
                string ShipCity = (string)aReader["ShipCity"];
                string ShipRegion = "N/A";
                string ShipPostalCode = "N/A";
                string ShipCountry = (string)aReader["ShipCountry"];

                if (aReader["ShipRegion"] != System.DBNull.Value)
                {
                    aShipRegion = (string)aReader["ShipRegion"];
                }

                if (aReader["ShipPostalCode"] != System.DBNull.Value)
                {
                    aShipPostalCode = (string)aReader["ShipPostalCode"];
                }

                Order aOrder = new Order();

                aOrder.OrderId = OrderID;
                aOrder.CustomerId = Customer;
                aOrder.EmployeeId = Employee;
                aOrder.OrderDate = OrderDate;
                aOrder.RequiredDate = RequiredDate;
                aOrder.ShippedDate = ShippedDate;
                aOrder.ShipVia = ShipVia;
                aOrder.Freight = Freight;
                aOrder.ShipName = ShipName;
                aOrder.ShipAddress = ShipAddress;
                aOrder.ShipCity = ShipCity;
                aOrder.ShipRegion = ShipRegion;
                aOrder.ShipPostalCode = ShipPostalCode;
                aOrder.ShipCountry = ShipCountry;
            }

            aConnection.Close();

            return true;
        }
        #endregion

    }
}