using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealNorthWind.Models
{
    public class Category
    {
        #region Gets and Sets
        private int categoryId = -1;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        private string categoryName = "N/A";

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        private string description = "N/A";

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string picture = "N/A";

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        #endregion

        #region Constructors
        public Category() : this(0, "N/A", "N/A", "N/A")
        {

 
        }

        public Category(int CategoryId) : this(CategoryId, "N/A", "N/A", "N/A") { }

        public Category(int CategoryId, string CategoryName) : this(CategoryId, CategoryName, "N/A", "N/A") { }

        public Category(int CategoryId, string CategoryName, string Description) : this(CategoryId, CategoryName, Description, "N/A") { }

        public Category(int CategoryId, string CategoryName, string Description, string Picture)
        {
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
            this.Description = Description;
            this.Picture = Picture;
        }
        #endregion

        #region Display
        public override string ToString()
        {
            string aMessage = "Category Id: " + CategoryId + "\n";
            aMessage = aMessage + "Category Name: " + CategoryName + "\n";
            aMessage = aMessage + "Description: " + Description + "\n";
            return aMessage;
        }

        public string Display()
        {
            string aMessage = "Category Id: " + CategoryId + "<br />";
            aMessage = aMessage + "Category Name: " + CategoryName + "<br />";
            aMessage = aMessage + "Description: " + Description + "<br /><br />";
            return aMessage;
        }
        #endregion
    }
}