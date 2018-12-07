namespace RestaurantPOS
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalDue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountPaidTextbox = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.btnPayBill = new System.Windows.Forms.Button();
            this.lblChangeDue = new System.Windows.Forms.Label();
            this.lblChangeDueValue = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblPaymentStatusValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Due: ";
            // 
            // labelTotalDue
            // 
            this.labelTotalDue.AutoSize = true;
            this.labelTotalDue.Location = new System.Drawing.Point(78, 90);
            this.labelTotalDue.Name = "labelTotalDue";
            this.labelTotalDue.Size = new System.Drawing.Size(0, 13);
            this.labelTotalDue.TabIndex = 3;
            this.labelTotalDue.Click += new System.EventHandler(this.labelTotalDue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(119, 14);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Order Number:";
            // 
            // amountPaidTextbox
            // 
            this.amountPaidTextbox.Location = new System.Drawing.Point(81, 123);
            this.amountPaidTextbox.Name = "amountPaidTextbox";
            this.amountPaidTextbox.Size = new System.Drawing.Size(100, 20);
            this.amountPaidTextbox.TabIndex = 7;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(2, 126);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(73, 13);
            this.lblAmountPaid.TabIndex = 8;
            this.lblAmountPaid.Text = "Amount Paid: ";
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(225, 121);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(118, 23);
            this.btnPayBill.TabIndex = 9;
            this.btnPayBill.Text = "Pay Bill";
            this.btnPayBill.UseVisualStyleBackColor = true;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // lblChangeDue
            // 
            this.lblChangeDue.AutoSize = true;
            this.lblChangeDue.Location = new System.Drawing.Point(9, 156);
            this.lblChangeDue.Name = "lblChangeDue";
            this.lblChangeDue.Size = new System.Drawing.Size(73, 13);
            this.lblChangeDue.TabIndex = 10;
            this.lblChangeDue.Text = "Change Due: ";
            // 
            // lblChangeDueValue
            // 
            this.lblChangeDueValue.AutoSize = true;
            this.lblChangeDueValue.Location = new System.Drawing.Point(78, 156);
            this.lblChangeDueValue.Name = "lblChangeDueValue";
            this.lblChangeDueValue.Size = new System.Drawing.Size(10, 13);
            this.lblChangeDueValue.TabIndex = 11;
            this.lblChangeDueValue.Text = " ";
            this.lblChangeDueValue.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(40, 235);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentStatus.TabIndex = 12;
            this.lblPaymentStatus.Text = "Payment Status: ";
            // 
            // lblPaymentStatusValue
            // 
            this.lblPaymentStatusValue.AutoSize = true;
            this.lblPaymentStatusValue.Location = new System.Drawing.Point(134, 235);
            this.lblPaymentStatusValue.Name = "lblPaymentStatusValue";
            this.lblPaymentStatusValue.Size = new System.Drawing.Size(0, 13);
            this.lblPaymentStatusValue.TabIndex = 13;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 280);
            this.Controls.Add(this.lblPaymentStatusValue);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblChangeDueValue);
            this.Controls.Add(this.lblChangeDue);
            this.Controls.Add(this.btnPayBill);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.amountPaidTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotalDue);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalDue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountPaidTextbox;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Button btnPayBill;
        private System.Windows.Forms.Label lblChangeDue;
        private System.Windows.Forms.Label lblChangeDueValue;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblPaymentStatusValue;
    }
}