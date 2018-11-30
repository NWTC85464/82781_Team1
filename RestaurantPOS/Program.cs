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






           

            //// Getting the resaurant table from the database
            //RestaurantDataSet.RestaurantsDataTable restaurants = new RestaurantDataSet.RestaurantsDataTable();
            //// Creating objects
            //RestaurantDataSet.RestaurantsRow newRestaurant;
            //newRestaurant = restaurants.NewRestaurantsRow();

            //newRestaurant.restaurantName = "Burgers And Fries";
            //// Getting the data adaptor for the resaurant database
            //RestaurantDataSetTableAdapters.RestaurantsTableAdapter rta = new RestaurantDataSetTableAdapters.RestaurantsTableAdapter();
            //rta.Fill(restaurants);

            //// Checking the restaurant database table to make sure that the restaurant name doesn't
            //// exist already.
            //if (restaurants.Where(r => r.restaurantName == newRestaurant.restaurantName).Count() == 0)
            //{
            //    rta.Insert(newRestaurant.restaurantName);
            //    rta.Update(restaurants);
            //}
            
           
            Application.Run(new LoginScreen());



        }

    }
    }

