namespace RestaurantPOS
{
    partial class WaitstaffForm
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
            System.Windows.Forms.Label tableNumberLabel1;
            System.Windows.Forms.Label tableNumberLabel2;
            this.appetizersGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuItemsComboBox = new System.Windows.Forms.ComboBox();
            this.menuItemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new RestaurantPOS.RestaurantDataSet();
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderPreviewListBox = new System.Windows.Forms.ListBox();
            this.BtnSendOrder = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuItemsTableAdapter = new RestaurantPOS.RestaurantDataSetTableAdapters.MenuItemsTableAdapter();
            this.tableAdapterManager = new RestaurantPOS.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.menuItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablesTableAdapter = new RestaurantPOS.RestaurantDataSetTableAdapters.TablesTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new RestaurantPOS.RestaurantDataSetTableAdapters.EmployeesTableAdapter();
            this.WaitstaffNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMyTables = new System.Windows.Forms.GroupBox();
            this.btnSelectMyTable = new System.Windows.Forms.Button();
            this.gbOpenTables = new System.Windows.Forms.GroupBox();
            this.btnSelectOpenTable = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new RestaurantPOS.RestaurantDataSetTableAdapters.OrdersTableAdapter();
            this.tableNumberComboBox = new System.Windows.Forms.ComboBox();
            this.tablesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tableNumberLabel1 = new System.Windows.Forms.Label();
            tableNumberLabel2 = new System.Windows.Forms.Label();
            this.appetizersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.gbMyTables.SuspendLayout();
            this.gbOpenTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableNumberLabel1
            // 
            tableNumberLabel1.AutoSize = true;
            tableNumberLabel1.Location = new System.Drawing.Point(64, 32);
            tableNumberLabel1.Name = "tableNumberLabel1";
            tableNumberLabel1.Size = new System.Drawing.Size(97, 17);
            tableNumberLabel1.TabIndex = 4;
            tableNumberLabel1.Text = "table Number:";
            // 
            // appetizersGroupBox
            // 
            this.appetizersGroupBox.Controls.Add(this.label2);
            this.appetizersGroupBox.Controls.Add(this.numericUpDown1);
            this.appetizersGroupBox.Controls.Add(this.button1);
            this.appetizersGroupBox.Controls.Add(this.label1);
            this.appetizersGroupBox.Controls.Add(this.menuItemsComboBox);
            this.appetizersGroupBox.Location = new System.Drawing.Point(16, 43);
            this.appetizersGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.appetizersGroupBox.Name = "appetizersGroupBox";
            this.appetizersGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.appetizersGroupBox.Size = new System.Drawing.Size(627, 192);
            this.appetizersGroupBox.TabIndex = 0;
            this.appetizersGroupBox.TabStop = false;
            this.appetizersGroupBox.Text = "Item Selection";
            this.appetizersGroupBox.Enter += new System.EventHandler(this.AppetizersGroupBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(219, 89);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Menu Item: ";
            // 
            // menuItemsComboBox
            // 
            this.menuItemsComboBox.DataSource = this.menuItemsBindingSource2;
            this.menuItemsComboBox.DisplayMember = "menuItemName";
            this.menuItemsComboBox.FormattingEnabled = true;
            this.menuItemsComboBox.Location = new System.Drawing.Point(219, 38);
            this.menuItemsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.menuItemsComboBox.Name = "menuItemsComboBox";
            this.menuItemsComboBox.Size = new System.Drawing.Size(399, 24);
            this.menuItemsComboBox.TabIndex = 0;
            this.menuItemsComboBox.ValueMember = "menuItemId";
            this.menuItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.menuItemsComboBox_SelectedIndexChanged);
            // 
            // menuItemsBindingSource2
            // 
            this.menuItemsBindingSource2.DataMember = "MenuItems";
            this.menuItemsBindingSource2.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.restaurantDataSet;
            // 
            // orderPreviewListBox
            // 
            this.orderPreviewListBox.FormattingEnabled = true;
            this.orderPreviewListBox.ItemHeight = 16;
            this.orderPreviewListBox.Location = new System.Drawing.Point(672, 0);
            this.orderPreviewListBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderPreviewListBox.Name = "orderPreviewListBox";
            this.orderPreviewListBox.Size = new System.Drawing.Size(280, 452);
            this.orderPreviewListBox.TabIndex = 3;
            // 
            // BtnSendOrder
            // 
            this.BtnSendOrder.Location = new System.Drawing.Point(717, 460);
            this.BtnSendOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSendOrder.Name = "BtnSendOrder";
            this.BtnSendOrder.Size = new System.Drawing.Size(192, 52);
            this.BtnSendOrder.TabIndex = 5;
            this.BtnSendOrder.Text = "Send Order";
            this.BtnSendOrder.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(896, 548);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // menuItemsTableAdapter
            // 
            this.menuItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Employees_ChefsTableAdapter = null;
            this.tableAdapterManager.Employees_ManagersTableAdapter = null;
            this.tableAdapterManager.Employees_WaitstaffsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.MenuItemsTableAdapter = this.menuItemsTableAdapter;
            this.tableAdapterManager.MenusTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.RestaurantsTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TablesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestaurantPOS.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuItemsBindingSource1
            // 
            this.menuItemsBindingSource1.DataMember = "MenuItems";
            this.menuItemsBindingSource1.DataSource = this.restaurantDataSet;
            // 
            // tablesBindingSource
            // 
            this.tablesBindingSource.DataMember = "Tables";
            this.tablesBindingSource.DataSource = this.restaurantDataSet;
            // 
            // tablesTableAdapter
            // 
            this.tablesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.restaurantDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // WaitstaffNameLabel
            // 
            this.WaitstaffNameLabel.AutoSize = true;
            this.WaitstaffNameLabel.Location = new System.Drawing.Point(269, 11);
            this.WaitstaffNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WaitstaffNameLabel.Name = "WaitstaffNameLabel";
            this.WaitstaffNameLabel.Size = new System.Drawing.Size(45, 17);
            this.WaitstaffNameLabel.TabIndex = 7;
            this.WaitstaffNameLabel.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "User: ";
            // 
            // gbMyTables
            // 
            this.gbMyTables.Controls.Add(tableNumberLabel2);
            this.gbMyTables.Controls.Add(this.tableNumberComboBox);
            this.gbMyTables.Controls.Add(this.btnSelectMyTable);
            this.gbMyTables.Location = new System.Drawing.Point(16, 243);
            this.gbMyTables.Margin = new System.Windows.Forms.Padding(4);
            this.gbMyTables.Name = "gbMyTables";
            this.gbMyTables.Padding = new System.Windows.Forms.Padding(4);
            this.gbMyTables.Size = new System.Drawing.Size(304, 151);
            this.gbMyTables.TabIndex = 5;
            this.gbMyTables.TabStop = false;
            this.gbMyTables.Text = "My Tables";
            // 
            // btnSelectMyTable
            // 
            this.btnSelectMyTable.Location = new System.Drawing.Point(40, 77);
            this.btnSelectMyTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectMyTable.Name = "btnSelectMyTable";
            this.btnSelectMyTable.Size = new System.Drawing.Size(192, 52);
            this.btnSelectMyTable.TabIndex = 4;
            this.btnSelectMyTable.Text = "Select";
            this.btnSelectMyTable.UseVisualStyleBackColor = true;
            // 
            // gbOpenTables
            // 
            this.gbOpenTables.Controls.Add(tableNumberLabel1);
            this.gbOpenTables.Controls.Add(this.btnSelectOpenTable);
            this.gbOpenTables.Location = new System.Drawing.Point(323, 243);
            this.gbOpenTables.Margin = new System.Windows.Forms.Padding(4);
            this.gbOpenTables.Name = "gbOpenTables";
            this.gbOpenTables.Padding = new System.Windows.Forms.Padding(4);
            this.gbOpenTables.Size = new System.Drawing.Size(353, 152);
            this.gbOpenTables.TabIndex = 6;
            this.gbOpenTables.TabStop = false;
            this.gbOpenTables.Text = "Open Tables";
            // 
            // btnSelectOpenTable
            // 
            this.btnSelectOpenTable.Location = new System.Drawing.Point(65, 77);
            this.btnSelectOpenTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOpenTable.Name = "btnSelectOpenTable";
            this.btnSelectOpenTable.Size = new System.Drawing.Size(192, 52);
            this.btnSelectOpenTable.TabIndex = 4;
            this.btnSelectOpenTable.Text = "Select";
            this.btnSelectOpenTable.UseVisualStyleBackColor = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "FK_Orders_Tables";
            this.ordersBindingSource.DataSource = this.tablesBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableNumberLabel2
            // 
            tableNumberLabel2.AutoSize = true;
            tableNumberLabel2.Location = new System.Drawing.Point(49, 32);
            tableNumberLabel2.Name = "tableNumberLabel2";
            tableNumberLabel2.Size = new System.Drawing.Size(97, 17);
            tableNumberLabel2.TabIndex = 4;
            tableNumberLabel2.Text = "table Number:";
            // 
            // tableNumberComboBox
            // 
            this.tableNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablesBindingSource, "tableNumber", true));
            this.tableNumberComboBox.FormattingEnabled = true;
            this.tableNumberComboBox.Location = new System.Drawing.Point(152, 29);
            this.tableNumberComboBox.Name = "tableNumberComboBox";
            this.tableNumberComboBox.Size = new System.Drawing.Size(121, 24);
            this.tableNumberComboBox.TabIndex = 5;
            // 
            // tablesDataGridView
            // 
            this.tablesDataGridView.AutoGenerateColumns = false;
            this.tablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tablesDataGridView.DataSource = this.tablesBindingSource;
            this.tablesDataGridView.Location = new System.Drawing.Point(56, 431);
            this.tablesDataGridView.Name = "tablesDataGridView";
            this.tablesDataGridView.RowTemplate.Height = 24;
            this.tablesDataGridView.Size = new System.Drawing.Size(609, 220);
            this.tablesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tableNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "tableNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numberOfGuests";
            this.dataGridViewTextBoxColumn2.HeaderText = "numberOfGuests";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "isActive";
            this.dataGridViewTextBoxColumn3.HeaderText = "isActive";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "employeeNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "employeeNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // WaitstaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 749);
            this.Controls.Add(this.tablesDataGridView);
            this.Controls.Add(this.gbOpenTables);
            this.Controls.Add(this.gbMyTables);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WaitstaffNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.BtnSendOrder);
            this.Controls.Add(this.orderPreviewListBox);
            this.Controls.Add(this.appetizersGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WaitstaffForm";
            this.Text = "POS Terminal";
            this.Load += new System.EventHandler(this.WaitstaffForm_Load);
            this.appetizersGroupBox.ResumeLayout(false);
            this.appetizersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.gbMyTables.ResumeLayout(false);
            this.gbMyTables.PerformLayout();
            this.gbOpenTables.ResumeLayout(false);
            this.gbOpenTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox appetizersGroupBox;
        private System.Windows.Forms.ListBox orderPreviewListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSendOrder;
        private System.Windows.Forms.Button exitButton;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private RestaurantDataSetTableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource menuItemsBindingSource1;
        private System.Windows.Forms.ComboBox menuItemsComboBox;
        private System.Windows.Forms.BindingSource menuItemsBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private RestaurantDataSetTableAdapters.TablesTableAdapter tablesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private RestaurantDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label WaitstaffNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMyTables;
        private System.Windows.Forms.Button btnSelectMyTable;
        private System.Windows.Forms.GroupBox gbOpenTables;
        private System.Windows.Forms.Button btnSelectOpenTable;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private RestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ComboBox tableNumberComboBox;
        private System.Windows.Forms.DataGridView tablesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

