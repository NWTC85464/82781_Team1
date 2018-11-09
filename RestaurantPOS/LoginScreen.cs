﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit Button
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
			// Hide the login screen
			this.Hide();

			// Login - to chef right now for testing
			//ChefForm Form1 = new ChefForm();
			//Form1.ShowDialog();

			// Login - to manager right now for testing
			ManagerForm Form1 = new ManagerForm();
			Form1.ShowDialog();
		}
    }
}
