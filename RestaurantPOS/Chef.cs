using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Chef : Employee
    {


        public Chef(string _name, int _employeeNumber, int _employeePassCode, string _jobTitle) : base(_name, _employeeNumber, _employeePassCode, _jobTitle)
        {
        }

        // View Orders sent to Chef's Active Orders from 
        // Waitstaff
        public void ViewOrders()
        {

        }

        // Completes order by removing from Chef's Active
        // Orders
        public void CompleteOrder()
        {

        }
    }
}
