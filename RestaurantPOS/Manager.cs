using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Manager : Employee
    {
        public Manager(string _name, int _employeeNumber, int _employeePassCode, string _jobTitle) : base(_name, _employeeNumber, _employeePassCode, _jobTitle)
        {
      
        }

        // Adds MenuItem to Restaurant's Menu
        public void AddMenuItem(Restaurant _restaurant, int _menuItemId, string _menuItemName, double _menuItemPrice)
        {
           // _restaurant.restaurantMenu.Add(new MenuItem(_menuItemId, _menuItemName, _menuItemPrice));
           //will need to change in order to store data in database to populate list
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
