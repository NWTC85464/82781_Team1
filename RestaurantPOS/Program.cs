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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
             *  Add Initialization Methods here for restaurant employee and menu objects
             * 
             */

            // When the Application starts, show the Login Screen
            Application.Run(new LoginScreen());

            
        }


    }
}
