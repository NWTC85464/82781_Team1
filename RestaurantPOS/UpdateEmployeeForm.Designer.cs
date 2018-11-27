namespace RestaurantPOS
{
    partial class UpdateEmployeeForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbJobTitle = new System.Windows.Forms.GroupBox();
            this.rbWaitstaff = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbChef = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.gbJobTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 34);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(86, 115);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(114, 34);
            this.btnUpdateEmployee.TabIndex = 16;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(49, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // gbJobTitle
            // 
            this.gbJobTitle.Controls.Add(this.rbWaitstaff);
            this.gbJobTitle.Controls.Add(this.rbManager);
            this.gbJobTitle.Controls.Add(this.rbChef);
            this.gbJobTitle.Location = new System.Drawing.Point(302, 12);
            this.gbJobTitle.Name = "gbJobTitle";
            this.gbJobTitle.Size = new System.Drawing.Size(93, 88);
            this.gbJobTitle.TabIndex = 13;
            this.gbJobTitle.TabStop = false;
            this.gbJobTitle.Text = "Job Title:";
            // 
            // rbWaitstaff
            // 
            this.rbWaitstaff.AutoSize = true;
            this.rbWaitstaff.Location = new System.Drawing.Point(6, 42);
            this.rbWaitstaff.Name = "rbWaitstaff";
            this.rbWaitstaff.Size = new System.Drawing.Size(67, 17);
            this.rbWaitstaff.TabIndex = 2;
            this.rbWaitstaff.TabStop = true;
            this.rbWaitstaff.Text = "Waitstaff";
            this.rbWaitstaff.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(6, 65);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(67, 17);
            this.rbManager.TabIndex = 1;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbChef
            // 
            this.rbChef.AutoSize = true;
            this.rbChef.Location = new System.Drawing.Point(6, 19);
            this.rbChef.Name = "rbChef";
            this.rbChef.Size = new System.Drawing.Size(47, 17);
            this.rbChef.TabIndex = 0;
            this.rbChef.TabStop = true;
            this.rbChef.Text = "Chef";
            this.rbChef.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(111, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(176, 20);
            this.txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(111, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(44, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(45, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(111, 12);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeNumber.TabIndex = 18;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(9, 15);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(96, 13);
            this.lblEmployeeNumber.TabIndex = 19;
            this.lblEmployeeNumber.Text = "Employee Number:";
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 152);
            this.Controls.Add(this.lblEmployeeNumber);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.gbJobTitle);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "UpdateEmployeeForm";
            this.Text = "UpdateEmployeeForm";
            this.gbJobTitle.ResumeLayout(false);
            this.gbJobTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbJobTitle;
        private System.Windows.Forms.RadioButton rbWaitstaff;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbChef;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label lblEmployeeNumber;
    }
}