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
    public partial class WaitstaffForm : Form
    {
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
    }
}
