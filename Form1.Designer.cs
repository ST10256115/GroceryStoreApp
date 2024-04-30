namespace GroceryStoreApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtCategory = new TextBox();
            lstInventory = new ListBox();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(427, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(427, 137);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(427, 201);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 2;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(427, 263);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 3;
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.ItemHeight = 15;
            lstInventory.Location = new Point(568, 137);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(183, 94);
            lstInventory.TabIndex = 4;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(397, 315);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(568, 315);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(135, 23);
            btnRemoveItem.TabIndex = 6;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddItem);
            Controls.Add(lstInventory);
            Controls.Add(txtCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private ListBox lstInventory;
        private Button btnAddItem;
        private Button btnRemoveItem;
    }
}
