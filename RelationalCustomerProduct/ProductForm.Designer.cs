namespace RelationalCustomerProduct
{
    partial class ProductForm
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
            this.productid = new System.Windows.Forms.TextBox();
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._productid = new System.Windows.Forms.Label();
            this.code_ = new System.Windows.Forms.TextBox();
            this._code = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this._descriptionnnnn = new System.Windows.Forms.Label();
            this._colour = new System.Windows.Forms.Label();
            this.dimensions_panel = new System.Windows.Forms.Panel();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this._depth = new System.Windows.Forms.Label();
            this._width = new System.Windows.Forms.Label();
            this._height = new System.Windows.Forms.Label();
            this.dimensions = new System.Windows.Forms.Label();
            this.productInformation = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.ProductColorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this._image = new System.Windows.Forms.Label();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this._category = new System.Windows.Forms.Label();
            this.colour_pictureBox = new System.Windows.Forms.PictureBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            this.dimensions_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colour_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productid
            // 
            this.productid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "id", true));
            this.productid.Location = new System.Drawing.Point(113, 102);
            this.productid.Margin = new System.Windows.Forms.Padding(4);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(81, 22);
            this.productid.TabIndex = 2;
            this.productid.TabStop = false;
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataSource = typeof(RelationalCustomerProduct.Product);
            // 
            // _productid
            // 
            this._productid.AutoSize = true;
            this._productid.Location = new System.Drawing.Point(19, 106);
            this._productid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._productid.Name = "_productid";
            this._productid.Size = new System.Drawing.Size(25, 17);
            this._productid.TabIndex = 1;
            this._productid.Text = "ID:";
            // 
            // code_
            // 
            this.code_.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "code", true));
            this.code_.Location = new System.Drawing.Point(113, 134);
            this.code_.Margin = new System.Windows.Forms.Padding(4);
            this.code_.Name = "code_";
            this.code_.Size = new System.Drawing.Size(265, 22);
            this.code_.TabIndex = 4;
            this.code_.TabStop = false;
            // 
            // _code
            // 
            this._code.AutoSize = true;
            this._code.Location = new System.Drawing.Point(19, 138);
            this._code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._code.Name = "_code";
            this._code.Size = new System.Drawing.Size(45, 17);
            this._code.TabIndex = 3;
            this._code.Text = "Code:";
            // 
            // description
            // 
            this.description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "description", true));
            this.description.Location = new System.Drawing.Point(113, 166);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(265, 104);
            this.description.TabIndex = 6;
            this.description.TabStop = false;
            // 
            // _descriptionnnnn
            // 
            this._descriptionnnnn.AutoSize = true;
            this._descriptionnnnn.Location = new System.Drawing.Point(19, 170);
            this._descriptionnnnn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._descriptionnnnn.Name = "_descriptionnnnn";
            this._descriptionnnnn.Size = new System.Drawing.Size(83, 17);
            this._descriptionnnnn.TabIndex = 5;
            this._descriptionnnnn.Text = "Description:";
            // 
            // _colour
            // 
            this._colour.AutoSize = true;
            this._colour.Location = new System.Drawing.Point(19, 412);
            this._colour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._colour.Name = "_colour";
            this._colour.Size = new System.Drawing.Size(53, 17);
            this._colour.TabIndex = 9;
            this._colour.Text = "Colour:";
            // 
            // dimensions_panel
            // 
            this.dimensions_panel.Controls.Add(this.depth);
            this.dimensions_panel.Controls.Add(this.width);
            this.dimensions_panel.Controls.Add(this.height);
            this.dimensions_panel.Controls.Add(this._depth);
            this.dimensions_panel.Controls.Add(this._width);
            this.dimensions_panel.Controls.Add(this._height);
            this.dimensions_panel.Location = new System.Drawing.Point(113, 318);
            this.dimensions_panel.Margin = new System.Windows.Forms.Padding(4);
            this.dimensions_panel.Name = "dimensions_panel";
            this.dimensions_panel.Size = new System.Drawing.Size(283, 42);
            this.dimensions_panel.TabIndex = 8;
            // 
            // depth
            // 
            this.depth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ProductBindingSource, "depth", true));
            this.depth.Location = new System.Drawing.Point(221, 10);
            this.depth.Margin = new System.Windows.Forms.Padding(4);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(41, 22);
            this.depth.TabIndex = 5;
            // 
            // width
            // 
            this.width.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ProductBindingSource, "width", true));
            this.width.Location = new System.Drawing.Point(131, 10);
            this.width.Margin = new System.Windows.Forms.Padding(4);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(41, 22);
            this.width.TabIndex = 3;
            // 
            // height
            // 
            this.height.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ProductBindingSource, "height", true));
            this.height.Location = new System.Drawing.Point(37, 10);
            this.height.Margin = new System.Windows.Forms.Padding(4);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(41, 22);
            this.height.TabIndex = 1;
            // 
            // _depth
            // 
            this._depth.AutoSize = true;
            this._depth.Location = new System.Drawing.Point(192, 12);
            this._depth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._depth.Name = "_depth";
            this._depth.Size = new System.Drawing.Size(20, 17);
            this._depth.TabIndex = 4;
            this._depth.Text = "L:";
            // 
            // _width
            // 
            this._width.AutoSize = true;
            this._width.Location = new System.Drawing.Point(95, 12);
            this._width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._width.Name = "_width";
            this._width.Size = new System.Drawing.Size(25, 17);
            this._width.TabIndex = 2;
            this._width.Text = "W:";
            // 
            // _height
            // 
            this._height.AutoSize = true;
            this._height.Location = new System.Drawing.Point(5, 12);
            this._height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._height.Name = "_height";
            this._height.Size = new System.Drawing.Size(22, 17);
            this._height.TabIndex = 0;
            this._height.Text = "H:";
            // 
            // dimensions
            // 
            this.dimensions.AutoSize = true;
            this.dimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensions.Location = new System.Drawing.Point(108, 289);
            this.dimensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dimensions.Name = "dimensions";
            this.dimensions.Size = new System.Drawing.Size(114, 25);
            this.dimensions.TabIndex = 7;
            this.dimensions.Text = "Dimensions";
            // 
            // productInformation
            // 
            this.productInformation.AutoSize = true;
            this.productInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInformation.Location = new System.Drawing.Point(27, 39);
            this.productInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productInformation.Name = "productInformation";
            this.productInformation.Size = new System.Drawing.Size(180, 25);
            this.productInformation.TabIndex = 0;
            this.productInformation.Text = "Product Information";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(293, 476);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(95, 30);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(191, 476);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 30);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveProduct_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(88, 476);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 30);
            this.add.TabIndex = 10;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.image);
            this.panel1.Controls.Add(this._image);
            this.panel1.Controls.Add(this.category_comboBox);
            this.panel1.Controls.Add(this._category);
            this.panel1.Controls.Add(this.colour_pictureBox);
            this.panel1.Controls.Add(this.productInformation);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this._productid);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.productid);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this._code);
            this.panel1.Controls.Add(this.code_);
            this.panel1.Controls.Add(this.dimensions);
            this.panel1.Controls.Add(this._descriptionnnnn);
            this.panel1.Controls.Add(this.dimensions_panel);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this._colour);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 544);
            this.panel1.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(463, 367);
            this.browse.Margin = new System.Windows.Forms.Padding(4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(95, 30);
            this.browse.TabIndex = 16;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.BackColor = System.Drawing.Color.LightGray;
            this.image.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.ProductBindingSource, "image", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.image.Location = new System.Drawing.Point(463, 170);
            this.image.Margin = new System.Windows.Forms.Padding(4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(315, 190);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 26;
            this.image.TabStop = false;
            // 
            // _image
            // 
            this._image.AutoSize = true;
            this._image.Location = new System.Drawing.Point(391, 170);
            this._image.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._image.Name = "_image";
            this._image.Size = new System.Drawing.Size(50, 17);
            this._image.TabIndex = 15;
            this._image.Text = "Image:";
            // 
            // category_comboBox
            // 
            this.category_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "category", true));
            this.category_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Location = new System.Drawing.Point(463, 102);
            this.category_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(313, 24);
            this.category_comboBox.TabIndex = 14;
            // 
            // _category
            // 
            this._category.AutoSize = true;
            this._category.Location = new System.Drawing.Point(391, 106);
            this._category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._category.Name = "_category";
            this._category.Size = new System.Drawing.Size(69, 17);
            this._category.TabIndex = 13;
            this._category.Text = "Category:";
            // 
            // colour_pictureBox
            // 
            this.colour_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colour_pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.ProductBindingSource, "colour", true));
            this.colour_pictureBox.Location = new System.Drawing.Point(113, 404);
            this.colour_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.colour_pictureBox.Name = "colour_pictureBox";
            this.colour_pictureBox.Size = new System.Drawing.Size(26, 24);
            this.colour_pictureBox.TabIndex = 22;
            this.colour_pictureBox.TabStop = false;
            this.colour_pictureBox.DoubleClick += new System.EventHandler(this.ColourPictureBox_DoubleClick);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.ProductBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(800, 102);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(612, 404);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Product Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 130;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 180;
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.ReadOnly = true;
            this.colourDataGridViewTextBoxColumn.Width = 110;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // products
            // 
            this.products.AutoSize = true;
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Location = new System.Drawing.Point(795, 39);
            this.products.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(89, 25);
            this.products.TabIndex = 0;
            this.products.Text = "Products";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1420, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
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
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1420, 545);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.products);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            this.dimensions_panel.ResumeLayout(false);
            this.dimensions_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colour_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.Label _productid;
        internal System.Windows.Forms.TextBox code_;
        private System.Windows.Forms.Label _code;
        internal System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label _descriptionnnnn;
        private System.Windows.Forms.Label _colour;
        private System.Windows.Forms.Panel dimensions_panel;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label _depth;
        private System.Windows.Forms.Label _width;
        private System.Windows.Forms.Label _height;
        private System.Windows.Forms.Label dimensions;
        private System.Windows.Forms.Label productInformation;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ColorDialog ProductColorDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.PictureBox colour_pictureBox;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.Label _category;
        private System.Windows.Forms.Label products;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label _image;
        private System.Windows.Forms.BindingSource ProductBindingSource;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportCSVToolStripMenuItem;
    }
}