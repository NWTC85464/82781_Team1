namespace RestaurantPOS
{
    partial class ChefForm
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
			this.gbOrderOne = new System.Windows.Forms.GroupBox();
			this.btnCompleteOrderOne = new System.Windows.Forms.Button();
			this.btnLoadOrderOne = new System.Windows.Forms.Button();
			this.lstOrderOne = new System.Windows.Forms.ListBox();
			this.gbOrderTwo = new System.Windows.Forms.GroupBox();
			this.btnCompleteOrderTwo = new System.Windows.Forms.Button();
			this.btnLoadOrderTwo = new System.Windows.Forms.Button();
			this.lstOrderTwo = new System.Windows.Forms.ListBox();
			this.gbOrderThree = new System.Windows.Forms.GroupBox();
			this.btnCompleteOrderThree = new System.Windows.Forms.Button();
			this.btnLoadOrderThree = new System.Windows.Forms.Button();
			this.lstOrderThree = new System.Windows.Forms.ListBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.gbOrderOne.SuspendLayout();
			this.gbOrderTwo.SuspendLayout();
			this.gbOrderThree.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbOrderOne
			// 
			this.gbOrderOne.Controls.Add(this.btnCompleteOrderOne);
			this.gbOrderOne.Controls.Add(this.btnLoadOrderOne);
			this.gbOrderOne.Controls.Add(this.lstOrderOne);
			this.gbOrderOne.Location = new System.Drawing.Point(12, 12);
			this.gbOrderOne.Name = "gbOrderOne";
			this.gbOrderOne.Size = new System.Drawing.Size(319, 615);
			this.gbOrderOne.TabIndex = 0;
			this.gbOrderOne.TabStop = false;
			this.gbOrderOne.Text = "Order One";
			// 
			// btnCompleteOrderOne
			// 
			this.btnCompleteOrderOne.Location = new System.Drawing.Point(60, 568);
			this.btnCompleteOrderOne.Name = "btnCompleteOrderOne";
			this.btnCompleteOrderOne.Size = new System.Drawing.Size(199, 36);
			this.btnCompleteOrderOne.TabIndex = 2;
			this.btnCompleteOrderOne.Text = "Complete Current Order";
			this.btnCompleteOrderOne.UseVisualStyleBackColor = true;
			this.btnCompleteOrderOne.Click += new System.EventHandler(this.btnCompleteOrderOne_Click);
			// 
			// btnLoadOrderOne
			// 
			this.btnLoadOrderOne.Location = new System.Drawing.Point(60, 515);
			this.btnLoadOrderOne.Name = "btnLoadOrderOne";
			this.btnLoadOrderOne.Size = new System.Drawing.Size(199, 36);
			this.btnLoadOrderOne.TabIndex = 1;
			this.btnLoadOrderOne.Text = "Load Next Order";
			this.btnLoadOrderOne.UseVisualStyleBackColor = true;
			this.btnLoadOrderOne.Click += new System.EventHandler(this.btnLoadOrderOne_Click);
			// 
			// lstOrderOne
			// 
			this.lstOrderOne.FormattingEnabled = true;
			this.lstOrderOne.ItemHeight = 16;
			this.lstOrderOne.Location = new System.Drawing.Point(6, 21);
			this.lstOrderOne.Name = "lstOrderOne";
			this.lstOrderOne.Size = new System.Drawing.Size(307, 484);
			this.lstOrderOne.TabIndex = 0;
			// 
			// gbOrderTwo
			// 
			this.gbOrderTwo.Controls.Add(this.btnCompleteOrderTwo);
			this.gbOrderTwo.Controls.Add(this.btnLoadOrderTwo);
			this.gbOrderTwo.Controls.Add(this.lstOrderTwo);
			this.gbOrderTwo.Location = new System.Drawing.Point(337, 12);
			this.gbOrderTwo.Name = "gbOrderTwo";
			this.gbOrderTwo.Size = new System.Drawing.Size(319, 615);
			this.gbOrderTwo.TabIndex = 3;
			this.gbOrderTwo.TabStop = false;
			this.gbOrderTwo.Text = "Order Two";
			// 
			// btnCompleteOrderTwo
			// 
			this.btnCompleteOrderTwo.Location = new System.Drawing.Point(60, 568);
			this.btnCompleteOrderTwo.Name = "btnCompleteOrderTwo";
			this.btnCompleteOrderTwo.Size = new System.Drawing.Size(199, 36);
			this.btnCompleteOrderTwo.TabIndex = 2;
			this.btnCompleteOrderTwo.Text = "Complete Current Order";
			this.btnCompleteOrderTwo.UseVisualStyleBackColor = true;
			this.btnCompleteOrderTwo.Click += new System.EventHandler(this.btnCompleteOrderTwo_Click);
			// 
			// btnLoadOrderTwo
			// 
			this.btnLoadOrderTwo.Location = new System.Drawing.Point(60, 515);
			this.btnLoadOrderTwo.Name = "btnLoadOrderTwo";
			this.btnLoadOrderTwo.Size = new System.Drawing.Size(199, 36);
			this.btnLoadOrderTwo.TabIndex = 1;
			this.btnLoadOrderTwo.Text = "Load Next Order";
			this.btnLoadOrderTwo.UseVisualStyleBackColor = true;
			this.btnLoadOrderTwo.Click += new System.EventHandler(this.btnLoadOrderTwo_Click);
			// 
			// lstOrderTwo
			// 
			this.lstOrderTwo.FormattingEnabled = true;
			this.lstOrderTwo.ItemHeight = 16;
			this.lstOrderTwo.Location = new System.Drawing.Point(6, 21);
			this.lstOrderTwo.Name = "lstOrderTwo";
			this.lstOrderTwo.Size = new System.Drawing.Size(307, 484);
			this.lstOrderTwo.TabIndex = 0;
			// 
			// gbOrderThree
			// 
			this.gbOrderThree.Controls.Add(this.btnCompleteOrderThree);
			this.gbOrderThree.Controls.Add(this.btnLoadOrderThree);
			this.gbOrderThree.Controls.Add(this.lstOrderThree);
			this.gbOrderThree.Location = new System.Drawing.Point(662, 12);
			this.gbOrderThree.Name = "gbOrderThree";
			this.gbOrderThree.Size = new System.Drawing.Size(319, 615);
			this.gbOrderThree.TabIndex = 3;
			this.gbOrderThree.TabStop = false;
			this.gbOrderThree.Text = "Order One";
			// 
			// btnCompleteOrderThree
			// 
			this.btnCompleteOrderThree.Location = new System.Drawing.Point(60, 568);
			this.btnCompleteOrderThree.Name = "btnCompleteOrderThree";
			this.btnCompleteOrderThree.Size = new System.Drawing.Size(199, 36);
			this.btnCompleteOrderThree.TabIndex = 2;
			this.btnCompleteOrderThree.Text = "Complete Current Order";
			this.btnCompleteOrderThree.UseVisualStyleBackColor = true;
			this.btnCompleteOrderThree.Click += new System.EventHandler(this.btnCompleteOrderThree_Click);
			// 
			// btnLoadOrderThree
			// 
			this.btnLoadOrderThree.Location = new System.Drawing.Point(60, 515);
			this.btnLoadOrderThree.Name = "btnLoadOrderThree";
			this.btnLoadOrderThree.Size = new System.Drawing.Size(199, 36);
			this.btnLoadOrderThree.TabIndex = 1;
			this.btnLoadOrderThree.Text = "Load Next Order";
			this.btnLoadOrderThree.UseVisualStyleBackColor = true;
			this.btnLoadOrderThree.Click += new System.EventHandler(this.btnLoadOrderThree_Click);
			// 
			// lstOrderThree
			// 
			this.lstOrderThree.FormattingEnabled = true;
			this.lstOrderThree.ItemHeight = 16;
			this.lstOrderThree.Location = new System.Drawing.Point(6, 21);
			this.lstOrderThree.Name = "lstOrderThree";
			this.lstOrderThree.Size = new System.Drawing.Size(307, 484);
			this.lstOrderThree.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(782, 653);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(199, 36);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// ChefForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 712);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.gbOrderThree);
			this.Controls.Add(this.gbOrderTwo);
			this.Controls.Add(this.gbOrderOne);
			this.Name = "ChefForm";
			this.Text = "ChefForm";
			this.Load += new System.EventHandler(this.ChefForm_Load);
			this.gbOrderOne.ResumeLayout(false);
			this.gbOrderTwo.ResumeLayout(false);
			this.gbOrderThree.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderOne;
        private System.Windows.Forms.ListBox lstOrderOne;
        private System.Windows.Forms.Button btnCompleteOrderOne;
        private System.Windows.Forms.Button btnLoadOrderOne;
        private System.Windows.Forms.GroupBox gbOrderTwo;
        private System.Windows.Forms.Button btnCompleteOrderTwo;
        private System.Windows.Forms.Button btnLoadOrderTwo;
        private System.Windows.Forms.ListBox lstOrderTwo;
        private System.Windows.Forms.GroupBox gbOrderThree;
        private System.Windows.Forms.Button btnCompleteOrderThree;
        private System.Windows.Forms.Button btnLoadOrderThree;
        private System.Windows.Forms.ListBox lstOrderThree;
        private System.Windows.Forms.Button btnExit;
    }
}