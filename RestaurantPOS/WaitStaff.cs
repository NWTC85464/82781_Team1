using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class WaitStaff : Employee
    {
        public WaitStaff(string _name, int _employeeNumber, int _employeePassCode, string _jobTitle) : base(_name, _employeeNumber, _employeePassCode, _jobTitle)
        {
            this.name = 
        }

        // Adds new Table to Waiter's list of Active Tables
        public void AddNewTable()
        {

        }

        // Adds Order to Table Order
        public void AddOrderToTable()
        {

        }

        // Sends Added Order to Chef's Active Orders
        public void SendOrder()
        {

        }

        // Removes an unwanted item from Table Order
        public void RemoveItemFromOrder()
        {

        }

        // Total the Order and track how much is owed by 
        // waiter in Cash or Credit Card for nightly sales
        // report
        public void PayBill()
        {

        }
    }
}
