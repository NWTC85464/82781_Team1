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
            this.WaitstaffNameLabel.Text = LoginScreen.userName.ToString();

            // TODO: This line of code loads data into the 'restaurantDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.restaurantDataSet.Employees);

            // TODO: This line of code loads data into the 'restaurantDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);
            // TODO: This line of code loads data into the 'restaurantDataSet.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.restaurantDataSet.MenuItems);



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

        private void fillActiveMenuItemsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.menuItemsTableAdapter.FillActiveMenuItems(this.restaurantDataSet.MenuItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
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

        private void fillActiveMenuItems1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.menuItemsTableAdapter.FillActiveMenuItems1(this.restaurantDataSet.MenuItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillActiveMenuItems1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.menuItemsTableAdapter.FillActiveMenuItems1(this.restaurantDataSet.MenuItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillActiveMenuItems1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.menuItemsTableAdapter.FillActiveMenuItems1(this.restaurantDataSet.MenuItems);
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
                this.menuItemsTableAdapter.FillBy1(this.restaurantDataSet.MenuItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.menuItemsTableAdapter.FillBy2(this.restaurantDataSet.MenuItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
