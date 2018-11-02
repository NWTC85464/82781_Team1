namespace RestaurantPOS
{
    partial class ManagerForm
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
            this.gbEmployees = new System.Windows.Forms.GroupBox();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.gbMenuItems = new System.Windows.Forms.GroupBox();
            this.btnRemoveMenuItem = new System.Windows.Forms.Button();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.lstMenuItems = new System.Windows.Forms.ListBox();
            this.gbDiscount = new System.Windows.Forms.GroupBox();
            this.btnGiveDiscount = new System.Windows.Forms.Button();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountOrderNumber = new System.Windows.Forms.TextBox();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearLists = new System.Windows.Forms.Button();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnGetSalesReport = new System.Windows.Forms.Button();
            this.btnGetEmployees = new System.Windows.Forms.Button();
            this.btnGetMenuItems = new System.Windows.Forms.Button();
            this.gbEmployees.SuspendLayout();
            this.gbMenuItems.SuspendLayout();
            this.gbDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmployees
            // 
            this.gbEmployees.Controls.Add(this.btnRemoveEmployee);
            this.gbEmployees.Controls.Add(this.btnAddEmployee);
            this.gbEmployees.Controls.Add(this.lstEmployees);
            this.gbEmployees.Location = new System.Drawing.Point(380, 12);
            this.gbEmployees.Name = "gbEmployees";
            this.gbEmployees.Size = new System.Drawing.Size(362, 707);
            this.gbEmployees.TabIndex = 0;
            this.gbEmployees.TabStop = false;
            this.gbEmployees.Text = "Employees";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(81, 657);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(201, 34);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove Selected Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(81, 607);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(201, 34);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 16;
            this.lstEmployees.Location = new System.Drawing.Point(6, 21);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(350, 564);
            this.lstEmployees.TabIndex = 0;
            // 
            // gbMenuItems
            // 
            this.gbMenuItems.Controls.Add(this.btnRemoveMenuItem);
            this.gbMenuItems.Controls.Add(this.btnAddMenuItem);
            this.gbMenuItems.Controls.Add(this.lstMenuItems);
            this.gbMenuItems.Location = new System.Drawing.Point(12, 12);
            this.gbMenuItems.Name = "gbMenuItems";
            this.gbMenuItems.Size = new System.Drawing.Size(362, 707);
            this.gbMenuItems.TabIndex = 1;
            this.gbMenuItems.TabStop = false;
            this.gbMenuItems.Text = "Menu Items";
            // 
            // btnRemoveMenuItem
            // 
            this.btnRemoveMenuItem.Location = new System.Drawing.Point(81, 657);
            this.btnRemoveMenuItem.Name = "btnRemoveMenuItem";
            this.btnRemoveMenuItem.Size = new System.Drawing.Size(201, 34);
            this.btnRemoveMenuItem.TabIndex = 2;
            this.btnRemoveMenuItem.Text = "Remove Selected Item";
            this.btnRemoveMenuItem.UseVisualStyleBackColor = true;
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(81, 607);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(201, 34);
            this.btnAddMenuItem.TabIndex = 1;
            this.btnAddMenuItem.Text = "Add New Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            // 
            // lstMenuItems
            // 
            this.lstMenuItems.FormattingEnabled = true;
            this.lstMenuItems.ItemHeight = 16;
            this.lstMenuItems.Location = new System.Drawing.Point(6, 21);
            this.lstMenuItems.Name = "lstMenuItems";
            this.lstMenuItems.Size = new System.Drawing.Size(350, 564);
            this.lstMenuItems.TabIndex = 0;
            // 
            // gbDiscount
            // 
            this.gbDiscount.Controls.Add(this.btnGiveDiscount);
            this.gbDiscount.Controls.Add(this.txtDiscountPercent);
            this.gbDiscount.Controls.Add(this.txtDiscountOrderNumber);
            this.gbDiscount.Controls.Add(this.lblDiscountPercentage);
            this.gbDiscount.Controls.Add(this.lblOrderNumber);
            this.gbDiscount.Location = new System.Drawing.Point(749, 171);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Size = new System.Drawing.Size(307, 184);
            this.gbDiscount.TabIndex = 2;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "Discounts";
            // 
            // btnGiveDiscount
            // 
            this.btnGiveDiscount.Location = new System.Drawing.Point(32, 117);
            this.btnGiveDiscount.Name = "btnGiveDiscount";
            this.btnGiveDiscount.Size = new System.Drawing.Size(243, 32);
            this.btnGiveDiscount.TabIndex = 4;
            this.btnGiveDiscount.Text = "Give Discount";
            this.btnGiveDiscount.UseVisualStyleBackColor = true;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(132, 63);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(169, 22);
            this.txtDiscountPercent.TabIndex = 3;
            // 
            // txtDiscountOrderNumber
            // 
            this.txtDiscountOrderNumber.Location = new System.Drawing.Point(132, 32);
            this.txtDiscountOrderNumber.Name = "txtDiscountOrderNumber";
            this.txtDiscountOrderNumber.Size = new System.Drawing.Size(169, 22);
            this.txtDiscountOrderNumber.TabIndex = 2;
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Location = new System.Drawing.Point(6, 66);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(120, 17);
            this.lblDiscountPercentage.TabIndex = 1;
            this.lblDiscountPercentage.Text = "Discount Percent:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(23, 35);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(103, 17);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(781, 645);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(243, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearLists
            // 
            this.btnClearLists.Location = new System.Drawing.Point(781, 535);
            this.btnClearLists.Name = "btnClearLists";
            this.btnClearLists.Size = new System.Drawing.Size(243, 32);
            this.btnClearLists.TabIndex = 6;
            this.btnClearLists.Text = "Clear Lists";
            this.btnClearLists.UseVisualStyleBackColor = true;
            this.btnClearLists.Click += new System.EventHandler(this.btnClearLists_Click);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(850, 46);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(123, 25);
            this.lblCurrentDate.TabIndex = 7;
            this.lblCurrentDate.Text = "Current Date";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(850, 102);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(126, 25);
            this.lblCurrentTime.TabIndex = 8;
            this.lblCurrentTime.Text = "Current Time";
            // 
            // btnGetSalesReport
            // 
            this.btnGetSalesReport.Location = new System.Drawing.Point(781, 590);
            this.btnGetSalesReport.Name = "btnGetSalesReport";
            this.btnGetSalesReport.Size = new System.Drawing.Size(243, 32);
            this.btnGetSalesReport.TabIndex = 9;
            this.btnGetSalesReport.Text = "Get Sales Report";
            this.btnGetSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnGetEmployees
            // 
            this.btnGetEmployees.Location = new System.Drawing.Point(781, 480);
            this.btnGetEmployees.Name = "btnGetEmployees";
            this.btnGetEmployees.Size = new System.Drawing.Size(243, 32);
            this.btnGetEmployees.TabIndex = 10;
            this.btnGetEmployees.Text = "Get Employees";
            this.btnGetEmployees.UseVisualStyleBackColor = true;
            // 
            // btnGetMenuItems
            // 
            this.btnGetMenuItems.Location = new System.Drawing.Point(781, 425);
            this.btnGetMenuItems.Name = "btnGetMenuItems";
            this.btnGetMenuItems.Size = new System.Drawing.Size(243, 32);
            this.btnGetMenuItems.TabIndex = 11;
            this.btnGetMenuItems.Text = "Get Menu Items";
            this.btnGetMenuItems.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 731);
            this.Controls.Add(this.btnGetMenuItems);
            this.Controls.Add(this.btnGetEmployees);
            this.Controls.Add(this.btnGetSalesReport);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.btnClearLists);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDiscount);
            this.Controls.Add(this.gbMenuItems);
            this.Controls.Add(this.gbEmployees);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.gbEmployees.ResumeLayout(false);
            this.gbMenuItems.ResumeLayout(false);
            this.gbDiscount.ResumeLayout(false);
            this.gbDiscount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployees;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.GroupBox gbMenuItems;
        private System.Windows.Forms.Button btnRemoveMenuItem;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.ListBox lstMenuItems;
        private System.Windows.Forms.GroupBox gbDiscount;
        private System.Windows.Forms.Button btnGiveDiscount;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountOrderNumber;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearLists;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Button btnGetSalesReport;
        private System.Windows.Forms.Button btnGetEmployees;
        private System.Windows.Forms.Button btnGetMenuItems;
    }
}