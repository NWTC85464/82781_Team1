using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Restaurant
    {
        private string name;
        public List<MenuItem> restaurantMenu;
        public List<Employee> employeeRecords;
        public Kitchen kitchen;
        

        public Restaurant(string _name)
        {
            Name = _name;
            kitchen = new Kitchen();
        }

        public string Name { get => name; set => name = value; }
        internal List<MenuItem> RestaurantMenu { get => restaurantMenu; set => restaurantMenu = value; }
        internal List<Employee> EmployeeRecords { get => employeeRecords; set => employeeRecords = value; }
    }
}
