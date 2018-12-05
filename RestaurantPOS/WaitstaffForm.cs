using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class WaitstaffForm : Form
    {
        int activeEmployeeNumber = LoginScreen.employeeNumber;
        int activeTableNumber;
        string dbPassword = "P@ssword";
        string dbUserName = "Team1";
        string insertedOrderId;
        double orderGrandTotal;
        

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
            // TODO: This line of code loads data into the 'restaurantDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.restaurantDataSet.Orders);
            this.WaitstaffNameLabel.Text = LoginScreen.userName.ToString();
            // TODO: This line of code loads data into the 'restaurantDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);
            // TODO: This line of code loads data into the 'restaurantDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
            // TODO: This line of code loads data into the 'restaurantDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
            this.tablesTableAdapter.Fill(this.restaurantDataSet._Tables);
        }

        private void menuItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);

        }

        private void menuItemsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.menuItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.restaurantDataSet);
        }

        private void menuItemNameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuItemNameTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tablesTableAdapter.FillBy(this.restaurantDataSet._Tables);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tablesTableAdapter.FillBy1(this.restaurantDataSet._Tables);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tablesTableAdapter.FillBy1(this.restaurantDataSet._Tables);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.menuItemsTableAdapter.FillBy(this.restaurantDataSet.MenuItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.menuItemsTableAdapter.FillBy(this.restaurantDataSet.MenuItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            string menuItemName = menuItemNameComboBox.Text;
            int quantity = (int)quantityUpDownSelector.Value;

            if (quantity > 0)
            {
                addItemToOrder(menuItemName, quantity);
                orderGrandTotal = orderGrandTotal + getOrderItemPrice(quantity, getItemId(menuItemName));

                // Enable send order button if it isn't already
                if (btnSendOrder.Enabled == false)
                {
                    btnSendOrder.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Must have more than 0 quantity to add to order");
            }

        }

        private void fillByMyTableToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tablesTableAdapter.FillByMyTable(this.restaurantDataSet._Tables, new System.Nullable<int>(((int)(System.Convert.ChangeType(activeEmployeeNumberToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectMyTable_Click(object sender, EventArgs e)
        {
            // Clear Order Grand Total to track new order total
            orderGrandTotal = 0;

            // Clear the order preview window
            orderPreviewListBox.Items.Clear();
            // Get table number
            activeTableNumber = (int) tableNumberComboBox.SelectedValue;

            if(changeTableIsActive(activeTableNumber) == 1)
            {
                // Query to create a new record in the order table          
                string query = "insert into Orders (isActive, tableNumber, isPaid, totalPrice)" + "values('0', " + activeTableNumber + ", '0',0);SELECT SCOPE_IDENTITY();";

                // Make password secure to connect to database
                var securePassword = new SecureString();
                foreach (char c in dbPassword)
                {
                    securePassword.AppendChar(c);
                }
                securePassword.MakeReadOnly();
                SqlCredential cred = new SqlCredential(dbUserName, securePassword);
                // Connect to database and run insert query
                using (var dbconn = new SqlConnection("Data Source = nwtcrestaurant.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True", cred))
                {
                    using (var dbcm = new SqlCommand(query, dbconn))
                    {
                        dbconn.Open();
                        // Find the order ID
                        insertedOrderId = dbcm.ExecuteScalar().ToString();
                    }
                }

                // Disable select table button
                btnCreateNewOrder.Enabled = false;
                // Enable add item to order button
                btnAddToOrder.Enabled = true;
                // Disable the send order button until they add an item
                btnSendOrder.Enabled = false;

                // Display the selected table/order number in the preview list
                orderPreviewListBox.Items.Add("Table Number: " + activeTableNumber + "   Order Number: " + insertedOrderId);
                orderPreviewListBox.Items.Add("----------------------------------------------------");
            }
        }

        private int getItemId(string itemName)
        {
            int id = 0;
            // Setting up a variable for the datatable from the database
            RestaurantDataSet.MenuItemsDataTable items = new RestaurantDataSet.MenuItemsDataTable();
            // Setting up a menu items adaptor and it's to fill in the datatable
            RestaurantDataSetTableAdapters.MenuItemsTableAdapter ItemsTableAdap = new RestaurantDataSetTableAdapters.MenuItemsTableAdapter();
            // Getting the item data from the database
            ItemsTableAdap.GetData();
            // Filling the data to the datatable
            ItemsTableAdap.Fill(items);
            // Going and looking in the datatable for a given item name and returning the id. 
            id = (from DataRow dr in items.Rows
                  where (string)dr["menuItemName"] == itemName
                  select (int)dr["menuItemId"]).FirstOrDefault();
            return id;
        }

        private void addItemToOrder(string itemName, int quantity)
        {
            int orderNumber;
            int.TryParse(insertedOrderId, out orderNumber);
            // Get item ID
            int itemId = getItemId(itemName);
            // Setting up a variable for the datatable from the database
            RestaurantDataSet.OrderItemsDataTable orderItems = new RestaurantDataSet.OrderItemsDataTable();
            // Setting up an order items adaptor and it's to fill in the datatable
            RestaurantDataSetTableAdapters.OrderItemsTableAdapter orderItemsTableAdap = new RestaurantDataSetTableAdapters.OrderItemsTableAdapter();
            // Getting the order items data from the database
            orderItemsTableAdap.GetData();
            // Filling the data to the datatable
            orderItemsTableAdap.Fill(orderItems);
            // Add the selection to the preview list
            orderPreviewListBox.Items.Add(itemName + " (" + quantity + ")");
            // Adding the new record to the database  
            orderItemsTableAdap.Insert(quantity.ToString(), itemId, orderNumber); 
        }

        private void BtnSendOrder_Click(object sender, EventArgs e)
        {
            int orderNumber;
            int.TryParse(insertedOrderId, out orderNumber);
            // Enable the select table button
            btnCreateNewOrder.Enabled = true;
            // Disable add item to order button
            btnAddToOrder.Enabled = false;
            // Disable send order button
            btnSendOrder.Enabled = false;
            // Add end of order to preview
            orderPreviewListBox.Items.Add("----------------------------------------------------");
            orderPreviewListBox.Items.Add("Total: $"+orderGrandTotal);


            // Setting up a variable for the datatable from the database
            RestaurantDataSet.OrdersDataTable orders = new RestaurantDataSet.OrdersDataTable();
            // Setting up a orders adaptor and it's to fill in the datatable
            RestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdap = new RestaurantDataSetTableAdapters.OrdersTableAdapter();
            // Getting the item data from the database
            ordersTableAdap.GetData();
            // Filling the data to the datatable
            ordersTableAdap.Fill(orders);
            // Going and looking in the datatable for a given order number and returning the row
            RestaurantDataSet.OrdersRow ordersRow = orders.FindByorderNumber(orderNumber);
            // Set order to active so the chef can pick it up
            ordersTableAdap.Update("1", activeTableNumber, "0", orderGrandTotal, orderNumber, activeTableNumber, ordersRow.totalPrice);

            // Disable remove item button
            btnRemoveItem.Enabled = false;
        }

        private int changeTableIsActive(int tableNumber)
        {
            // Setting up a variable for the datatable from the database
            RestaurantDataSet.TablesDataTable tables = new RestaurantDataSet.TablesDataTable();
            // Setting up a tables adaptor and it's to fill in the datatable
            RestaurantDataSetTableAdapters.TablesTableAdapter tablesTableAdap = new RestaurantDataSetTableAdapters.TablesTableAdapter();
            // Getting the table data from the database
            tablesTableAdap.GetData();
            // Filling the data to the datatable
            tablesTableAdap.Fill(tables);
            // Going and looking in the datatable for a given table number and returning the row
            RestaurantDataSet.TablesRow tablesRow = tables.FindBytableNumber(activeTableNumber);
            // Get data from record
            string oldNumberofGuest = tablesRow.numberOfGuests;
            int oldEmployeeId = tablesRow.employeeNumber;

            if(tablesRow.isActive == "0")
            {
                // Set table to active and set the employee id
                tablesTableAdap.Update(oldNumberofGuest, "1", activeEmployeeNumber, activeTableNumber, oldEmployeeId);
                return 1;
            }
            else
            {
                MessageBox.Show("Table is already occupied; Clear table to start new order");
                return 0;
            }
            
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            ClearTableForm Form1 = new ClearTableForm();
            Form1.ShowDialog();
            
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // Get selected item to be removed
            string selectedItem = null;
            string trimmedItem = null;
            string trimmedQuantity = null;
            int selectedItemId;
            selectedItem = orderPreviewListBox.SelectedItem.ToString();
            // Trim the returned value to get item name
            string[] tmp = selectedItem.Split('(');
            trimmedItem = tmp[0];
            trimmedItem = trimmedItem.Trim();
            trimmedQuantity = tmp[1];            
            // Find the item ID
            selectedItemId = getItemId(trimmedItem);

            MessageBox.Show("Selected Item: " + trimmedItem + " Item Number: " + selectedItemId); // for testing
        }

        private double getOrderItemPrice(int quantity, int itemID)
        {
            if (quantity > 0)
            {
                double orderItemPrice;

                // Setting up a variable for the datatable from the database
                RestaurantDataSet.MenuItemsDataTable items = new RestaurantDataSet.MenuItemsDataTable();
                // Setting up a menu items adaptor and it's to fill in the datatable
                RestaurantDataSetTableAdapters.MenuItemsTableAdapter ItemsTableAdap = new RestaurantDataSetTableAdapters.MenuItemsTableAdapter();
                // Getting the item data from the database
                ItemsTableAdap.GetData();
                // Filling the data to the datatable
                ItemsTableAdap.Fill(items);

                RestaurantDataSet.MenuItemsRow menuItemRow = items.FindBymenuItemId(itemID);

                orderItemPrice = quantity * double.Parse(menuItemRow.menuItemPrice);

                return orderItemPrice;
            }
            else { return 0; } 
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            PaymentForm Form1 = new PaymentForm();
            Form1.ShowDialog();
        }
    }
}
    
