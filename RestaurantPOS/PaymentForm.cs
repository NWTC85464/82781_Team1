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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orderNumber;

            if(int.TryParse(textBoxOrderNumber.Text, out orderNumber) == false)
            {
                MessageBox.Show("Please enter a valid Order Number.");
            }
            else {
                RestaurantDataSet.OrdersDataTable orders = new RestaurantDataSet.OrdersDataTable();

                RestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapt = new RestaurantDataSetTableAdapters.OrdersTableAdapter();

                ordersTableAdapt.GetData();
                ordersTableAdapt.Fill(orders);


                RestaurantDataSet.OrdersRow ordersRow = orders.FindByorderNumber(orderNumber);

                if(ordersRow == null)
                {
                    MessageBox.Show("Order could not be found.");
                }
                else
                {
                    labelTotalDue.Text = ordersRow.totalPrice.ToString();
                }
            }
        }
    }
}
