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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblPaymentStatusValue.Text = "";
            amountPaidTextbox.Text = "";
            labelTotalDue.Text = "";
            lblChangeDueValue.Text = "";

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

                // Display order status depending on if the bill is paid or not
                if(ordersRow.isPaid == "0")
                {
                    lblPaymentStatusValue.Text = "Payment Pending";
                    btnPayBill.Enabled = true;
                }
                else
                {
                    if(ordersRow.isPaid == "1")
                    {
                        lblPaymentStatusValue.Text = "Payment Processed and Completed";
                        btnPayBill.Enabled = false;
                    }
                }
            } 
        }

        private void LabelTotalDue_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {

            int orderNumber;
            if (int.TryParse(textBoxOrderNumber.Text, out orderNumber) == false)
            {
                MessageBox.Show("Please enter a valid Order Number.");
            }
            else
            {
                RestaurantDataSet.OrdersDataTable orders = new RestaurantDataSet.OrdersDataTable();

                RestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapt = new RestaurantDataSetTableAdapters.OrdersTableAdapter();

                ordersTableAdapt.GetData();
                ordersTableAdapt.Fill(orders);


                RestaurantDataSet.OrdersRow ordersRow = orders.FindByorderNumber(orderNumber);

                double amountPaid;
                double amountDue;

                if(double.TryParse(amountPaidTextbox.Text.ToString(), out amountPaid) == true)
                {
                    if(double.TryParse(labelTotalDue.Text.ToString(), out amountDue) == true)
                    {
                        if(amountPaid >= amountDue)
                        {
                            double change = amountPaid - amountDue;
                            lblChangeDueValue.Text = "$" + change;

                            ordersTableAdapt.Update(ordersRow.isActive, ordersRow.tableNumber, "1", ordersRow.totalPrice, ordersRow.orderNumber, ordersRow.tableNumber, ordersRow.totalPrice);

                            lblPaymentStatusValue.Text = "Payment processed and Completed Successfully"; 
                          
                        }
                        else
                        {
                            MessageBox.Show("Payment amount does not cover the Total Amount.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Amount Due; Possible Data Corruption");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Amount."); // Currently Have problems parsing textbox to double
                }
            }
        }
    }
}
