﻿using System;
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
            Application.Run(new Form1());

            Manager generalManager = new Manager("Jack Inthebox", 1, 1234, "General Manager");

            generalManager.Name = "Tom";

            MessageBox.Show(generalManager.Name);

            Restaurant restaurant = new Restaurant("Burger Shack", generalManager);
            
        }


    }
}
