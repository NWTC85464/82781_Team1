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
    public partial class ChefForm : Form
    {
        public ChefForm()
        {
            InitializeComponent();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Exit Button
            this.Hide();

			// Show log in screen
			LoginScreen Form1 = new LoginScreen();
			Form1.ShowDialog();

		}

        private void BtnCompleteOrderOne_Click(object sender, EventArgs e)
        {
            // Clear Chef list one
            lstOrderOne.Items.Clear();

            // Delete the order from the queue

            // Enable Load Next Order Button
            btnLoadOrderOne.Enabled = true;
        }

        private void BtnCompleteOrderTwo_Click(object sender, EventArgs e)
        {
            // Clear Chef list two
            lstOrderTwo.Items.Clear();

            // Delete the order from the queue

            // Enable Load Next Order Button
            btnLoadOrderTwo.Enabled = true;
        }

        private void BtnCompleteOrderThree_Click(object sender, EventArgs e)
        {
            // Clear Chef list three
            lstOrderThree.Items.Clear();

            // Delete the order from the queue

            // Enable Load Next Order Button
            btnLoadOrderThree.Enabled = true;
        }

        private void BtnLoadOrderOne_Click(object sender, EventArgs e)
        {
            // Load order from the queue

            // Disable Load Next Order button
            btnLoadOrderOne.Enabled = false;
        }

        private void BtnLoadOrderTwo_Click(object sender, EventArgs e)
        {
            // Load order from the queue

            // Disable Load Next Order button
            btnLoadOrderTwo.Enabled = false;
        }

        private void BtnLoadOrderThree_Click(object sender, EventArgs e)
        {
            // Load order from the queue

            // Disable Load Next Order button
            btnLoadOrderThree.Enabled = false;
        }

		private void ChefForm_Load(object sender, EventArgs e)
		{
			
		}
	}
}
