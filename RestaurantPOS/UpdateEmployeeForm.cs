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
    public partial class UpdateEmployeeForm : Form
    {
        String newFName;
        String newLName;
        int newPassword;
        String newJobTitle;
        String oldFName;
        String oldLName;
        int oldPassword;
        String oldJobTitle;
        int validItemEntry = 1;
        int employeeNumber;
        int restId;

        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close form
            this.Close();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            // Validate first name
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter a valid first name");
                validItemEntry = 0;
            }
            else
            {
                newFName = txtFirstName.Text;
            }

            // Validate last name
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please enter a valid last name");
                validItemEntry = 0;
            }
            else
            {
                newLName = txtLastName.Text;
            }

            // Make sure password is an int
            if (int.TryParse(txtPassword.Text, out newPassword) == false)
            {
                MessageBox.Show("Please enter a valid password");
                validItemEntry = 0;
            }

            // Job title selection
            if (rbChef.Checked == true)
            {
                newJobTitle = "Chef";
            }
            else if (rbManager.Checked == true)
            {
                newJobTitle = "Manager";
            }
            else if (rbWaitstaff.Checked == true)
            {
                newJobTitle = "Waitstaff";
            }
            else
            {
                MessageBox.Show("Please Select a Job Title");
                validItemEntry = 0;
            }

            // If all inputs are valid, check employee number and update the record
            if (validItemEntry == 1)
            {
                // Validate the employee number is an integer
                if (int.TryParse(txtEmployeeNumber.Text, out employeeNumber) == false)
                {
                    MessageBox.Show("Please enter a valid employee number.");
                }
                else
                {
                    // Make sure there is an employee with that number
                    // Setting up a variable for the datatable from the database
                    RestaurantDataSet.EmployeesDataTable emp = new RestaurantDataSet.EmployeesDataTable();
                    // Setting up a employee adaptor and it's to fill in the datatable
                    RestaurantDataSetTableAdapters.EmployeesTableAdapter EmpTableAdap = new RestaurantDataSetTableAdapters.EmployeesTableAdapter();
                    // Getting the employee data from the database
                    EmpTableAdap.GetData();
                    // Filling the data to the datatable
                    EmpTableAdap.Fill(emp);
                    // Going and looking in the datatable for a given employee number and returning the row. 
                    RestaurantDataSet.EmployeesRow empRow = emp.FindByemployeeNumber(employeeNumber);

                    // Check if the employee row was found (If null, employee number does not exist in database)
                    if (empRow == null)
                    {
                        MessageBox.Show("Could not find employee number, please try again.");
                        employeeNumber = 0;
                    }
                    else
                    {
                        string fullname = newFName + " " + newLName;

                        // Get current record data
                        oldFName = empRow.name;
                        oldPassword = empRow.employeePasscode;
                        oldJobTitle = empRow.jobTitle;
                        restId = empRow.Restaurant_restaurantId;

                        // Update the record in the database
                        EmpTableAdap.Update(fullname, newPassword, newJobTitle, restId, employeeNumber, oldPassword, restId);

                        // Close the Update Employee form and notify the user
                        this.Close();
                        MessageBox.Show("Employee has been successfully updated.");
                    }
                }
            }
            // Reset validation checker
            validItemEntry = 1;
        }
    }
}
