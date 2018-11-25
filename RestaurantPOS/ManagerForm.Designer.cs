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
            this.btnEnableItem = new System.Windows.Forms.Button();
            this.btnDisableItem = new System.Windows.Forms.Button();
            this.lblDisabledMenuList = new System.Windows.Forms.Label();
            this.lblActiveMenuTitle = new System.Windows.Forms.Label();
            this.lstDisabledMenuItems = new System.Windows.Forms.ListBox();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.lstActiveMenuItems = new System.Windows.Forms.ListBox();
            this.gbDiscount = new System.Windows.Forms.GroupBox();
            this.btnGiveDiscount = new System.Windows.Forms.Button();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountOrderNumber = new System.Windows.Forms.TextBox();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearLists = new System.Windows.Forms.Button();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.btnGetSalesReport = new System.Windows.Forms.Button();
            this.btnRefreshEmployees = new System.Windows.Forms.Button();
            this.btnRefreshMenuItems = new System.Windows.Forms.Button();
            this.lblCurrentEmployees = new System.Windows.Forms.Label();
            this.lblLoggedInEmployeeName = new System.Windows.Forms.Label();
            this.gbEmployees.SuspendLayout();
            this.gbMenuItems.SuspendLayout();
            this.gbDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmployees
            // 
            this.gbEmployees.Controls.Add(this.lblCurrentEmployees);
            this.gbEmployees.Controls.Add(this.btnRemoveEmployee);
            this.gbEmployees.Controls.Add(this.btnAddEmployee);
            this.gbEmployees.Controls.Add(this.lstEmployees);
            this.gbEmployees.Location = new System.Drawing.Point(554, 10);
            this.gbEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEmployees.Name = "gbEmployees";
            this.gbEmployees.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEmployees.Size = new System.Drawing.Size(272, 513);
            this.gbEmployees.TabIndex = 0;
            this.gbEmployees.TabStop = false;
            this.gbEmployees.Text = "Employees";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(61, 476);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(151, 28);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove Selected Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(61, 436);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(151, 28);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.Location = new System.Drawing.Point(4, 48);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(264, 368);
            this.lstEmployees.TabIndex = 0;
            // 
            // gbMenuItems
            // 
            this.gbMenuItems.Controls.Add(this.btnEnableItem);
            this.gbMenuItems.Controls.Add(this.btnDisableItem);
            this.gbMenuItems.Controls.Add(this.lblDisabledMenuList);
            this.gbMenuItems.Controls.Add(this.lblActiveMenuTitle);
            this.gbMenuItems.Controls.Add(this.lstDisabledMenuItems);
            this.gbMenuItems.Controls.Add(this.btnAddMenuItem);
            this.gbMenuItems.Controls.Add(this.lstActiveMenuItems);
            this.gbMenuItems.Location = new System.Drawing.Point(9, 10);
            this.gbMenuItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMenuItems.Name = "gbMenuItems";
            this.gbMenuItems.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMenuItems.Size = new System.Drawing.Size(541, 513);
            this.gbMenuItems.TabIndex = 1;
            this.gbMenuItems.TabStop = false;
            this.gbMenuItems.Text = "Menu Items";
            // 
            // btnEnableItem
            // 
            this.btnEnableItem.Location = new System.Drawing.Point(331, 436);
            this.btnEnableItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnableItem.Name = "btnEnableItem";
            this.btnEnableItem.Size = new System.Drawing.Size(151, 28);
            this.btnEnableItem.TabIndex = 15;
            this.btnEnableItem.Text = "Enable Item";
            this.btnEnableItem.UseVisualStyleBackColor = true;
            // 
            // btnDisableItem
            // 
            this.btnDisableItem.Location = new System.Drawing.Point(63, 476);
            this.btnDisableItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisableItem.Name = "btnDisableItem";
            this.btnDisableItem.Size = new System.Drawing.Size(151, 28);
            this.btnDisableItem.TabIndex = 14;
            this.btnDisableItem.Text = "Disable Item";
            this.btnDisableItem.UseVisualStyleBackColor = true;
            // 
            // lblDisabledMenuList
            // 
            this.lblDisabledMenuList.AutoSize = true;
            this.lblDisabledMenuList.Location = new System.Drawing.Point(276, 32);
            this.lblDisabledMenuList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisabledMenuList.Name = "lblDisabledMenuList";
            this.lblDisabledMenuList.Size = new System.Drawing.Size(109, 13);
            this.lblDisabledMenuList.TabIndex = 13;
            this.lblDisabledMenuList.Text = "Disabled Menu Items:";
            // 
            // lblActiveMenuTitle
            // 
            this.lblActiveMenuTitle.AutoSize = true;
            this.lblActiveMenuTitle.Location = new System.Drawing.Point(4, 32);
            this.lblActiveMenuTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveMenuTitle.Name = "lblActiveMenuTitle";
            this.lblActiveMenuTitle.Size = new System.Drawing.Size(98, 13);
            this.lblActiveMenuTitle.TabIndex = 12;
            this.lblActiveMenuTitle.Text = "Active Menu Items:";
            // 
            // lstDisabledMenuItems
            // 
            this.lstDisabledMenuItems.FormattingEnabled = true;
            this.lstDisabledMenuItems.Location = new System.Drawing.Point(278, 49);
            this.lstDisabledMenuItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDisabledMenuItems.Name = "lstDisabledMenuItems";
            this.lstDisabledMenuItems.Size = new System.Drawing.Size(259, 368);
            this.lstDisabledMenuItems.TabIndex = 3;
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(63, 436);
            this.btnAddMenuItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(151, 28);
            this.btnAddMenuItem.TabIndex = 1;
            this.btnAddMenuItem.Text = "Add New Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // lstActiveMenuItems
            // 
            this.lstActiveMenuItems.FormattingEnabled = true;
            this.lstActiveMenuItems.Location = new System.Drawing.Point(7, 49);
            this.lstActiveMenuItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstActiveMenuItems.Name = "lstActiveMenuItems";
            this.lstActiveMenuItems.Size = new System.Drawing.Size(264, 368);
            this.lstActiveMenuItems.TabIndex = 0;
            // 
            // gbDiscount
            // 
            this.gbDiscount.Controls.Add(this.btnGiveDiscount);
            this.gbDiscount.Controls.Add(this.txtDiscountPercent);
            this.gbDiscount.Controls.Add(this.txtDiscountOrderNumber);
            this.gbDiscount.Controls.Add(this.lblDiscountPercentage);
            this.gbDiscount.Controls.Add(this.lblOrderNumber);
            this.gbDiscount.Location = new System.Drawing.Point(835, 128);
            this.gbDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDiscount.Size = new System.Drawing.Size(230, 150);
            this.gbDiscount.TabIndex = 2;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "Discounts";
            // 
            // btnGiveDiscount
            // 
            this.btnGiveDiscount.Location = new System.Drawing.Point(24, 95);
            this.btnGiveDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGiveDiscount.Name = "btnGiveDiscount";
            this.btnGiveDiscount.Size = new System.Drawing.Size(182, 26);
            this.btnGiveDiscount.TabIndex = 4;
            this.btnGiveDiscount.Text = "Give Discount";
            this.btnGiveDiscount.UseVisualStyleBackColor = true;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(99, 51);
            this.txtDiscountPercent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(128, 20);
            this.txtDiscountPercent.TabIndex = 3;
            // 
            // txtDiscountOrderNumber
            // 
            this.txtDiscountOrderNumber.Location = new System.Drawing.Point(99, 26);
            this.txtDiscountOrderNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiscountOrderNumber.Name = "txtDiscountOrderNumber";
            this.txtDiscountOrderNumber.Size = new System.Drawing.Size(128, 20);
            this.txtDiscountOrderNumber.TabIndex = 2;
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Location = new System.Drawing.Point(4, 54);
            this.lblDiscountPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(92, 13);
            this.lblDiscountPercentage.TabIndex = 1;
            this.lblDiscountPercentage.Text = "Discount Percent:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(17, 28);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(76, 13);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(859, 488);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearLists
            // 
            this.btnClearLists.Location = new System.Drawing.Point(859, 398);
            this.btnClearLists.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearLists.Name = "btnClearLists";
            this.btnClearLists.Size = new System.Drawing.Size(182, 26);
            this.btnClearLists.TabIndex = 6;
            this.btnClearLists.Text = "Clear Lists";
            this.btnClearLists.UseVisualStyleBackColor = true;
            this.btnClearLists.Click += new System.EventHandler(this.btnClearLists_Click);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(830, 79);
            this.lblCurrentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(240, 30);
            this.lblCurrentDate.TabIndex = 7;
            this.lblCurrentDate.Text = "Current Date";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetSalesReport
            // 
            this.btnGetSalesReport.Location = new System.Drawing.Point(859, 443);
            this.btnGetSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetSalesReport.Name = "btnGetSalesReport";
            this.btnGetSalesReport.Size = new System.Drawing.Size(182, 26);
            this.btnGetSalesReport.TabIndex = 9;
            this.btnGetSalesReport.Text = "Get Sales Report";
            this.btnGetSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnRefreshEmployees
            // 
            this.btnRefreshEmployees.Location = new System.Drawing.Point(859, 353);
            this.btnRefreshEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshEmployees.Name = "btnRefreshEmployees";
            this.btnRefreshEmployees.Size = new System.Drawing.Size(182, 26);
            this.btnRefreshEmployees.TabIndex = 10;
            this.btnRefreshEmployees.Text = "Refresh Employees";
            this.btnRefreshEmployees.UseVisualStyleBackColor = true;
            // 
            // btnRefreshMenuItems
            // 
            this.btnRefreshMenuItems.Location = new System.Drawing.Point(859, 309);
            this.btnRefreshMenuItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshMenuItems.Name = "btnRefreshMenuItems";
            this.btnRefreshMenuItems.Size = new System.Drawing.Size(182, 26);
            this.btnRefreshMenuItems.TabIndex = 11;
            this.btnRefreshMenuItems.Text = "Refresh Menu Items";
            this.btnRefreshMenuItems.UseVisualStyleBackColor = true;
            // 
            // lblCurrentEmployees
            // 
            this.lblCurrentEmployees.AutoSize = true;
            this.lblCurrentEmployees.Location = new System.Drawing.Point(4, 32);
            this.lblCurrentEmployees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentEmployees.Name = "lblCurrentEmployees";
            this.lblCurrentEmployees.Size = new System.Drawing.Size(98, 13);
            this.lblCurrentEmployees.TabIndex = 16;
            this.lblCurrentEmployees.Text = "Current Employees:";
            // 
            // lblLoggedInEmployeeName
            // 
            this.lblLoggedInEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInEmployeeName.Location = new System.Drawing.Point(829, 25);
            this.lblLoggedInEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggedInEmployeeName.Name = "lblLoggedInEmployeeName";
            this.lblLoggedInEmployeeName.Size = new System.Drawing.Size(240, 30);
            this.lblLoggedInEmployeeName.TabIndex = 12;
            this.lblLoggedInEmployeeName.Text = "Logged In Employee Name";
            this.lblLoggedInEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 529);
            this.Controls.Add(this.lblLoggedInEmployeeName);
            this.Controls.Add(this.btnRefreshMenuItems);
            this.Controls.Add(this.btnRefreshEmployees);
            this.Controls.Add(this.btnGetSalesReport);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.btnClearLists);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDiscount);
            this.Controls.Add(this.gbMenuItems);
            this.Controls.Add(this.gbEmployees);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.gbEmployees.ResumeLayout(false);
            this.gbEmployees.PerformLayout();
            this.gbMenuItems.ResumeLayout(false);
            this.gbMenuItems.PerformLayout();
            this.gbDiscount.ResumeLayout(false);
            this.gbDiscount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployees;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.GroupBox gbMenuItems;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.ListBox lstActiveMenuItems;
        private System.Windows.Forms.GroupBox gbDiscount;
        private System.Windows.Forms.Button btnGiveDiscount;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountOrderNumber;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearLists;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Button btnGetSalesReport;
        private System.Windows.Forms.Button btnRefreshEmployees;
        private System.Windows.Forms.Button btnRefreshMenuItems;
		private System.Windows.Forms.ListBox lstDisabledMenuItems;
		private System.Windows.Forms.Button btnEnableItem;
		private System.Windows.Forms.Button btnDisableItem;
		private System.Windows.Forms.Label lblDisabledMenuList;
		private System.Windows.Forms.Label lblActiveMenuTitle;
        private System.Windows.Forms.Label lblCurrentEmployees;
        private System.Windows.Forms.Label lblLoggedInEmployeeName;
    }
}