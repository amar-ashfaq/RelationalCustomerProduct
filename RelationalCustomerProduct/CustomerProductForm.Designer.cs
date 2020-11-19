namespace RelationalCustomerProduct
{
    partial class CustomerProductForm
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
            this.maintainCustomers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maintainProductCategories = new System.Windows.Forms.Button();
            this.maintainProducts = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maintainCustomers
            // 
            this.maintainCustomers.BackColor = System.Drawing.Color.White;
            this.maintainCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainCustomers.Location = new System.Drawing.Point(52, 73);
            this.maintainCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.maintainCustomers.Name = "maintainCustomers";
            this.maintainCustomers.Size = new System.Drawing.Size(619, 110);
            this.maintainCustomers.TabIndex = 0;
            this.maintainCustomers.Text = "Maintain Customers";
            this.maintainCustomers.UseVisualStyleBackColor = false;
            this.maintainCustomers.Click += new System.EventHandler(this.MaintainCustomers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maintainProductCategories);
            this.panel1.Controls.Add(this.maintainProducts);
            this.panel1.Controls.Add(this.maintainCustomers);
            this.panel1.Location = new System.Drawing.Point(45, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 612);
            this.panel1.TabIndex = 3;
            // 
            // maintainProductCategories
            // 
            this.maintainProductCategories.BackColor = System.Drawing.Color.White;
            this.maintainProductCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainProductCategories.Location = new System.Drawing.Point(52, 430);
            this.maintainProductCategories.Margin = new System.Windows.Forms.Padding(4);
            this.maintainProductCategories.Name = "maintainProductCategories";
            this.maintainProductCategories.Size = new System.Drawing.Size(619, 110);
            this.maintainProductCategories.TabIndex = 7;
            this.maintainProductCategories.Text = "Maintain Product Categories";
            this.maintainProductCategories.UseVisualStyleBackColor = false;
            this.maintainProductCategories.Click += new System.EventHandler(this.MaintainProductCategories_Click);
            // 
            // maintainProducts
            // 
            this.maintainProducts.BackColor = System.Drawing.Color.White;
            this.maintainProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainProducts.Location = new System.Drawing.Point(52, 251);
            this.maintainProducts.Margin = new System.Windows.Forms.Padding(4);
            this.maintainProducts.Name = "maintainProducts";
            this.maintainProducts.Size = new System.Drawing.Size(619, 110);
            this.maintainProducts.TabIndex = 6;
            this.maintainProducts.Text = "Maintain Products";
            this.maintainProducts.UseVisualStyleBackColor = false;
            this.maintainProducts.Click += new System.EventHandler(this.MaintainProducts_Click);
            // 
            // products
            // 
            this.products.AutoSize = true;
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Location = new System.Drawing.Point(24, 12);
            this.products.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(89, 25);
            this.products.TabIndex = 4;
            this.products.Text = "Products";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.products);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 48);
            this.panel2.TabIndex = 5;
            // 
            // CustomerProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(807, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerProductForm";
            this.Text = "Relational Customer Product";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button maintainCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button maintainProductCategories;
        private System.Windows.Forms.Button maintainProducts;
        private System.Windows.Forms.Label products;
        private System.Windows.Forms.Panel panel2;
    }
}

