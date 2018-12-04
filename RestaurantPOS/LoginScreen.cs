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
    public partial class LoginScreen : Form
    {
        public static String userName = "";
        public static int employeeNumber;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Exit Button
            this.Close();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            // Check to see if the employee number exists         
            int password;

            // If the employee number is not a integer
            if(int.TryParse(txtUserName.Text, out employeeNumber)== false)
            {
                MessageBox.Show("Please enter a valid employee number.");

            }
            else if (int.TryParse(txtPassword.Text, out password) == false)
            {
                MessageBox.Show("Please enter a valid password");

            }
            else
            {
                // Table Adapter is the link between the database and your
                // Application. It allows for insert, update, delete and displaying
                // of data from the database.

                // Setting up a variable for the datatable from the database
                RestaurantDataSet.EmployeesDataTable emp = new RestaurantDataSet.EmployeesDataTable();
                // Setting up a employee adaptor and it's to fill in the datatable
                RestaurantDataSetTableAdapters.EmployeesTableAdapter EmpTableAdap = new RestaurantDataSetTableAdapters.EmployeesTableAdapter();
                // Getting the employee data from the database
                EmpTableAdap.GetData();
                // Filling the data to the datatable
                EmpTableAdap.Fill(emp);
                // Going and looking in the datatable for a given employee number and returning the row. 
                RestaurantDataSet.EmployeesRow empRow =  emp.FindByemployeeNumber(employeeNumber);

                // Check if the employee row was found (If null, employee number does not exist in database)
                if(empRow == null)
                {
                    MessageBox.Show("Could not find employee number, please try again.");
                }

                // Checks to see if password text box equals the password in the database for the employee
                else if(empRow.employeePasscode == password)
                {
                    // Collect user name
                    userName = empRow.name;

                    // Hide the login screen
                    this.Hide();

                    if (empRow.jobTitle == "Manager")
                    {
                        // Login - to manager screen
                        ManagerForm Form1 = new ManagerForm();
                        Form1.ShowDialog();
                    }else if(empRow.jobTitle == "Chef")
                    {
                        // Login - to chef screen
                        ChefForm Form1 = new ChefForm();
                        Form1.ShowDialog();
                    }else if(empRow.jobTitle == "Waitstaff")
                    {
                        // Login - to waitstaff screen
                        WaitstaffForm form1 = new WaitstaffForm();
                    
                        form1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Your password was incorrect, please try again.");
                }

            }

		
		}

       

    }
}
