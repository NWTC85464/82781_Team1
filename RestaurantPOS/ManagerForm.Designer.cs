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
			this.btnGetEmployees = new System.Windows.Forms.Button();
			this.btnGetMenuItems = new System.Windows.Forms.Button();
			this.lstDisabledMenuItems = new System.Windows.Forms.ListBox();
			this.lblActiveMenuTitle = new System.Windows.Forms.Label();
			this.lblDisabledMenuList = new System.Windows.Forms.Label();
			this.btnDisableItem = new System.Windows.Forms.Button();
			this.btnEnableItem = new System.Windows.Forms.Button();
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
			this.gbEmployees.Location = new System.Drawing.Point(739, 12);
			this.gbEmployees.Name = "gbEmployees";
			this.gbEmployees.Size = new System.Drawing.Size(362, 631);
			this.gbEmployees.TabIndex = 0;
			this.gbEmployees.TabStop = false;
			this.gbEmployees.Text = "Employees";
			// 
			// btnRemoveEmployee
			// 
			this.btnRemoveEmployee.Location = new System.Drawing.Point(81, 586);
			this.btnRemoveEmployee.Name = "btnRemoveEmployee";
			this.btnRemoveEmployee.Size = new System.Drawing.Size(201, 34);
			this.btnRemoveEmployee.TabIndex = 2;
			this.btnRemoveEmployee.Text = "Remove Selected Employee";
			this.btnRemoveEmployee.UseVisualStyleBackColor = true;
			// 
			// btnAddEmployee
			// 
			this.btnAddEmployee.Location = new System.Drawing.Point(81, 536);
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
			this.lstEmployees.Location = new System.Drawing.Point(6, 59);
			this.lstEmployees.Name = "lstEmployees";
			this.lstEmployees.Size = new System.Drawing.Size(350, 452);
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
			this.gbMenuItems.Location = new System.Drawing.Point(12, 12);
			this.gbMenuItems.Name = "gbMenuItems";
			this.gbMenuItems.Size = new System.Drawing.Size(721, 631);
			this.gbMenuItems.TabIndex = 1;
			this.gbMenuItems.TabStop = false;
			this.gbMenuItems.Text = "Menu Items";
			// 
			// btnAddMenuItem
			// 
			this.btnAddMenuItem.Location = new System.Drawing.Point(84, 536);
			this.btnAddMenuItem.Name = "btnAddMenuItem";
			this.btnAddMenuItem.Size = new System.Drawing.Size(201, 34);
			this.btnAddMenuItem.TabIndex = 1;
			this.btnAddMenuItem.Text = "Add New Menu Item";
			this.btnAddMenuItem.UseVisualStyleBackColor = true;
			// 
			// lstActiveMenuItems
			// 
			this.lstActiveMenuItems.FormattingEnabled = true;
			this.lstActiveMenuItems.ItemHeight = 16;
			this.lstActiveMenuItems.Location = new System.Drawing.Point(9, 60);
			this.lstActiveMenuItems.Name = "lstActiveMenuItems";
			this.lstActiveMenuItems.Size = new System.Drawing.Size(350, 452);
			this.lstActiveMenuItems.TabIndex = 0;
			// 
			// gbDiscount
			// 
			this.gbDiscount.Controls.Add(this.btnGiveDiscount);
			this.gbDiscount.Controls.Add(this.txtDiscountPercent);
			this.gbDiscount.Controls.Add(this.txtDiscountOrderNumber);
			this.gbDiscount.Controls.Add(this.lblDiscountPercentage);
			this.gbDiscount.Controls.Add(this.lblOrderNumber);
			this.gbDiscount.Location = new System.Drawing.Point(1113, 158);
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
			this.btnExit.Location = new System.Drawing.Point(1145, 600);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(243, 32);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnClearLists
			// 
			this.btnClearLists.Location = new System.Drawing.Point(1145, 490);
			this.btnClearLists.Name = "btnClearLists";
			this.btnClearLists.Size = new System.Drawing.Size(243, 32);
			this.btnClearLists.TabIndex = 6;
			this.btnClearLists.Text = "Clear Lists";
			this.btnClearLists.UseVisualStyleBackColor = true;
			this.btnClearLists.Click += new System.EventHandler(this.btnClearLists_Click);
			// 
			// lblCurrentDate
			// 
			this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentDate.Location = new System.Drawing.Point(1106, 75);
			this.lblCurrentDate.Name = "lblCurrentDate";
			this.lblCurrentDate.Size = new System.Drawing.Size(320, 37);
			this.lblCurrentDate.TabIndex = 7;
			this.lblCurrentDate.Text = "Current Date";
			this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGetSalesReport
			// 
			this.btnGetSalesReport.Location = new System.Drawing.Point(1145, 545);
			this.btnGetSalesReport.Name = "btnGetSalesReport";
			this.btnGetSalesReport.Size = new System.Drawing.Size(243, 32);
			this.btnGetSalesReport.TabIndex = 9;
			this.btnGetSalesReport.Text = "Get Sales Report";
			this.btnGetSalesReport.UseVisualStyleBackColor = true;
			// 
			// btnGetEmployees
			// 
			this.btnGetEmployees.Location = new System.Drawing.Point(1145, 435);
			this.btnGetEmployees.Name = "btnGetEmployees";
			this.btnGetEmployees.Size = new System.Drawing.Size(243, 32);
			this.btnGetEmployees.TabIndex = 10;
			this.btnGetEmployees.Text = "Get Employees";
			this.btnGetEmployees.UseVisualStyleBackColor = true;
			// 
			// btnGetMenuItems
			// 
			this.btnGetMenuItems.Location = new System.Drawing.Point(1145, 380);
			this.btnGetMenuItems.Name = "btnGetMenuItems";
			this.btnGetMenuItems.Size = new System.Drawing.Size(243, 32);
			this.btnGetMenuItems.TabIndex = 11;
			this.btnGetMenuItems.Text = "Get Menu Items";
			this.btnGetMenuItems.UseVisualStyleBackColor = true;
			// 
			// lstDisabledMenuItems
			// 
			this.lstDisabledMenuItems.FormattingEnabled = true;
			this.lstDisabledMenuItems.ItemHeight = 16;
			this.lstDisabledMenuItems.Location = new System.Drawing.Point(371, 60);
			this.lstDisabledMenuItems.Name = "lstDisabledMenuItems";
			this.lstDisabledMenuItems.Size = new System.Drawing.Size(350, 452);
			this.lstDisabledMenuItems.TabIndex = 3;
			// 
			// lblActiveMenuTitle
			// 
			this.lblActiveMenuTitle.AutoSize = true;
			this.lblActiveMenuTitle.Location = new System.Drawing.Point(6, 40);
			this.lblActiveMenuTitle.Name = "lblActiveMenuTitle";
			this.lblActiveMenuTitle.Size = new System.Drawing.Size(126, 17);
			this.lblActiveMenuTitle.TabIndex = 12;
			this.lblActiveMenuTitle.Text = "Active Menu Items:";
			// 
			// lblDisabledMenuList
			// 
			this.lblDisabledMenuList.AutoSize = true;
			this.lblDisabledMenuList.Location = new System.Drawing.Point(368, 40);
			this.lblDisabledMenuList.Name = "lblDisabledMenuList";
			this.lblDisabledMenuList.Size = new System.Drawing.Size(143, 17);
			this.lblDisabledMenuList.TabIndex = 13;
			this.lblDisabledMenuList.Text = "Disabled Menu Items:";
			// 
			// btnDisableItem
			// 
			this.btnDisableItem.Location = new System.Drawing.Point(84, 586);
			this.btnDisableItem.Name = "btnDisableItem";
			this.btnDisableItem.Size = new System.Drawing.Size(201, 34);
			this.btnDisableItem.TabIndex = 14;
			this.btnDisableItem.Text = "Disable Item";
			this.btnDisableItem.UseVisualStyleBackColor = true;
			// 
			// btnEnableItem
			// 
			this.btnEnableItem.Location = new System.Drawing.Point(441, 536);
			this.btnEnableItem.Name = "btnEnableItem";
			this.btnEnableItem.Size = new System.Drawing.Size(201, 34);
			this.btnEnableItem.TabIndex = 15;
			this.btnEnableItem.Text = "Enable Item";
			this.btnEnableItem.UseVisualStyleBackColor = true;
			// 
			// ManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 651);
			this.Controls.Add(this.btnGetMenuItems);
			this.Controls.Add(this.btnGetEmployees);
			this.Controls.Add(this.btnGetSalesReport);
			this.Controls.Add(this.lblCurrentDate);
			this.Controls.Add(this.btnClearLists);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.gbDiscount);
			this.Controls.Add(this.gbMenuItems);
			this.Controls.Add(this.gbEmployees);
			this.Name = "ManagerForm";
			this.Text = "ManagerForm";
			this.Load += new System.EventHandler(this.ManagerForm_Load);
			this.gbEmployees.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnGetEmployees;
        private System.Windows.Forms.Button btnGetMenuItems;
		private System.Windows.Forms.ListBox lstDisabledMenuItems;
		private System.Windows.Forms.Button btnEnableItem;
		private System.Windows.Forms.Button btnDisableItem;
		private System.Windows.Forms.Label lblDisabledMenuList;
		private System.Windows.Forms.Label lblActiveMenuTitle;
	}
}