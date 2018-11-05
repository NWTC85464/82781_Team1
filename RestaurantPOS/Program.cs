using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // test
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginScreen());

            // objects go here. 1 manager, 1 chef, 1 staff
            Manager manager = new Manager("Jack", 109, 100, "Manager");
            Chef chef = new Chef("Bill", 108, 101, "Chef");
            WaitStaff staff = new WaitStaff("Gage", 107, 102, "Staff");


        }


    }
}
