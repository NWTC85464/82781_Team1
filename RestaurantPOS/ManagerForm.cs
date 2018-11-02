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
            // Exit Button
            this.Close();
        }

        private void btnClearLists_Click(object sender, EventArgs e)
        {
            // Clear lists
            lstEmployees.Items.Clear();
            lstMenuItems.Items.Clear();
        }
    }
}
