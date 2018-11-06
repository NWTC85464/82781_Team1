using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Staff : Employee
    {
        public Staff(string _name, int _employeeNumber, int _employeePassCode, string _jobTitle) : base(_name, _employeeNumber, _employeePassCode, _jobTitle)
        {

        }
    }
}
