using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealNorthWind.Models
{
    public class Employees
    {
        #region //Gets and Sets
        private int employeeId;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string titleOfCourtesy;

        public string TitleOfCourtesy
        {
            get { return titleOfCourtesy; }
            set { titleOfCourtesy = value; }
        }

        private string birthDate;

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private string hireDate;

        public string HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
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

        private string homePhone;

        public string HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }

        private string extension;

        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }

        private string photo;

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        private string reportsTo;

        public string ReportsTo
        {
            get { return reportsTo; }
            set { reportsTo = value; }
        }
        #endregion

        #region //Construtors
        public Employees()
          : this(0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId)
          : this(aEmployeeId, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName)
          : this(aEmployeeId, aFirstName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName)
          : this(aEmployeeId, aFirstName, aLastName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle)
          : this(aEmployeeId, aFirstName, aLastName, aTitle, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy)
           : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate)
           : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate)
           : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress)
           : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
           string aCity)
           : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
           string aCity, string aRegion)
           : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
           string aCity, string aRegion, string aPostalCode)
           : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
           string aCity, string aRegion, string aPostalCode, string aCountry)
           : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, "N/A", "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
            string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone)
            : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, "N/A", "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
            string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension)
            : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, "N/A", "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
            string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aPhoto)
            : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, "N/A", "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
            string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aPhoto, string aNotes)
            : this(aEmployeeId, aFirstName, aLastName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aPhoto, aNotes, "N/A") { }

        public Employees(int aEmployeeId, string aFirstName, string aLastName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress,
            string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aPhoto, string aNotes, string aReportsTo)
        {
            this.EmployeeId = aEmployeeId;
            this.FirstName = aFirstName;
            this.LastName = aLastName;
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
        }
        #endregion

        #region Display
        //ToString Method
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "Employee Id: " + EmployeeId + "\n";
            aMessage = aMessage + "First Name: " + FirstName + "\n";
            aMessage = aMessage + "Last Name: " + LastName + "\n";
            aMessage = aMessage + "Title: " + Title + "\n";
            aMessage = aMessage + "Title Of Curtesy: " + TitleOfCourtesy + "\n";
            aMessage = aMessage + "Birthdate: " + BirthDate + "\n";
            aMessage = aMessage + "Hire Date: " + HireDate + "\n";
            aMessage = aMessage + "Address: " + Address + "\n";
            aMessage = aMessage + "City: " + City + "\n";
            aMessage = aMessage + "Region: " + Region + "\n";
            aMessage = aMessage + "Postal Code: " + PostalCode + "\n";
            aMessage = aMessage + "Country: " + Country + "\n";
            aMessage = aMessage + "Home Phone: " + HomePhone + "\n";
            aMessage = aMessage + "Extension: " + Extension + "\n";
            aMessage = aMessage + "Photo: " + Photo + "\n";
            aMessage = aMessage + "Notes: " + Notes + "\n";
            aMessage = aMessage + "Reports To: " + ReportsTo + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";
            aMessage = aMessage + EmployeeId + "<br />";
            aMessage = aMessage + FirstName + "<br />";
            aMessage = aMessage + LastName + "<br />";
            aMessage = aMessage + Title + "<br />";
            aMessage = aMessage + TitleOfCourtesy + "<br />";
            aMessage = aMessage + BirthDate + "<br />";
            aMessage = aMessage + HireDate + "<br />";
            aMessage = aMessage + Address + "<br />";
            aMessage = aMessage + City + "<br />";
            aMessage = aMessage + Region + "<br />";
            aMessage = aMessage + PostalCode + "<br />";
            aMessage = aMessage + Country + "<br />";
            aMessage = aMessage + HomePhone + "<br />";
            aMessage = aMessage + Extension + "<br />";
            aMessage = aMessage + Photo + "<br />";
            aMessage = aMessage + Notes + "<br />";
            aMessage = aMessage + ReportsTo + "<br /><br />";

            return aMessage;
        }
        #endregion
    }
}