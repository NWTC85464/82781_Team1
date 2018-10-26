using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS
{
    class Employee
    {
        private String name;
        private int employeeNumber;
        private int employeePassCode;
        private String jobTitle;

        public Employee(String _name, int _employeeNumber, int _employeePassCode, String _jobTitle)
        {
            this.Name = _name;
            this.employeeNumber = _employeeNumber;
            this.employeePassCode = _employeePassCode;
            this.jobTitle = _jobTitle;
        }

        public string Name { get => name; set => name = value; }

        public void LogIn(int employeeNumber, int employeePassCode)
        {

        }

        public void LogOut()
        {

        }
    }
}
