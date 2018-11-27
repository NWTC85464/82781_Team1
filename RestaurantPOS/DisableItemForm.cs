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
    public partial class DisableItemForm : Form
    {
        int itemNumber;
        int menuItemId;
        String menuItemName;
        String menuItemPrice;
        String menuItemDescription;
        String isActive;
        int menuMenuId;

        public DisableItemForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisableItem_Click(object sender, EventArgs e)
        {
            // Validate the input is an int
            if (int.TryParse(txtItemNumber.Text, out itemNumber) == false)
            {
                MessageBox.Show("Please enter a valid item number.");
            }
            else
            {
                // Make sure there is an item with that number
                // Setting up a variable for the datatable from the database
                RestaurantDataSet.MenuItemsDataTable items = new RestaurantDataSet.MenuItemsDataTable();
                // Setting up a employee adaptor and it's to fill in the datatable
                RestaurantDataSetTableAdapters.MenuItemsTableAdapter ItemsTableAdap = new RestaurantDataSetTableAdapters.MenuItemsTableAdapter();
                // Getting the item data from the database
                ItemsTableAdap.GetData();
                // Filling the data to the datatable
                ItemsTableAdap.Fill(items);
                // Going and looking in the datatable for a given item number and returning the row. 
                RestaurantDataSet.MenuItemsRow itemRow = items.FindBymenuItemId(itemNumber);
                // Check if the item row was found (If null, item number does not exist in database)
                if (itemRow == null)
                {
                    MessageBox.Show("Could not find item number, please try again.");
                    itemNumber = 0;
                }
                else
                {
                    // Get current record data
                    menuItemId = itemRow.menuItemId;
                    menuItemName = itemRow.menuItemName;
                    menuItemPrice = itemRow.menuItemPrice;
                    menuItemDescription = itemRow.menuItemDescription;
                    isActive = itemRow.isItemActive;
                    menuMenuId = itemRow.Menu_MenuId;

                    // Update the record and disable the item
                    ItemsTableAdap.Update(menuItemName, menuItemPrice, menuItemDescription, "0", menuMenuId, menuItemId, menuMenuId);

                    // Close the Disable Item form and notify the user
                    this.Close();
                    MessageBox.Show("The desired item has been disabled.");

                    // Need to update the dataset to show database upadate
                }
            }
        }
    }
}
