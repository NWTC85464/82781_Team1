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




        }
        /*
            // Creating objects
            Restaurant restaurant = new Restaurant();
            restaurant.restaurantName = "Burgers And Fries";

            // Getting the resaurant table from the database
            RestaurantDataSet.RestaurantsDataTable restaurants = new RestaurantDataSet.RestaurantsDataTable() ;
           
            // Getting the data adaptor for the resaurant database
            RestaurantDataSetTableAdapters.RestaurantsTableAdapter rta = new RestaurantDataSetTableAdapters.RestaurantsTableAdapter();
            rta.Fill(restaurants);

            // Checking the restaurant database table to make sure that the restaurant name doesn't
            // exist already.
            if (restaurants.Where(r => r.restaurantName == restaurant.restaurantName).Count() == 0)
            {
                rta.Insert(restaurant.restaurantName);
                rta.Update(restaurants);
            }
            rta.Fill(restaurants);

            // Getting the restaurantId from the database
            restaurant.restaurantId = restaurants.Where(r => r.restaurantName == restaurant.restaurantName).FirstOrDefault().restaurantId;


            Manager manager = new Manager("Sean", 109, 100, "Manager");
            manager.AddEmployee(restaurant, manager.Name, manager.GetEmployeeNumber(), manager.GetPasscode(), manager.GetJobTitle());

            Chef chef = new Chef("Bill", 108, 101, "Chef");

            manager.AddEmployee(restaurant, chef.Name, chef.GetEmployeeNumber(), chef.GetPasscode(), chef.GetJobTitle());
            Staff staff = new Staff("Gage", 107, 102, "Waitstaff");
           
            Application.Run(new LoginScreen());

    */

        //  }

        
        

    }
}
