using System;
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
    public partial class WaitstaffForm : Form
    {
        public WaitstaffForm()
        {
            InitializeComponent();
        }

        private void AppetizersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit Button
            this.Hide();

            // Show log in screen
            LoginScreen Form1 = new LoginScreen();
            Form1.ShowDialog();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WaitstaffForm_Load(object sender, EventArgs e)
        {
            // Setting up a variable for the datatable from the database
            RestaurantDataSet.MenuItemsDataTable menuItems = new RestaurantDataSet.MenuItemsDataTable();
            // Setting up a employee adaptor and it's to fill in the datatable
            RestaurantDataSetTableAdapters.MenuItemsTableAdapter MenuItemsTableAdap = new RestaurantDataSetTableAdapters.MenuItemsTableAdapter();
            // Getting the employee data from the database
            AppetizerListBox.DataSource = MenuItemsTableAdap.GetData();

            AppetizerListBox.Show();
        }
    }
}
