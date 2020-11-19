namespace RelationalCustomerProduct
{
    partial class ProductCategoryForm
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
            this.category = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.category_code_label = new System.Windows.Forms.Label();
            this.category_code = new System.Windows.Forms.TextBox();
            this.ProductCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_description_label = new System.Windows.Forms.Label();
            this.category_description = new System.Windows.Forms.TextBox();
            this.products = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProductCategories = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCategoriesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCategories)).BeginInit();
            this.FileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(26, 55);
            this.category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(92, 25);
            this.category.TabIndex = 13;
            this.category.Text = "Category";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(311, 481);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(95, 30);
            this.delete.TabIndex = 20;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.DeleteProductCategory_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(209, 481);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 30);
            this.save.TabIndex = 19;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveProductCategory_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(106, 481);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 30);
            this.add.TabIndex = 18;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.AddProductCategory_Click);
            // 
            // category_code_label
            // 
            this.category_code_label.AutoSize = true;
            this.category_code_label.Location = new System.Drawing.Point(28, 130);
            this.category_code_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.category_code_label.Name = "category_code_label";
            this.category_code_label.Size = new System.Drawing.Size(45, 17);
            this.category_code_label.TabIndex = 14;
            this.category_code_label.Text = "Code:";
            // 
            // category_code
            // 
            this.category_code.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductCategoriesBindingSource, "code", true));
            this.category_code.Location = new System.Drawing.Point(122, 126);
            this.category_code.Margin = new System.Windows.Forms.Padding(4);
            this.category_code.Name = "category_code";
            this.category_code.Size = new System.Drawing.Size(265, 22);
            this.category_code.TabIndex = 15;
            this.category_code.TabStop = false;
            // 
            // ProductCategoriesBindingSource
            // 
            this.ProductCategoriesBindingSource.DataSource = typeof(RelationalCustomerProduct.Category);
            this.ProductCategoriesBindingSource.PositionChanged += new System.EventHandler(this.ProductCategoriesBindingSource_PositionChanged);
            // 
            // category_description_label
            // 
            this.category_description_label.AutoSize = true;
            this.category_description_label.Location = new System.Drawing.Point(28, 162);
            this.category_description_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.category_description_label.Name = "category_description_label";
            this.category_description_label.Size = new System.Drawing.Size(83, 17);
            this.category_description_label.TabIndex = 16;
            this.category_description_label.Text = "Description:";
            // 
            // category_description
            // 
            this.category_description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductCategoriesBindingSource, "description", true));
            this.category_description.Location = new System.Drawing.Point(122, 158);
            this.category_description.Margin = new System.Windows.Forms.Padding(4);
            this.category_description.Multiline = true;
            this.category_description.Name = "category_description";
            this.category_description.Size = new System.Drawing.Size(265, 104);
            this.category_description.TabIndex = 17;
            this.category_description.TabStop = false;
            // 
            // products
            // 
            this.products.AutoSize = true;
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Location = new System.Drawing.Point(4, 55);
            this.products.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(89, 25);
            this.products.TabIndex = 21;
            this.products.Text = "Products";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.category_code_label);
            this.panel1.Controls.Add(this.category_code);
            this.panel1.Controls.Add(this.category_description);
            this.panel1.Controls.Add(this.category_description_label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 546);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProductCategories);
            this.panel2.Controls.Add(this.products);
            this.panel2.Location = new System.Drawing.Point(577, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 546);
            this.panel2.TabIndex = 22;
            // 
            // dgvProductCategories
            // 
            this.dgvProductCategories.AllowUserToAddRows = false;
            this.dgvProductCategories.AllowUserToDeleteRows = false;
            this.dgvProductCategories.AutoGenerateColumns = false;
            this.dgvProductCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvProductCategories.DataSource = this.ProductCategoriesBindingSource;
            this.dgvProductCategories.Location = new System.Drawing.Point(9, 95);
            this.dgvProductCategories.Name = "dgvProductCategories";
            this.dgvProductCategories.RowTemplate.Height = 24;
            this.dgvProductCategories.Size = new System.Drawing.Size(565, 416);
            this.dgvProductCategories.TabIndex = 22;
            this.dgvProductCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductCategories_CellClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 130;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 390;
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.FileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(1173, 28);
            this.FileMenuStrip.TabIndex = 23;
            this.FileMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportCSVToolStripMenuItem,
            this.ExportCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // ImportCSVToolStripMenuItem
            // 
            this.ImportCSVToolStripMenuItem.Image = global::RelationalCustomerProduct.Properties.Resources.ImportFile_16x;
            this.ImportCSVToolStripMenuItem.Name = "ImportCSVToolStripMenuItem";
            this.ImportCSVToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.ImportCSVToolStripMenuItem.Text = "&Import CSV";
            this.ImportCSVToolStripMenuItem.Click += new System.EventHandler(this.ImportCSVToolStripMenuItem_Click);
            // 
            // ExportCSVToolStripMenuItem
            // 
            this.ExportCSVToolStripMenuItem.Image = global::RelationalCustomerProduct.Properties.Resources.ExportFile_16x;
            this.ExportCSVToolStripMenuItem.Name = "ExportCSVToolStripMenuItem";
            this.ExportCSVToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.ExportCSVToolStripMenuItem.Text = "&Export CSV";
            this.ExportCSVToolStripMenuItem.Click += new System.EventHandler(this.ExportCSVToolStripMenuItem_Click);
            // 
            // ProductCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1173, 569);
            this.Controls.Add(this.FileMenuStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductCategoriesForm";
            this.Text = "Product Categories Form";
            this.Load += new System.EventHandler(this.ProductCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductCategoriesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCategories)).EndInit();
            this.FileMenuStrip.ResumeLayout(false);
            this.FileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label category_code_label;
        internal System.Windows.Forms.TextBox category_code;
        private System.Windows.Forms.Label category_description_label;
        internal System.Windows.Forms.TextBox category_description;
        private System.Windows.Forms.Label products;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource ProductCategoriesBindingSource;
        private System.Windows.Forms.DataGridView dgvProductCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportCSVToolStripMenuItem;
    }
}