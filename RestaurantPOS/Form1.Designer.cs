namespace RestaurantPOS
{
    partial class Form1
    {
        // Gage test branch
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
            this.appetizersGroupBox = new System.Windows.Forms.GroupBox();
            this.dessertGroupBox = new System.Windows.Forms.GroupBox();
            this.entreeGroupBox = new System.Windows.Forms.GroupBox();
            this.beverageGroupBox = new System.Windows.Forms.GroupBox();
            this.orderPreviewListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appetizersGroupBox
            // 
            this.appetizersGroupBox.Location = new System.Drawing.Point(0, 0);
            this.appetizersGroupBox.Name = "appetizersGroupBox";
            this.appetizersGroupBox.Size = new System.Drawing.Size(288, 375);
            this.appetizersGroupBox.TabIndex = 0;
            this.appetizersGroupBox.TabStop = false;
            this.appetizersGroupBox.Text = "Appetizers";
            this.appetizersGroupBox.Enter += new System.EventHandler(this.appetizersGroupBox_Enter);
            // 
            // dessertGroupBox
            // 
            this.dessertGroupBox.Location = new System.Drawing.Point(588, 188);
            this.dessertGroupBox.Name = "dessertGroupBox";
            this.dessertGroupBox.Size = new System.Drawing.Size(271, 187);
            this.dessertGroupBox.TabIndex = 1;
            this.dessertGroupBox.TabStop = false;
            this.dessertGroupBox.Text = "Dessert";
            // 
            // entreeGroupBox
            // 
            this.entreeGroupBox.Location = new System.Drawing.Point(294, 0);
            this.entreeGroupBox.Name = "entreeGroupBox";
            this.entreeGroupBox.Size = new System.Drawing.Size(288, 375);
            this.entreeGroupBox.TabIndex = 1;
            this.entreeGroupBox.TabStop = false;
            this.entreeGroupBox.Text = "Entrees";
            // 
            // beverageGroupBox
            // 
            this.beverageGroupBox.Location = new System.Drawing.Point(588, 0);
            this.beverageGroupBox.Name = "beverageGroupBox";
            this.beverageGroupBox.Size = new System.Drawing.Size(271, 182);
            this.beverageGroupBox.TabIndex = 2;
            this.beverageGroupBox.TabStop = false;
            this.beverageGroupBox.Text = "Beverages";
            // 
            // orderPreviewListBox
            // 
            this.orderPreviewListBox.FormattingEnabled = true;
            this.orderPreviewListBox.Location = new System.Drawing.Point(866, 7);
            this.orderPreviewListBox.Name = "orderPreviewListBox";
            this.orderPreviewListBox.Size = new System.Drawing.Size(180, 368);
            this.orderPreviewListBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(341, 544);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 42);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 623);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderPreviewListBox);
            this.Controls.Add(this.beverageGroupBox);
            this.Controls.Add(this.entreeGroupBox);
            this.Controls.Add(this.dessertGroupBox);
            this.Controls.Add(this.appetizersGroupBox);
            this.Name = "Form1";
            this.Text = "POS Terminal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox appetizersGroupBox;
        private System.Windows.Forms.GroupBox dessertGroupBox;
        private System.Windows.Forms.GroupBox entreeGroupBox;
        private System.Windows.Forms.GroupBox beverageGroupBox;
        private System.Windows.Forms.ListBox orderPreviewListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitButton;
    }
}

