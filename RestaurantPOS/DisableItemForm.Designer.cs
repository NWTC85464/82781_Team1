namespace RestaurantPOS
{
    partial class DisableItemForm
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
            this.btnDisableItem = new System.Windows.Forms.Button();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDisableItem
            // 
            this.btnDisableItem.Location = new System.Drawing.Point(24, 39);
            this.btnDisableItem.Name = "btnDisableItem";
            this.btnDisableItem.Size = new System.Drawing.Size(86, 32);
            this.btnDisableItem.TabIndex = 6;
            this.btnDisableItem.Text = "Disable Item";
            this.btnDisableItem.UseVisualStyleBackColor = true;
            this.btnDisableItem.Click += new System.EventHandler(this.btnDisableItem_Click);
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(116, 6);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(100, 20);
            this.txtItemNumber.TabIndex = 5;
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(12, 9);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(98, 13);
            this.lblItemNumber.TabIndex = 4;
            this.lblItemNumber.Text = "Enter Item Number:";
            // 
            // DisableItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 80);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDisableItem);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblItemNumber);
            this.Name = "DisableItemForm";
            this.Text = "Disable Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDisableItem;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Label lblItemNumber;
    }
}