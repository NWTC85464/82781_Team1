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
            System.Windows.Forms.Label tableNumberLabel;
            System.Windows.Forms.Label menuItemNameLabel;
            this.appetizersGroupBox = new System.Windows.Forms.GroupBox();
            this.fillByToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.menuItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new RestaurantPOS.RestaurantDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityUpDownSelector = new System.Windows.Forms.NumericUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.menuItemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
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
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableNumberComboBox = new System.Windows.Forms.ComboBox();
            this.btnSelectMyTable = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new RestaurantPOS.RestaurantDataSetTableAdapters.OrdersTableAdapter();

            this.fillByMyTableToolStrip = new System.Windows.Forms.ToolStrip();
            this.activeEmployeeNumberToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.activeEmployeeNumberToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByMyTableToolStripButton = new System.Windows.Forms.ToolStripButton();

            tableNumberLabel = new System.Windows.Forms.Label();
            menuItemNameLabel = new System.Windows.Forms.Label();
            this.appetizersGroupBox.SuspendLayout();
            this.fillByToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDownSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.gbMyTables.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();

            this.fillByMyTableToolStrip.SuspendLayout();

            this.SuspendLayout();
            // 
            // tableNumberLabel
            // 
            tableNumberLabel.AutoSize = true;
            tableNumberLabel.Location = new System.Drawing.Point(40, 80);
            tableNumberLabel.Name = "tableNumberLabel";
            tableNumberLabel.Size = new System.Drawing.Size(73, 13);
            tableNumberLabel.TabIndex = 4;
            tableNumberLabel.Text = "table Number:";
            // 
            // menuItemNameLabel
            // 
            menuItemNameLabel.AutoSize = true;
            menuItemNameLabel.Location = new System.Drawing.Point(131, 37);
            menuItemNameLabel.Name = "menuItemNameLabel";
            menuItemNameLabel.Size = new System.Drawing.Size(63, 13);
            menuItemNameLabel.TabIndex = 4;
            menuItemNameLabel.Text = "Select Item:";
            // 
            // appetizersGroupBox
            // 
            this.appetizersGroupBox.Controls.Add(this.fillByToolStrip2);
            this.appetizersGroupBox.Controls.Add(menuItemNameLabel);
            this.appetizersGroupBox.Controls.Add(this.menuItemNameComboBox);
            this.appetizersGroupBox.Controls.Add(this.label2);

            this.appetizersGroupBox.Controls.Add(this.numericUpDown1);
            this.appetizersGroupBox.Controls.Add(this.button1);
            this.appetizersGroupBox.Location = new System.Drawing.Point(15, 201);

            this.appetizersGroupBox.Name = "appetizersGroupBox";
            this.appetizersGroupBox.Size = new System.Drawing.Size(369, 123);
            this.appetizersGroupBox.TabIndex = 0;
            this.appetizersGroupBox.TabStop = false;
            this.appetizersGroupBox.Text = "Item Selection";
            this.appetizersGroupBox.Enter += new System.EventHandler(this.AppetizersGroupBox_Enter);
            // 
            // fillByToolStrip2
            // 
            this.fillByToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton2});
            this.fillByToolStrip2.Location = new System.Drawing.Point(3, 30);
            this.fillByToolStrip2.Name = "fillByToolStrip2";
            this.fillByToolStrip2.Size = new System.Drawing.Size(117, 25);
            this.fillByToolStrip2.TabIndex = 10;
            this.fillByToolStrip2.Text = "fillByToolStrip2";
            // 
            // fillByToolStripButton2
            // 

            this.fillByToolStripButton2.BackColor = System.Drawing.Color.CadetBlue;

            this.fillByToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton2.Name = "fillByToolStripButton2";
            this.fillByToolStripButton2.Size = new System.Drawing.Size(105, 22);
            this.fillByToolStripButton2.Text = "Load Active Items";
            this.fillByToolStripButton2.Click += new System.EventHandler(this.fillByToolStripButton2_Click);
            // 
            // menuItemNameComboBox
            // 
            this.menuItemNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuItemsBindingSource, "menuItemName", true));
            this.menuItemNameComboBox.DataSource = this.menuItemsBindingSource;
            this.menuItemNameComboBox.DisplayMember = "menuItemName";
            this.menuItemNameComboBox.FormattingEnabled = true;
            this.menuItemNameComboBox.Location = new System.Drawing.Point(200, 34);
            this.menuItemNameComboBox.Name = "menuItemNameComboBox";
            this.menuItemNameComboBox.Size = new System.Drawing.Size(148, 21);
            this.menuItemNameComboBox.TabIndex = 5;
            this.menuItemNameComboBox.ValueMember = "menuItemId";
            // 
            // menuItemsBindingSource
            // 
            this.menuItemsBindingSource.DataMember = "MenuItems";
            this.menuItemsBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity: ";
            // 
            // quantityUpDownSelector
            // 

            this.numericUpDown1.Location = new System.Drawing.Point(73, 73);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;

            // 
            // btnAddToOrder
            // 

            this.btnAddToOrder.Location = new System.Drawing.Point(164, 114);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(144, 42);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);

            // 
            // menuItemsBindingSource2
            // 
            this.menuItemsBindingSource2.DataMember = "MenuItems";
            this.menuItemsBindingSource2.DataSource = this.restaurantDataSet;
            // 
            // orderPreviewListBox
            // 
            this.orderPreviewListBox.FormattingEnabled = true;
            this.orderPreviewListBox.Location = new System.Drawing.Point(590, 9);
            this.orderPreviewListBox.Name = "orderPreviewListBox";
            this.orderPreviewListBox.Size = new System.Drawing.Size(211, 316);
            this.orderPreviewListBox.TabIndex = 3;
            // 
            // BtnSendOrder
            // 
            this.BtnSendOrder.Location = new System.Drawing.Point(420, 218);
            this.BtnSendOrder.Name = "BtnSendOrder";
            this.BtnSendOrder.Size = new System.Drawing.Size(141, 33);
            this.BtnSendOrder.TabIndex = 5;
            this.BtnSendOrder.Text = "Send Order";
            this.BtnSendOrder.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(455, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 41);
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
            this.WaitstaffNameLabel.Location = new System.Drawing.Point(202, 9);
            this.WaitstaffNameLabel.Name = "WaitstaffNameLabel";
            this.WaitstaffNameLabel.Size = new System.Drawing.Size(35, 13);
            this.WaitstaffNameLabel.TabIndex = 7;
            this.WaitstaffNameLabel.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "User: ";
            // 
            // gbMyTables
            // 
            this.gbMyTables.Controls.Add(this.fillByMyTableToolStrip);
            this.gbMyTables.Controls.Add(this.fillBy1ToolStrip);
            this.gbMyTables.Controls.Add(tableNumberLabel);
            this.gbMyTables.Controls.Add(this.tableNumberComboBox);
            this.gbMyTables.Controls.Add(this.btnSelectMyTable);
            this.gbMyTables.Location = new System.Drawing.Point(15, 35);
            this.gbMyTables.Name = "gbMyTables";
            this.gbMyTables.Padding = new System.Windows.Forms.Padding(4);
            this.gbMyTables.Size = new System.Drawing.Size(569, 151);
            this.gbMyTables.TabIndex = 5;
            this.gbMyTables.TabStop = false;
            this.gbMyTables.Text = "My Tables";
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(32, 25);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(121, 25);
            this.fillBy1ToolStrip.TabIndex = 10;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.BackColor = System.Drawing.Color.CadetBlue;
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(109, 22);
            this.fillBy1ToolStripButton.Text = "View Empty Tables";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // tableNumberComboBox
            // 
            this.tableNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablesBindingSource, "tableNumber", true));
            this.tableNumberComboBox.DataSource = this.tablesBindingSource;
            this.tableNumberComboBox.DisplayMember = "tableNumber";
            this.tableNumberComboBox.FormattingEnabled = true;
            this.tableNumberComboBox.Location = new System.Drawing.Point(143, 77);
            this.tableNumberComboBox.Name = "tableNumberComboBox";
            this.tableNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.tableNumberComboBox.TabIndex = 5;
            this.tableNumberComboBox.ValueMember = "tableNumber";
            // 
            // btnSelectMyTable
            // 
            this.btnSelectMyTable.Location = new System.Drawing.Point(320, 72);
            this.btnSelectMyTable.Name = "btnSelectMyTable";
            this.btnSelectMyTable.Size = new System.Drawing.Size(144, 42);
            this.btnSelectMyTable.TabIndex = 4;
            this.btnSelectMyTable.Text = "Select";
            this.btnSelectMyTable.UseVisualStyleBackColor = true;
            this.btnSelectMyTable.Click += new System.EventHandler(this.btnSelectMyTable_Click);
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

            // fillByMyTableToolStrip
            // 
            this.fillByMyTableToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fillByMyTableToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByMyTableToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeEmployeeNumberToolStripLabel,
            this.activeEmployeeNumberToolStripTextBox,
            this.fillByMyTableToolStripButton});
            this.fillByMyTableToolStrip.Location = new System.Drawing.Point(169, 25);
            this.fillByMyTableToolStrip.Name = "fillByMyTableToolStrip";
            this.fillByMyTableToolStrip.Size = new System.Drawing.Size(325, 25);
            this.fillByMyTableToolStrip.TabIndex = 9;
            this.fillByMyTableToolStrip.Text = "fillByMyTableToolStrip";
            // 
            // activeEmployeeNumberToolStripLabel
            // 
            this.activeEmployeeNumberToolStripLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.activeEmployeeNumberToolStripLabel.Name = "activeEmployeeNumberToolStripLabel";
            this.activeEmployeeNumberToolStripLabel.Size = new System.Drawing.Size(139, 22);
            this.activeEmployeeNumberToolStripLabel.Text = "Enter Employee Number:";
            // 
            // activeEmployeeNumberToolStripTextBox
            // 
            this.activeEmployeeNumberToolStripTextBox.Name = "activeEmployeeNumberToolStripTextBox";
            this.activeEmployeeNumberToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByMyTableToolStripButton
            // 
            this.fillByMyTableToolStripButton.BackColor = System.Drawing.Color.CadetBlue;
            this.fillByMyTableToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByMyTableToolStripButton.Name = "fillByMyTableToolStripButton";
            this.fillByMyTableToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.fillByMyTableToolStripButton.Text = "View Tables";
            this.fillByMyTableToolStripButton.Click += new System.EventHandler(this.fillByMyTableToolStripButton_Click);
            // 

            // WaitstaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 346);
            this.Controls.Add(this.gbMyTables);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WaitstaffNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.BtnSendOrder);
            this.Controls.Add(this.orderPreviewListBox);
            this.Controls.Add(this.appetizersGroupBox);
            this.Name = "WaitstaffForm";
            this.Text = "POS Terminal";
            this.Load += new System.EventHandler(this.WaitstaffForm_Load);
            this.appetizersGroupBox.ResumeLayout(false);
            this.appetizersGroupBox.PerformLayout();
            this.fillByToolStrip2.ResumeLayout(false);
            this.fillByToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDownSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.gbMyTables.ResumeLayout(false);
            this.gbMyTables.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();

            this.fillByMyTableToolStrip.ResumeLayout(false);
            this.fillByMyTableToolStrip.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox appetizersGroupBox;
        private System.Windows.Forms.ListBox orderPreviewListBox;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button BtnSendOrder;
        private System.Windows.Forms.Button exitButton;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource menuItemsBindingSource;
        private RestaurantDataSetTableAdapters.MenuItemsTableAdapter menuItemsTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource menuItemsBindingSource1;
        private System.Windows.Forms.BindingSource menuItemsBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quantityUpDownSelector;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private RestaurantDataSetTableAdapters.TablesTableAdapter tablesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private RestaurantDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label WaitstaffNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMyTables;
        private System.Windows.Forms.Button btnSelectMyTable;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private RestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ComboBox tableNumberComboBox;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.ComboBox menuItemNameComboBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip2;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton2;
        private System.Windows.Forms.ToolStrip fillByMyTableToolStrip;
        private System.Windows.Forms.ToolStripLabel activeEmployeeNumberToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox activeEmployeeNumberToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByMyTableToolStripButton;
    }
}

