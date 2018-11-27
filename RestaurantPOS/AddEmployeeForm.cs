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
    public partial class AddEmployeeForm : Form
    {
        String fName;
        String lName;
        int password;
        String jobTitle;
        int validItemEntry = 1;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Validate first name
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter a valid first name");
                validItemEntry = 0;
            }
            else
            {
                fName = txtFirstName.Text;
            }

            // Validate first name
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter a valid last name");
                validItemEntry = 0;
            }
            else
            {
                lName = txtLastName.Text;
            }                     

            // Make sure password is an int
            if (int.TryParse(txtPassword.Text, out password) == false)
            {
                MessageBox.Show("Please enter a valid password");
                validItemEntry = 0;
            }           
            
            // Job title selection
            if (rbChef.Checked == true)
            {
                jobTitle = "Chef";
            }
            else if (rbManager.Checked == true)
            {
                jobTitle = "Manager";
            }
            else if (rbWaitstaff.Checked == true)
            {
                jobTitle = "Waitstaff";
            }
            else
            {
                MessageBox.Show("Please Select a Job Title");
                validItemEntry = 0;
            }

            // If all inputs are valid, add the record
            if (validItemEntry == 1)
            {
                // Setting up a variable for the datatable from the database
                RestaurantDataSet.EmployeesDataTable emp = new RestaurantDataSet.EmployeesDataTable();
                // Setting up a employee adaptor and it's to fill in the datatable
                RestaurantDataSetTableAdapters.EmployeesTableAdapter EmpTableAdap = new RestaurantDataSetTableAdapters.EmployeesTableAdapter();
                // Getting the employee data from the database
                EmpTableAdap.GetData();
                // Filling the data to the datatable
                EmpTableAdap.Fill(emp);

                // Adding the new record                
                EmpTableAdap.Insert(fName, password, jobTitle, 1);

                // Close the Add Employee form and notify the user
                this.Close();
                MessageBox.Show("Employee has been successfully added.");
            }

            // Reset validation checker
            validItemEntry = 1;

            // Need to update the dataset to show database upadate
            
        }
    }
}
