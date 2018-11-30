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
    public partial class RemoveEmployeeForm : Form
    {
        int employeeNumber;
        String name;
        int employeePasscode;
        String jobTitle;
        int restId;

        public RemoveEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            // Validate if the employee number is not a integer
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
                    // Get current record data
                    name = empRow.name;
                    employeePasscode = empRow.employeePasscode;
                    jobTitle = empRow.jobTitle;
                    restId = empRow.Restaurant_restaurantId;

                    // Delete the user from the database
                    EmpTableAdap.Delete(employeeNumber,employeePasscode,restId);

                    // Close the Delete Employee form and notify the user
                    this.Close();
                    MessageBox.Show("Employee has been successfully deleted.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
