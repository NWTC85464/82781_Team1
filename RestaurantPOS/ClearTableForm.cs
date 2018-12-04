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
    public partial class ClearTableForm : Form
    {
        public ClearTableForm()
        {
            InitializeComponent();
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            int tableNumber;
            // Validate that the item number is a integer
            if (int.TryParse(txtTableNumber.Text, out tableNumber) == false)
            {
                MessageBox.Show("Please enter a valid item number.");
            }
            else
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
                RestaurantDataSet.TablesRow tablesRow = tables.FindBytableNumber(tableNumber);
                if (tablesRow == null)
                {
                    MessageBox.Show("Could not find item number, please try again.");
                    tableNumber = 0;
                }
                else
                {
                    // Get data from record
                    string oldNumberofGuest = tablesRow.numberOfGuests;
                    int oldEmployeeId = tablesRow.employeeNumber;
                    // Set table to active and set the employee id
                    tablesTableAdap.Update(oldNumberofGuest, "0", 19, tableNumber, oldEmployeeId);

                    // Close window and notify user
                    MessageBox.Show("Table " + tableNumber + " cleared.");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
