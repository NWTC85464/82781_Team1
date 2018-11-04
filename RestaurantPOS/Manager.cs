using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Manager : Employee
    {
        private string name;
        private int employeeNumber;
        private int employeePassCode;
        private string jobTitle;

        public string Name { get => name; set => name = value; }
        public int EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        public int EmployeePassCode { get => employeePassCode; set => employeePassCode = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public Manager(string _name, int _employeeNumber, int _employeePassCode, string _jobTitle) : base(_name, _employeeNumber, _employeePassCode, _jobTitle)
        {
            Name = _name;
            EmployeeNumber = _employeeNumber;
            EmployeePassCode = _employeePassCode;
            JobTitle = _jobTitle;
        }

        // Adds MenuItem to Restaurant's Menu
        public void AddMenuItem(Restaurant _restaurant, int _menuItemId, string _menuItemName, double _menuItemPrice)
        {
            _restaurant.restaurantMenu.Add(new MenuItem(_menuItemId, _menuItemName, _menuItemPrice));

        }

        // Removes MenuItem from Restaurant's Menu
        public void setMenuItemInactive(MenuItem _menuItem)
        {
            _menuItem.isItemActive = false;
        }

        // Adds Employee Record to Restaurant Employee Records
        public void AddEmployee(Restaurant _restaurant, string _name, int _employeeNumber, int _employeePassCode, string _jobTitle)
        {
            
        }

        // Removes Employee Record from Restaurant Employee Records
        public void RemoveEmployee()
        {

        }

        // Adds a Discount to Waitstaff table passed in
        public void AddDiscount()
        {

        }

        // Get Sales Report returning total sales for each
        // Waitstaff in cash and credit card as well as total
        // sales for the restaurant.
        public void GetSalesReport()
        {

        }
    }
}
