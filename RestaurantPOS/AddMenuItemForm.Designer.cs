namespace RestaurantPOS
{
    partial class AddMenuItemForm
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.rbBeverage = new System.Windows.Forms.RadioButton();
            this.rbDesert = new System.Windows.Forms.RadioButton();
            this.rbEntree = new System.Windows.Forms.RadioButton();
            this.rbAppetizer = new System.Windows.Forms.RadioButton();
            this.gbCurrentlyActive = new System.Windows.Forms.GroupBox();
            this.rbDisabled = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDescription.SuspendLayout();
            this.gbCurrentlyActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(12, 21);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(61, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(79, 18);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(143, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(16, 47);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(57, 13);
            this.lblItemPrice.TabIndex = 2;
            this.lblItemPrice.Text = "Item Price:";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(79, 44);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(143, 20);
            this.txtItemPrice.TabIndex = 3;
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.rbBeverage);
            this.gbDescription.Controls.Add(this.rbDesert);
            this.gbDescription.Controls.Add(this.rbEntree);
            this.gbDescription.Controls.Add(this.rbAppetizer);
            this.gbDescription.Location = new System.Drawing.Point(228, 12);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(104, 111);
            this.gbDescription.TabIndex = 4;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Description";
            // 
            // rbBeverage
            // 
            this.rbBeverage.AutoSize = true;
            this.rbBeverage.Location = new System.Drawing.Point(7, 88);
            this.rbBeverage.Name = "rbBeverage";
            this.rbBeverage.Size = new System.Drawing.Size(71, 17);
            this.rbBeverage.TabIndex = 3;
            this.rbBeverage.TabStop = true;
            this.rbBeverage.Text = "Beverage";
            this.rbBeverage.UseVisualStyleBackColor = true;
            // 
            // rbDesert
            // 
            this.rbDesert.AutoSize = true;
            this.rbDesert.Location = new System.Drawing.Point(7, 65);
            this.rbDesert.Name = "rbDesert";
            this.rbDesert.Size = new System.Drawing.Size(61, 17);
            this.rbDesert.TabIndex = 2;
            this.rbDesert.TabStop = true;
            this.rbDesert.Text = "Dessert";
            this.rbDesert.UseVisualStyleBackColor = true;
            // 
            // rbEntree
            // 
            this.rbEntree.AutoSize = true;
            this.rbEntree.Location = new System.Drawing.Point(7, 42);
            this.rbEntree.Name = "rbEntree";
            this.rbEntree.Size = new System.Drawing.Size(56, 17);
            this.rbEntree.TabIndex = 1;
            this.rbEntree.TabStop = true;
            this.rbEntree.Text = "Entree";
            this.rbEntree.UseVisualStyleBackColor = true;
            // 
            // rbAppetizer
            // 
            this.rbAppetizer.AutoSize = true;
            this.rbAppetizer.Location = new System.Drawing.Point(7, 19);
            this.rbAppetizer.Name = "rbAppetizer";
            this.rbAppetizer.Size = new System.Drawing.Size(69, 17);
            this.rbAppetizer.TabIndex = 0;
            this.rbAppetizer.TabStop = true;
            this.rbAppetizer.Text = "Appetizer";
            this.rbAppetizer.UseVisualStyleBackColor = true;
            // 
            // gbCurrentlyActive
            // 
            this.gbCurrentlyActive.Controls.Add(this.rbDisabled);
            this.gbCurrentlyActive.Controls.Add(this.rbActive);
            this.gbCurrentlyActive.Location = new System.Drawing.Point(19, 70);
            this.gbCurrentlyActive.Name = "gbCurrentlyActive";
            this.gbCurrentlyActive.Size = new System.Drawing.Size(203, 52);
            this.gbCurrentlyActive.TabIndex = 4;
            this.gbCurrentlyActive.TabStop = false;
            this.gbCurrentlyActive.Text = "Is This Item Currently Active?";
            // 
            // rbDisabled
            // 
            this.rbDisabled.AutoSize = true;
            this.rbDisabled.Location = new System.Drawing.Point(89, 20);
            this.rbDisabled.Name = "rbDisabled";
            this.rbDisabled.Size = new System.Drawing.Size(66, 17);
            this.rbDisabled.TabIndex = 1;
            this.rbDisabled.TabStop = true;
            this.rbDisabled.Text = "Disabled";
            this.rbDisabled.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(17, 20);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(55, 17);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(60, 129);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(104, 39);
            this.btnAddMenuItem.TabIndex = 5;
            this.btnAddMenuItem.Text = "Add Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddMenuItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 171);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMenuItem);
            this.Controls.Add(this.gbCurrentlyActive);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Name = "AddMenuItemForm";
            this.Text = "Add a New Menu Item";
            this.gbDescription.ResumeLayout(false);
            this.gbDescription.PerformLayout();
            this.gbCurrentlyActive.ResumeLayout(false);
            this.gbCurrentlyActive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.RadioButton rbBeverage;
        private System.Windows.Forms.RadioButton rbDesert;
        private System.Windows.Forms.RadioButton rbEntree;
        private System.Windows.Forms.RadioButton rbAppetizer;
        private System.Windows.Forms.GroupBox gbCurrentlyActive;
        private System.Windows.Forms.RadioButton rbDisabled;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.Button btnCancel;
    }
}