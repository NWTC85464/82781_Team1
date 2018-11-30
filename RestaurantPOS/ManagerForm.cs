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
    public partial class ManagerForm : Form
    {

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			// Exit Button
			this.Hide();

			// Show log in screen
			LoginScreen Form1 = new LoginScreen();
			Form1.ShowDialog();
		}


		private void ManagerForm_Load(object sender, EventArgs e)
		{
            // This line of code loads data into the 'restaurantDataSet.MenuItems' table.
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
            // This line of code loads data into the 'restaurantDataSet.Employees' table.
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);

            // Show the current date
            String nowDate;
			DateTime now = DateTime.Now;
			nowDate = now.ToString("F");
			lblCurrentDate.Text = nowDate;

            // Show the user's name
            lblLoggedInEmployeeName.Text = LoginScreen.userName;
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            AddMenuItemForm Form1 = new AddMenuItemForm();
            Form1.ShowDialog();

            // Refresh Menu Items table data view
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm Form1 = new AddEmployeeForm();
            Form1.ShowDialog();

            // Refresh Employee table data view
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            RemoveEmployeeForm Form1 = new RemoveEmployeeForm();
            Form1.ShowDialog();

            // Refresh Employee table data view
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);
        }

        private void btnEnableItem_Click(object sender, EventArgs e)
        {
            EnableItemForm Form1 = new EnableItemForm();
            Form1.ShowDialog();

            // Refresh Menu Items table data view
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
        }

        private void btnDisableItem_Click(object sender, EventArgs e)
        {
            DisableItemForm Form1 = new DisableItemForm();
            Form1.ShowDialog();

            // Refresh Menu Items table data view
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
        }

        private void btnRemoveMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItemForm Form1 = new RemoveItemForm();
            Form1.ShowDialog();

            // Refresh Menu Items table data view
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm Form1 = new UpdateEmployeeForm();
            Form1.ShowDialog();

            // Refresh Employee table data view
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);
        }
    }
}
