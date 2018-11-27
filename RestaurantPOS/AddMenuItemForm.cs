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
    public partial class AddMenuItemForm : Form
    {
        String itemName;
        Double itemPrice;
        String isActive;
        String description;
        int validItemEntry = 1;

        public AddMenuItemForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            // Validate item name
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Please enter a valid item name");
                validItemEntry = 0;
            }
            else
            {
               itemName = txtItemName.Text;               
            }

            // Validate item price
            if (Double.TryParse(txtItemPrice.Text, out itemPrice) == false)
            {
                MessageBox.Show("Please enter a valid item price.");
                validItemEntry = 0;
            }

            // Validate a description has been chosen
            if (rbDesert.Checked)
            {
                description = "Desert";
            }
            else if (rbAppetizer.Checked)
            {
                description = "Appetizer";
            }
            else if (rbEntree.Checked)
            {
                description = "Entree";
            }
            else if (rbBeverage.Checked)
            {
                description = "Beverage";
            }
            else
            {
                MessageBox.Show("Please select a description");
                validItemEntry = 0;
            }

            // Validate active decision
            if (rbActive.Checked)
            {
                isActive = "1";
            }
            else if (rbDisabled.Checked)
            {
                isActive = "0";
            }
            else
            {
                MessageBox.Show("Please select if this item is active");
                validItemEntry = 0;
            }

            // If all inputs are valid, add the record
            if(validItemEntry == 1)
            {
                // Setting up a variable for the datatable from the database
                RestaurantDataSet.MenuItemsDataTable items = new RestaurantDataSet.MenuItemsDataTable();
                // Setting up a employee adaptor and it's to fill in the datatable
                RestaurantDataSetTableAdapters.MenuItemsTableAdapter ItemsTableAdap = new RestaurantDataSetTableAdapters.MenuItemsTableAdapter();
                // Getting the item data from the database
                ItemsTableAdap.GetData();
                // Filling the data to the datatable
                ItemsTableAdap.Fill(items);

                // Adding the new record
                ItemsTableAdap.Insert(itemName, itemPrice.ToString(), description, isActive, 1);

                // Close the Add Menu Item form and notify the user
                this.Close();
                MessageBox.Show("Item has been successfully added.");
            }

            // Reset validation checker
            validItemEntry = 1;

            // Need to update the dataset to show database upadate
        }
    }
}
