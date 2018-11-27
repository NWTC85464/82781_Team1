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
    public partial class ChefForm : Form
    {

        // Setting up a variable for the ordertable from the database
        RestaurantDataSet.OrdersDataTable orders = new RestaurantDataSet.OrdersDataTable();
        // Setting up a order adaptor and to fill in the datatable
        RestaurantDataSetTableAdapters.OrdersTableAdapter OrderTableAdapt = new RestaurantDataSetTableAdapters.OrdersTableAdapter();

        // Setting up a variable for the order item table from the database
        RestaurantDataSet.OrderItemsDataTable orderItems = new RestaurantDataSet.OrderItemsDataTable();
        // Setting up a order item adaptor and to fill in the datatable
        RestaurantDataSetTableAdapters.OrderItemsTableAdapter OrderItemsTableAdapt = new RestaurantDataSetTableAdapters.OrderItemsTableAdapter();

        // Setting up a variable for the menu item from the database
        RestaurantDataSet.MenuItemsDataTable menuItems = new RestaurantDataSet.MenuItemsDataTable();
        // Setting up a menu item table adaptor and to fill in the datatable
        RestaurantDataSetTableAdapters.MenuItemsTableAdapter MenuItemsTableAdapt = new RestaurantDataSetTableAdapters.MenuItemsTableAdapter();

        // List for active orders
        List<RestaurantDataSet.OrdersRow> ActiveOrders = new List<RestaurantDataSet.OrdersRow>();

        // Variables to hold the next order number
        int nextOrder = 0;
        int orderOne = 0;
        int orderTwo = 0;
        int orderThree = 0;

        public ChefForm()
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

        private void BtnCompleteOrderOne_Click(object sender, EventArgs e)
        {
            // Clear Chef list one
            lstOrderOne.Items.Clear();

            // Delete the order from the queue
            RestaurantDataSet.OrdersRow orderRow = orders.Where(o => o.orderNumber == orderOne).First();
            
            // Setting isActive to 0 to show the order has been completed
            OrderTableAdapt.Update("0", orderRow.tableNumber, orderRow.orderNumber, orderRow.tableNumber, orderRow.orderNumber);
            orderOne = 0;

            // Enable Load Next Order Button
            btnLoadOrderOne.Enabled = true;
        }

        private void BtnCompleteOrderTwo_Click(object sender, EventArgs e)
        {
            // Clear Chef list two
            lstOrderTwo.Items.Clear();

            // Delete the order from the queue
            RestaurantDataSet.OrdersRow orderRow = orders.Where(o => o.orderNumber == orderTwo).First();

            // Setting isActive to 0 to show the order has been completed
            OrderTableAdapt.Update("0", orderRow.tableNumber, orderRow.orderNumber, orderRow.tableNumber, orderRow.orderNumber);
            orderTwo = 0;

            // Enable Load Next Order Button
            btnLoadOrderTwo.Enabled = true;
        }

        private void BtnCompleteOrderThree_Click(object sender, EventArgs e)
        {
            // Clear Chef list three
            lstOrderThree.Items.Clear();

            // Delete the order from the queue
            RestaurantDataSet.OrdersRow orderRow = orders.Where(o => o.orderNumber == orderThree).First();

            // Setting isActive to 0 to show the order has been completed
            OrderTableAdapt.Update("0", orderRow.tableNumber, orderRow.orderNumber, orderRow.tableNumber, orderRow.orderNumber);
            orderThree = 0;

            // Enable Load Next Order Button
            btnLoadOrderThree.Enabled = true;
        }

        private void BtnLoadOrderOne_Click(object sender, EventArgs e)
        {
            // Load order from the queue
            getDataTables();

            // Checking to see if there are more orders to display
            if (ActiveOrders.Where(a => a.orderNumber != orderTwo && a.orderNumber != orderThree).Count()>0)
            {
                nextOrder = findNextOrder(orderTwo, orderThree);
                orderOne = ActiveOrders[nextOrder].orderNumber;
                lstOrderOne.Items.Add("Table number: " + ActiveOrders[nextOrder].tableNumber);
              
                // Displaying the order items and details in the list view
                foreach (RestaurantDataSet.OrderItemsRow orderitem in orderItems.Where(o => o.Orders_orderNumber == ActiveOrders[nextOrder].orderNumber))
                {
                    RestaurantDataSet.MenuItemsRow menuitem = menuItems.Where(m => m.menuItemId == orderitem.MenuItems_menuItemID).FirstOrDefault();
                    lstOrderOne.Items.Add(menuitem.menuItemName + " Qty: " + orderitem.quantity);
                }

                nextOrder++;

                // Disable Load Next Order button
                btnLoadOrderOne.Enabled = false;
            }
            else
            {
                MessageBox.Show("No more orders to be fufilled.");
            }
        }


        private void BtnLoadOrderTwo_Click(object sender, EventArgs e)
        {
            // Load order from the queue
            getDataTables();

            // Checking to see if there are more orders to display
            if (ActiveOrders.Where(a => a.orderNumber != orderOne && a.orderNumber != orderThree).Count() > 0)
            {
                nextOrder = findNextOrder(orderOne, orderThree);
                orderTwo = ActiveOrders[nextOrder].orderNumber;

                // Load order from the queue
                lstOrderTwo.Items.Add("Table number: " + ActiveOrders[nextOrder].tableNumber);

                // Displaying the order items and details in the list view
                foreach (RestaurantDataSet.OrderItemsRow orderitem in orderItems.Where(o => o.Orders_orderNumber == ActiveOrders[nextOrder].orderNumber))
                {
                    RestaurantDataSet.MenuItemsRow menuitem = menuItems.Where(m => m.menuItemId == orderitem.MenuItems_menuItemID).FirstOrDefault();
                    lstOrderTwo.Items.Add(menuitem.menuItemName + " Qty: " + orderitem.quantity);
                }

                nextOrder++;

                // Disable Load Next Order button
                btnLoadOrderTwo.Enabled = false;
            }
            else
            {
                MessageBox.Show("No more orders to be fufilled.");
            }
        }

        private void BtnLoadOrderThree_Click(object sender, EventArgs e)
        {
            // Load order from the queue
            getDataTables();

            // Checking to see if there are more orders to display
            if (ActiveOrders.Where(a => a.orderNumber != orderTwo && a.orderNumber != orderOne).Count() > 0)
            {
                nextOrder = findNextOrder(orderTwo, orderOne);
                orderThree = ActiveOrders[nextOrder].orderNumber;

                // Load order from the queue
                lstOrderThree.Items.Add("Table number: " + ActiveOrders[nextOrder].tableNumber);

                // Displaying the order items and details in the list view
                foreach (RestaurantDataSet.OrderItemsRow orderitem in orderItems.Where(o => o.Orders_orderNumber == ActiveOrders[nextOrder].orderNumber))
                {
                    RestaurantDataSet.MenuItemsRow menuitem = menuItems.Where(m => m.menuItemId == orderitem.MenuItems_menuItemID).FirstOrDefault();
                    lstOrderThree.Items.Add(menuitem.menuItemName + " Qty: " + orderitem.quantity);
                }

                nextOrder++;

                // Disable Load Next Order button
                btnLoadOrderThree.Enabled = false;
            }
            else
            {
                MessageBox.Show("No more orders to be fufilled.");
            }
        }

		private void ChefForm_Load(object sender, EventArgs e)
		{
            getDataTables();

            // Checking to see if there are any orders to be fufilled
            if (nextOrder < ActiveOrders.Count())
            {

                lstOrderOne.Items.Add("Table number: " + ActiveOrders[nextOrder].tableNumber);

                orderOne = ActiveOrders[nextOrder].orderNumber;

                foreach (RestaurantDataSet.OrderItemsRow orderitem in orderItems.Where(o => o.Orders_orderNumber == ActiveOrders[nextOrder].orderNumber))
                {
                    RestaurantDataSet.MenuItemsRow menuitem = menuItems.Where(m => m.menuItemId == orderitem.MenuItems_menuItemID).FirstOrDefault();
                    lstOrderOne.Items.Add(menuitem.menuItemName + " Qty: " + orderitem.quantity);
                }
                btnLoadOrderOne.Enabled = false;
                nextOrder++;
            }
            else
            {
                // No orders to display, disabable complete order one
                MessageBox.Show("No orders to display");
                btnCompleteOrderOne.Enabled = false;
            }

            // Checking to see if there is a second order
            if (nextOrder < ActiveOrders.Count())
            {
                lstOrderTwo.Items.Add("Table number: " + ActiveOrders[nextOrder].tableNumber);

                orderTwo = ActiveOrders[nextOrder].orderNumber;

                foreach (RestaurantDataSet.OrderItemsRow orderitem in orderItems.Where(o => o.Orders_orderNumber == ActiveOrders[nextOrder].orderNumber))
                {
                    RestaurantDataSet.MenuItemsRow menuitem = menuItems.Where(m => m.menuItemId == orderitem.MenuItems_menuItemID).FirstOrDefault();
                    lstOrderTwo.Items.Add(menuitem.menuItemName + " Qty: " + orderitem.quantity);
                }
                btnLoadOrderTwo.Enabled = false;
                nextOrder++;
            }
            else
            {
                // No orders to display, disabable complete order two
                btnCompleteOrderTwo.Enabled = false;
            }

            // Checking to see if there is a third order
            if (nextOrder < ActiveOrders.Count())
            {

                lstOrderThree.Items.Add("Table number: " + ActiveOrders[nextOrder].tableNumber);

                orderThree = ActiveOrders[nextOrder].orderNumber;

                foreach (RestaurantDataSet.OrderItemsRow orderitem in orderItems.Where(o => o.Orders_orderNumber == ActiveOrders[nextOrder].orderNumber))
                {
                    RestaurantDataSet.MenuItemsRow menuitem = menuItems.Where(m => m.menuItemId == orderitem.MenuItems_menuItemID).FirstOrDefault();
                    lstOrderThree.Items.Add(menuitem.menuItemName + " Qty: " + orderitem.quantity);
                }
                btnLoadOrderThree.Enabled = false;
                nextOrder++;
            }
            else
            {
                // No orders to display, disabable complete order three
                btnCompleteOrderThree.Enabled = false;
            }

        }

        public void getDataTables()
        {
            // Getting the order data from the database
            OrderTableAdapt.GetData();
            // Filling the data to the datatable
            OrderTableAdapt.Fill(orders);

           
            // Getting the order data from the database
            OrderItemsTableAdapt.GetData();
            // Filling the data to the datatable
            OrderItemsTableAdapt.Fill(orderItems);

          
            // Getting the order data from the database
            MenuItemsTableAdapt.GetData();
            // Filling the data to the datatable
            MenuItemsTableAdapt.Fill(menuItems);

            ActiveOrders.Clear();
            // Put active orders inside active order list
            foreach (RestaurantDataSet.OrdersRow order in orders.Where(o => o.isActive == "1"))
            {
                ActiveOrders.Add(order);
            }

        }
        // Finding the next order that isn't already being displayed
        private int findNextOrder(int orderNum1, int orderNum2)
        {
            if (ActiveOrders[0].orderNumber != orderNum1 && ActiveOrders[0].orderNumber != orderNum2)
            {
                return 0;
            }
            if (ActiveOrders[1].orderNumber != orderNum1 && ActiveOrders[1].orderNumber != orderNum2)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
