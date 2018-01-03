using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealNorthWind.Models;

namespace RealNorthWind.Controllers
{
    public class HomeController : Controller
    {
        private DbConnection aConnection = new DbConnection();
        public ActionResult Index()
        {
            return View();
        }

        #region List items
        public ActionResult ListCategory()
        {
            List<Category> aListOfCategory = null;
            aListOfCategory = aConnection.GetCategories();
            ViewBag.aListOfCategory = aListOfCategory;
            return View();
        }

        public ActionResult ListProduct()
        {
            List<Products> aListOfProduct = null;
            aListOfProduct = aConnection.GetProduct();
            ViewBag.aListOfProduct = aListOfProduct;
            return View();
        }

        public ActionResult ListOrder()
        {
            List<Order> aListOfOrder = null;
            aListOfOrder = aConnection.GetOrder();
            ViewBag.aListOfOrder = aListOfOrder;
            return View();
        }

        public ActionResult ListEmployee()
        {
            List<Employees> aListOfEmployee = null;
            aListOfEmployee = aConnection.GetEmployee();
            ViewBag.aListOfEmployee = aListOfEmployee;
            return View();
        }

        public ActionResult ListSupplier()
        {
            List<Supplier> aListOfSupplier = null;
            aListOfSupplier = aConnection.GetSupplier();
            ViewBag.aListOfSupplier = aListOfSupplier;
            return View();
        }

        public ActionResult ListShipper()
        {
            List<Shipper> aListOfShipper = null;
            aListOfShipper = aConnection.GetShipper();
            ViewBag.aListOfShipper = aListOfShipper;
            return View();
        }

        public ActionResult ListCustomer()
        {
            List<Customers> aListOfCustomer = null;
            aListOfCustomer = aConnection.GetCustomers();
            ViewBag.aListOfCustomer = aListOfCustomer;
            return View();
        }
        #endregion

        #region Update items
        public ActionResult GetUpdateCategory(int id)
        {
            Category aListOfCategory = null;
            aListOfCategory = aConnection.SelectCategory(id);
            ViewBag.ACategory = aListOfCategory;
            return View();
        }

        public ActionResult GetUpdateCustomer(string id)
        {
            Customers aListOfCustomers = null;
            aListOfCustomers = aConnection.SelectCustomer(id);
            ViewBag.ACustomer = aListOfCustomers;
            return View();
        }

        public ActionResult GetUpdateEmployee(string id)
        {
            Employees aListOfEmployee = null;
            aListOfEmployee = aConnection.SelectEmployee(id);
            ViewBag.AEmployee = aListOfEmployee;
            return View();
        }

        public ActionResult GetUpdateShipper(int id)
        {
            Shipper aListOfShipper = null;
            aListOfShipper = aConnection.SelectShipper(id);
            ViewBag.AShipper = aListOfShipper;
            return View();
        }

        public ActionResult GetUpdateOrder(int id)
        {
            Order aListOfOrder = null;
            aListOfOrder = aConnection.SelectOrder(id);
            ViewBag.AOrder = aListOfOrder;
            return View();
        }


        public ActionResult UpdateCategory(int aId, string aName, string aDescription)
        {
            bool completed = aConnection.UpdateCategory(aId, aName, aDescription);

            if (completed)
            {
                return View();
            }
            else
            {
                //Return a failed view 
                return View();
            }
        }
      
        public ActionResult UpdateCustomer(string aId, string aCompanyName, string aContactName, string aContactTitle, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
        {
            bool completed = aConnection.UpdateCustomer(aId, aCompanyName, aContactName, aContactTitle, anAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax);

            if (completed)
            {
                return View();
            }
            else
            {
                //Return a failed view 
                return View();
            }
        }

        public ActionResult UpdateEmployee(string aId, string aLastName, string aFirstName, string aTitle, string aTitleOfCurtesy, string aBirthDate, string aHireDate, string anAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtention, string aPhoto, string aNotes, string aReportsTo)
        {
            bool completed = aConnection.UpdateEmployee(aId, aLastName, aFirstName, aTitle, aTitleOfCurtesy, aBirthDate, aHireDate, anAddress, aCity,aRegion, aPostalCode, aCountry, aHomePhone, aExtention, aPhoto, aNotes, aReportsTo);

            if (completed)
            {
                return View();
            }
            else
            {
                //Return a failed view 
                return View();
            }
        }

        public ActionResult UpdateShipper(int aId, string aCompanyName, string aPhone)
        {
            bool completed = aConnection.UpdateShipper(aId, aCompanyName, aPhone);

            if (completed)
            {
                return View();
            }
            else
            {
                //Return a failed view 
                return View();
            }
        }
        #endregion
    }
}