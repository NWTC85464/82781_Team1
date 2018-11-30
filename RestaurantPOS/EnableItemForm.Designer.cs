namespace RestaurantPOS
{
    partial class EnableItemForm
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
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.btnEnableItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(12, 18);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(98, 13);
            this.lblItemNumber.TabIndex = 0;
            this.lblItemNumber.Text = "Enter Item Number:";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(116, 15);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(100, 20);
            this.txtItemNumber.TabIndex = 1;
            // 
            // btnEnableItem
            // 
            this.btnEnableItem.Location = new System.Drawing.Point(24, 48);
            this.btnEnableItem.Name = "btnEnableItem";
            this.btnEnableItem.Size = new System.Drawing.Size(86, 32);
            this.btnEnableItem.TabIndex = 2;
            this.btnEnableItem.Text = "Enable Item";
            this.btnEnableItem.UseVisualStyleBackColor = true;
            this.btnEnableItem.Click += new System.EventHandler(this.btnEnableItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 48);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EnableItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 90);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnableItem);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblItemNumber);
            this.Name = "EnableItemForm";
            this.Text = "Enable Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Button btnEnableItem;
        private System.Windows.Forms.Button btnCancel;
    }
}