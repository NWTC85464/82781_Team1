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
            this.components = new System.ComponentModel.Container();
            this.gbEmployees = new System.Windows.Forms.GroupBox();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePasscodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantrestaurantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new RestaurantPOS.RestaurantDataSet();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.gbMenuItems = new System.Windows.Forms.GroupBox();
            this.btnRemoveMenuItem = new System.Windows.Forms.Button();
            this.menuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnableItem = new System.Windows.Forms.Button();
            this.btnDisableItem = new System.Windows.Forms.Button();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.gbDiscount = new System.Windows.Forms.GroupBox();
            this.btnGiveDiscount = new System.Windows.Forms.Button();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountOrderNumber = new System.Windows.Forms.TextBox();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.btnGetSalesReport = new System.Windows.Forms.Button();
            this.lblLoggedInEmployeeName = new System.Windows.Forms.Label();
            this.employeesTableAdapter = new RestaurantPOS.RestaurantDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new RestaurantPOS.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.menuItemsTableAdapter = new RestaurantPOS.RestaurantDataSetTableAdapters.MenuItemsTableAdapter();
            this.gbEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            this.gbMenuItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            this.gbDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmployees
            // 
            this.gbEmployees.Controls.Add(this.employeesDataGridView);
            this.gbEmployees.Controls.Add(this.btnRemoveEmployee);
            this.gbEmployees.Controls.Add(this.btnAddEmployee);
            this.gbEmployees.Location = new System.Drawing.Point(5, 1);
            this.gbEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.gbEmployees.Name = "gbEmployees";
            this.gbEmployees.Padding = new System.Windows.Forms.Padding(2);
            this.gbEmployees.Size = new System.Drawing.Size(580, 243);
            this.gbEmployees.TabIndex = 0;
            this.gbEmployees.TabStop = false;
            this.gbEmployees.Text = "Employees";
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.employeePasscodeDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.restaurantrestaurantIdDataGridViewTextBoxColumn});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(6, 22);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(569, 184);
            this.employeesDataGridView.TabIndex = 16;
            // 
            // employeeNumberDataGridViewTextBoxColumn
            // 
            this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "employeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "employeeNumber";
            this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
            this.employeeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // employeePasscodeDataGridViewTextBoxColumn
            // 
            this.employeePasscodeDataGridViewTextBoxColumn.DataPropertyName = "employeePasscode";
            this.employeePasscodeDataGridViewTextBoxColumn.HeaderText = "employeePasscode";
            this.employeePasscodeDataGridViewTextBoxColumn.Name = "employeePasscodeDataGridViewTextBoxColumn";
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "jobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "jobTitle";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            // 
            // restaurantrestaurantIdDataGridViewTextBoxColumn
            // 
            this.restaurantrestaurantIdDataGridViewTextBoxColumn.DataPropertyName = "Restaurant_restaurantId";
            this.restaurantrestaurantIdDataGridViewTextBoxColumn.HeaderText = "Restaurant_restaurantId";
            this.restaurantrestaurantIdDataGridViewTextBoxColumn.Name = "restaurantrestaurantIdDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(424, 211);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(151, 28);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(269, 211);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(151, 28);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // gbMenuItems
            // 
            this.gbMenuItems.Controls.Add(this.btnRemoveMenuItem);
            this.gbMenuItems.Controls.Add(this.menuItemsDataGridView);
            this.gbMenuItems.Controls.Add(this.btnEnableItem);
            this.gbMenuItems.Controls.Add(this.btnDisableItem);
            this.gbMenuItems.Controls.Add(this.btnAddMenuItem);
            this.gbMenuItems.Location = new System.Drawing.Point(65, 250);
            this.gbMenuItems.Margin = new System.Windows.Forms.Padding(2);
            this.gbMenuItems.Name = "gbMenuItems";
            this.gbMenuItems.Padding = new System.Windows.Forms.Padding(2);
            this.gbMenuItems.Size = new System.Drawing.Size(689, 247);
            this.gbMenuItems.TabIndex = 1;
            this.gbMenuItems.TabStop = false;
            this.gbMenuItems.Text = "Menu Items";
            // 
            // btnRemoveMenuItem
            // 
            this.btnRemoveMenuItem.Location = new System.Drawing.Point(530, 215);
            this.btnRemoveMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMenuItem.Name = "btnRemoveMenuItem";
            this.btnRemoveMenuItem.Size = new System.Drawing.Size(151, 28);
            this.btnRemoveMenuItem.TabIndex = 16;
            this.btnRemoveMenuItem.Text = "Remove Menu Item";
            this.btnRemoveMenuItem.UseVisualStyleBackColor = true;
            this.btnRemoveMenuItem.Click += new System.EventHandler(this.btnRemoveMenuItem_Click);
            // 
            // menuItemsDataGridView
            // 
            this.menuItemsDataGridView.AutoGenerateColumns = false;
            this.menuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.menuItemsDataGridView.DataSource = this.menuItemsBindingSource;
            this.menuItemsDataGridView.Location = new System.Drawing.Point(5, 18);
            this.menuItemsDataGridView.Name = "menuItemsDataGridView";
            this.menuItemsDataGridView.Size = new System.Drawing.Size(676, 192);
            this.menuItemsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "menuItemId";
            this.dataGridViewTextBoxColumn6.HeaderText = "menuItemId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "menuItemName";
            this.dataGridViewTextBoxColumn7.HeaderText = "menuItemName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "menuItemPrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "menuItemPrice";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "menuItemDescription";
            this.dataGridViewTextBoxColumn9.HeaderText = "menuItemDescription";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "isItemActive";
            this.dataGridViewTextBoxColumn10.HeaderText = "isItemActive";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Menu_MenuId";
            this.dataGridViewTextBoxColumn11.HeaderText = "Menu_MenuId";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.restaurantDataSet;
            // 
            // btnEnableItem
            // 
            this.btnEnableItem.Location = new System.Drawing.Point(65, 215);
            this.btnEnableItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnableItem.Name = "btnEnableItem";
            this.btnEnableItem.Size = new System.Drawing.Size(151, 28);
            this.btnEnableItem.TabIndex = 15;
            this.btnEnableItem.Text = "Enable Item";
            this.btnEnableItem.UseVisualStyleBackColor = true;
            this.btnEnableItem.Click += new System.EventHandler(this.btnEnableItem_Click);
            // 
            // btnDisableItem
            // 
            this.btnDisableItem.Location = new System.Drawing.Point(220, 215);
            this.btnDisableItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisableItem.Name = "btnDisableItem";
            this.btnDisableItem.Size = new System.Drawing.Size(151, 28);
            this.btnDisableItem.TabIndex = 14;
            this.btnDisableItem.Text = "Disable Item";
            this.btnDisableItem.UseVisualStyleBackColor = true;
            this.btnDisableItem.Click += new System.EventHandler(this.btnDisableItem_Click);
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(375, 215);
            this.btnAddMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(151, 28);
            this.btnAddMenuItem.TabIndex = 1;
            this.btnAddMenuItem.Text = "Add New Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // gbDiscount
            // 
            this.gbDiscount.Controls.Add(this.btnGiveDiscount);
            this.gbDiscount.Controls.Add(this.txtDiscountPercent);
            this.gbDiscount.Controls.Add(this.txtDiscountOrderNumber);
            this.gbDiscount.Controls.Add(this.lblDiscountPercentage);
            this.gbDiscount.Controls.Add(this.lblOrderNumber);
            this.gbDiscount.Location = new System.Drawing.Point(592, 94);
            this.gbDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Padding = new System.Windows.Forms.Padding(2);
            this.gbDiscount.Size = new System.Drawing.Size(230, 150);
            this.gbDiscount.TabIndex = 2;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "Discounts";
            // 
            // btnGiveDiscount
            // 
            this.btnGiveDiscount.Location = new System.Drawing.Point(24, 95);
            this.btnGiveDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiveDiscount.Name = "btnGiveDiscount";
            this.btnGiveDiscount.Size = new System.Drawing.Size(182, 26);
            this.btnGiveDiscount.TabIndex = 4;
            this.btnGiveDiscount.Text = "Give Discount";
            this.btnGiveDiscount.UseVisualStyleBackColor = true;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(99, 51);
            this.txtDiscountPercent.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(128, 20);
            this.txtDiscountPercent.TabIndex = 3;
            // 
            // txtDiscountOrderNumber
            // 
            this.txtDiscountOrderNumber.Location = new System.Drawing.Point(99, 26);
            this.txtDiscountOrderNumber.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnExit.Location = new System.Drawing.Point(640, 517);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(587, 51);
            this.lblCurrentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(240, 30);
            this.lblCurrentDate.TabIndex = 7;
            this.lblCurrentDate.Text = "Current Date";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetSalesReport
            // 
            this.btnGetSalesReport.Location = new System.Drawing.Point(5, 517);
            this.btnGetSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetSalesReport.Name = "btnGetSalesReport";
            this.btnGetSalesReport.Size = new System.Drawing.Size(182, 26);
            this.btnGetSalesReport.TabIndex = 9;
            this.btnGetSalesReport.Text = "Get Sales Report";
            this.btnGetSalesReport.UseVisualStyleBackColor = true;
            // 
            // lblLoggedInEmployeeName
            // 
            this.lblLoggedInEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInEmployeeName.Location = new System.Drawing.Point(587, 9);
            this.lblLoggedInEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggedInEmployeeName.Name = "lblLoggedInEmployeeName";
            this.lblLoggedInEmployeeName.Size = new System.Drawing.Size(240, 30);
            this.lblLoggedInEmployeeName.TabIndex = 12;
            this.lblLoggedInEmployeeName.Text = "Logged In Employee Name";
            this.lblLoggedInEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Employees_ChefsTableAdapter = null;
            this.tableAdapterManager.Employees_ManagersTableAdapter = null;
            this.tableAdapterManager.Employees_WaitstaffsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.MenuItemsTableAdapter = this.menuItemsTableAdapter;
            this.tableAdapterManager.MenusTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.RestaurantsTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestaurantPOS.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuItemsTableAdapter
            // 
            this.menuItemsTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 554);
            this.Controls.Add(this.gbEmployees);
            this.Controls.Add(this.lblLoggedInEmployeeName);
            this.Controls.Add(this.btnGetSalesReport);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbDiscount);
            this.Controls.Add(this.gbMenuItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerForm";
            this.Text = "Manager Toolbox";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.gbEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            this.gbMenuItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            this.gbDiscount.ResumeLayout(false);
            this.gbDiscount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployees;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.GroupBox gbMenuItems;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.GroupBox gbDiscount;
        private System.Windows.Forms.Button btnGiveDiscount;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountOrderNumber;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Button btnGetSalesReport;
		private System.Windows.Forms.Button btnEnableItem;
		private System.Windows.Forms.Button btnDisableItem;
        private System.Windows.Forms.Label lblLoggedInEmployeeName;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private RestaurantDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private RestaurantDataSetTableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private System.Windows.Forms.DataGridView menuItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnRemoveMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasscodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantrestaurantIdDataGridViewTextBoxColumn;
    }
}