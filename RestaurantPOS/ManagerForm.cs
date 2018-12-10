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

        private void BtnExit_Click(object sender, EventArgs e)
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

        private void BtnAddMenuItem_Click(object sender, EventArgs e)
        {
            AddMenuItemForm Form1 = new AddMenuItemForm();
            Form1.ShowDialog();

            // Refresh Menu Items table data view
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm Form1 = new AddEmployeeForm();
            Form1.ShowDialog();

            // Refresh Employee table data view
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);
        }

        private void BtnRemoveEmployee_Click(object sender, EventArgs e)
        {
            RemoveEmployeeForm Form1 = new RemoveEmployeeForm();
            Form1.ShowDialog();

            // Refresh Employee table data view
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);
        }

        private void BtnEnableItem_Click(object sender, EventArgs e)
        {
            EnableItemForm Form1 = new EnableItemForm();
            Form1.ShowDialog();

            // Refresh Menu Items table data view
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
        }

        private void BtnDisableItem_Click(object sender, EventArgs e)
        {
            DisableItemForm Form1 = new DisableItemForm();
            Form1.ShowDialog();

            // Refresh Menu Items table data view
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
        }

        private void BtnRemoveMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItemForm Form1 = new RemoveItemForm();
            Form1.ShowDialog();

            // Refresh Menu Items table data view
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
        }

        private void BtnUpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm Form1 = new UpdateEmployeeForm();
            Form1.ShowDialog();

            // Refresh Employee table data view
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);
        }

        private void BtnGiveDiscount_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDiscountOrderNumber.Text.ToString(), out int orderNumber) == false)
            {
                MessageBox.Show("Please enter valid Order Number");
            }
            else
            {
                RestaurantDataSet.OrdersDataTable orders = new RestaurantDataSet.OrdersDataTable();
                RestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter = new RestaurantDataSetTableAdapters.OrdersTableAdapter();
                ordersTableAdapter.GetData();
                ordersTableAdapter.Fill(orders);

                RestaurantDataSet.OrdersRow ordersRow = orders.FindByorderNumber(orderNumber);

                if(ordersRow == null)
                {
                    MessageBox.Show("Order does not exist.");
                }
                else
                {
                    double totalWithDiscount;

                    if (double.TryParse(txtDiscountPercent.Text.ToString(), out double discountPercent) == false)
                    {
                            MessageBox.Show("Please enter valid percentage.");
                    }
                    else
                    {
                        if(discountPercent < 0)
                        {
                            MessageBox.Show("Percentage must be greater than 0");
                        }
                        else
                        {
                            discountPercent = (discountPercent / 100);

                            double orderTotal = ordersRow.totalPrice;

                            totalWithDiscount = orderTotal - (orderTotal * discountPercent);

                            ordersTableAdapter.Update(ordersRow.isActive, ordersRow.tableNumber, ordersRow.isPaid, totalWithDiscount, ordersRow.orderNumber, ordersRow.tableNumber, ordersRow.totalPrice);

                            MessageBox.Show("Discount Successfully added to Order number " + orderNumber);
                        }
                    }
                }
            }
        }
    }
}
