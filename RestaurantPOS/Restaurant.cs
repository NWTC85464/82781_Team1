using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Restaurant
    {
        public string Name;
        public List<MenuItem> restaurantMenu;
        public List<Employee> employeeRecords;
        public Manager Manager;

        public Restaurant(string _name, Manager _manager)
        {
            Name = _name;
            Manager = _manager;
        }

    }
}
