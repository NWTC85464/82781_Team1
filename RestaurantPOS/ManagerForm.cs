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
    public partial class ManagerForm : Form
    {
		

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			/// Exit Button
			this.Hide();

			// Show log in screen
			LoginScreen Form1 = new LoginScreen();
			Form1.ShowDialog();
		}

        private void btnClearLists_Click(object sender, EventArgs e)
        {
            // Clear lists
            lstEmployees.Items.Clear();
            lstActiveMenuItems.Items.Clear();
        }

		private void ManagerForm_Load(object sender, EventArgs e)
		{
			// Date and time
			String nowDate;
			String nowTime;

			DateTime now = DateTime.Now;
			nowDate = now.ToString("F");

			lblCurrentDate.Text = nowDate;
		}
	}
}
