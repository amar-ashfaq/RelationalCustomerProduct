namespace RelationalCustomerProduct
{
    partial class CustomerForm
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
            this.customerInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCustomerProduct = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this._country = new System.Windows.Forms.Label();
            this._state = new System.Windows.Forms.Label();
            this._city = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.postcode = new System.Windows.Forms.TextBox();
            this._postcode = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.account_ = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.TextBox();
            this._address = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.Label();
            this._account = new System.Windows.Forms.Label();
            this.customerInformation = new System.Windows.Forms.Label();
            this._customerid = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.products = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customers_label = new System.Windows.Forms.Label();
            this.removeSelected = new System.Windows.Forms.Button();
            this.linkToExistingProduct = new System.Windows.Forms.Button();
            this.dgvCustProducts = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CustProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.customerInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.products.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustProductsBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInfo
            // 
            this.customerInfo.Controls.Add(this.panel2);
            this.customerInfo.Controls.Add(this.panel1);
            this.customerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfo.Location = new System.Drawing.Point(4, 4);
            this.customerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Padding = new System.Windows.Forms.Padding(4);
            this.customerInfo.Size = new System.Drawing.Size(916, 682);
            this.customerInfo.TabIndex = 0;
            this.customerInfo.Text = "Customer Information";
            this.customerInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCustomerProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(447, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 674);
            this.panel2.TabIndex = 1;
            // 
            // dgvCustomerProduct
            // 
            this.dgvCustomerProduct.AllowUserToAddRows = false;
            this.dgvCustomerProduct.AllowUserToDeleteRows = false;
            this.dgvCustomerProduct.AllowUserToOrderColumns = true;
            this.dgvCustomerProduct.AutoGenerateColumns = false;
            this.dgvCustomerProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvCustomerProduct.DataSource = this.CustomerBindingSource;
            this.dgvCustomerProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomerProduct.Name = "dgvCustomerProduct";
            this.dgvCustomerProduct.ReadOnly = true;
            this.dgvCustomerProduct.Size = new System.Drawing.Size(465, 674);
            this.dgvCustomerProduct.TabIndex = 0;
            this.dgvCustomerProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerProduct_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "account";
            this.dataGridViewTextBoxColumn1.HeaderText = "Account";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataSource = typeof(RelationalCustomerProduct.Customer);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._country);
            this.panel1.Controls.Add(this._state);
            this.panel1.Controls.Add(this._city);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.postcode);
            this.panel1.Controls.Add(this._postcode);
            this.panel1.Controls.Add(this.country);
            this.panel1.Controls.Add(this.state);
            this.panel1.Controls.Add(this.city);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.account_);
            this.panel1.Controls.Add(this.customerid);
            this.panel1.Controls.Add(this._address);
            this.panel1.Controls.Add(this._name);
            this.panel1.Controls.Add(this._account);
            this.panel1.Controls.Add(this.customerInformation);
            this.panel1.Controls.Add(this._customerid);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 674);
            this.panel1.TabIndex = 0;
            // 
            // _country
            // 
            this._country.AutoSize = true;
            this._country.Location = new System.Drawing.Point(19, 321);
            this._country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._country.Name = "_country";
            this._country.Size = new System.Drawing.Size(72, 20);
            this._country.TabIndex = 12;
            this._country.Text = "Country:";
            // 
            // _state
            // 
            this._state.AutoSize = true;
            this._state.Location = new System.Drawing.Point(19, 280);
            this._state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._state.Name = "_state";
            this._state.Size = new System.Drawing.Size(53, 20);
            this._state.TabIndex = 10;
            this._state.Text = "State:";
            // 
            // _city
            // 
            this._city.AutoSize = true;
            this._city.Location = new System.Drawing.Point(19, 240);
            this._city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._city.Name = "_city";
            this._city.Size = new System.Drawing.Size(43, 20);
            this._city.TabIndex = 8;
            this._city.Text = "City:";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(319, 404);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(95, 30);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(216, 404);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 30);
            this.save.TabIndex = 17;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveRecord_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(113, 404);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 30);
            this.add.TabIndex = 16;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // postcode
            // 
            this.postcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "address_postcode", true));
            this.postcode.Location = new System.Drawing.Point(113, 358);
            this.postcode.Margin = new System.Windows.Forms.Padding(4);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(147, 26);
            this.postcode.TabIndex = 15;
            // 
            // _postcode
            // 
            this._postcode.AutoSize = true;
            this._postcode.Location = new System.Drawing.Point(19, 361);
            this._postcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._postcode.Name = "_postcode";
            this._postcode.Size = new System.Drawing.Size(84, 20);
            this._postcode.TabIndex = 14;
            this._postcode.Text = "Postcode:";
            // 
            // country
            // 
            this.country.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "address_line_4", true));
            this.country.Location = new System.Drawing.Point(113, 317);
            this.country.Margin = new System.Windows.Forms.Padding(4);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(299, 26);
            this.country.TabIndex = 13;
            // 
            // state
            // 
            this.state.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "address_line_3", true));
            this.state.Location = new System.Drawing.Point(113, 277);
            this.state.Margin = new System.Windows.Forms.Padding(4);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(299, 26);
            this.state.TabIndex = 11;
            // 
            // city
            // 
            this.city.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "address_line_2", true));
            this.city.Location = new System.Drawing.Point(113, 236);
            this.city.Margin = new System.Windows.Forms.Padding(4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(299, 26);
            this.city.TabIndex = 9;
            // 
            // address
            // 
            this.address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "address_line_1", true));
            this.address.Location = new System.Drawing.Point(113, 195);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(299, 26);
            this.address.TabIndex = 7;
            // 
            // name
            // 
            this.name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "name", true));
            this.name.Location = new System.Drawing.Point(113, 155);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(299, 26);
            this.name.TabIndex = 5;
            // 
            // account_
            // 
            this.account_.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "account", true));
            this.account_.Location = new System.Drawing.Point(113, 114);
            this.account_.Margin = new System.Windows.Forms.Padding(4);
            this.account_.Name = "account_";
            this.account_.Size = new System.Drawing.Size(147, 26);
            this.account_.TabIndex = 3;
            // 
            // customerid
            // 
            this.customerid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "id", true));
            this.customerid.Location = new System.Drawing.Point(113, 73);
            this.customerid.Margin = new System.Windows.Forms.Padding(4);
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(81, 26);
            this.customerid.TabIndex = 1;
            this.customerid.TabStop = false;
            // 
            // _address
            // 
            this._address.AutoSize = true;
            this._address.Location = new System.Drawing.Point(19, 199);
            this._address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(76, 20);
            this._address.TabIndex = 6;
            this._address.Text = "Address:";
            // 
            // _name
            // 
            this._name.AutoSize = true;
            this._name.Location = new System.Drawing.Point(19, 158);
            this._name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(58, 20);
            this._name.TabIndex = 4;
            this._name.Text = "Name:";
            // 
            // _account
            // 
            this._account.AutoSize = true;
            this._account.Location = new System.Drawing.Point(19, 118);
            this._account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._account.Name = "_account";
            this._account.Size = new System.Drawing.Size(75, 20);
            this._account.TabIndex = 2;
            this._account.Text = "Account:";
            // 
            // customerInformation
            // 
            this.customerInformation.AutoSize = true;
            this.customerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformation.Location = new System.Drawing.Point(17, 34);
            this.customerInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerInformation.Name = "customerInformation";
            this.customerInformation.Size = new System.Drawing.Size(198, 25);
            this.customerInformation.TabIndex = 3;
            this.customerInformation.Text = "Customer Information";
            // 
            // _customerid
            // 
            this._customerid.AutoSize = true;
            this._customerid.Location = new System.Drawing.Point(19, 77);
            this._customerid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._customerid.Name = "_customerid";
            this._customerid.Size = new System.Drawing.Size(31, 20);
            this._customerid.TabIndex = 0;
            this._customerid.Text = "ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCSVToolStripMenuItem,
            this.exportCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Image = global::RelationalCustomerProduct.Properties.Resources.ImportFile_16x;
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.importCSVToolStripMenuItem.Text = "&Import CSV";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.ImportCSVToolStripMenuItem_Click);
            // 
            // exportCSVToolStripMenuItem
            // 
            this.exportCSVToolStripMenuItem.Image = global::RelationalCustomerProduct.Properties.Resources.ExportFile_16x;
            this.exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            this.exportCSVToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.exportCSVToolStripMenuItem.Text = "&Export CSV";
            this.exportCSVToolStripMenuItem.Click += new System.EventHandler(this.ExportCSVToolStripMenuItem_Click);
            // 
            // products
            // 
            this.products.Controls.Add(this.panel3);
            this.products.Controls.Add(this.removeSelected);
            this.products.Controls.Add(this.linkToExistingProduct);
            this.products.Controls.Add(this.dgvCustProducts);
            this.products.Controls.Add(this.menuStrip2);
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.products.Location = new System.Drawing.Point(4, 4);
            this.products.Margin = new System.Windows.Forms.Padding(4);
            this.products.Name = "products";
            this.products.Padding = new System.Windows.Forms.Padding(4);
            this.products.Size = new System.Drawing.Size(916, 682);
            this.products.TabIndex = 1;
            this.products.Text = "Products";
            this.products.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customers_label);
            this.panel3.Location = new System.Drawing.Point(1, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 45);
            this.panel3.TabIndex = 6;
            // 
            // customers_label
            // 
            this.customers_label.AutoSize = true;
            this.customers_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_label.Location = new System.Drawing.Point(15, 12);
            this.customers_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customers_label.Name = "customers_label";
            this.customers_label.Size = new System.Drawing.Size(107, 25);
            this.customers_label.TabIndex = 4;
            this.customers_label.Text = "Customers";
            // 
            // removeSelected
            // 
            this.removeSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelected.Location = new System.Drawing.Point(716, 593);
            this.removeSelected.Margin = new System.Windows.Forms.Padding(4);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(176, 30);
            this.removeSelected.TabIndex = 3;
            this.removeSelected.Text = "Remove Selected";
            this.removeSelected.UseVisualStyleBackColor = true;
            this.removeSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // linkToExistingProduct
            // 
            this.linkToExistingProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToExistingProduct.Location = new System.Drawing.Point(21, 593);
            this.linkToExistingProduct.Margin = new System.Windows.Forms.Padding(4);
            this.linkToExistingProduct.Name = "linkToExistingProduct";
            this.linkToExistingProduct.Size = new System.Drawing.Size(208, 30);
            this.linkToExistingProduct.TabIndex = 2;
            this.linkToExistingProduct.Text = "Link to existing product";
            this.linkToExistingProduct.UseVisualStyleBackColor = true;
            this.linkToExistingProduct.Click += new System.EventHandler(this.LinkToExistingProduct_Click);
            // 
            // dgvCustProducts
            // 
            this.dgvCustProducts.AllowUserToAddRows = false;
            this.dgvCustProducts.AutoGenerateColumns = false;
            this.dgvCustProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.select});
            this.dgvCustProducts.DataSource = this.CustProductsBindingSource;
            this.dgvCustProducts.Location = new System.Drawing.Point(21, 75);
            this.dgvCustProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustProducts.Name = "dgvCustProducts";
            this.dgvCustProducts.Size = new System.Drawing.Size(871, 495);
            this.dgvCustProducts.TabIndex = 0;
            this.dgvCustProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustProducts_CellClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Product Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 400;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 170;
            // 
            // select
            // 
            this.select.DataPropertyName = "isSelected";
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.Width = 110;
            // 
            // CustProductsBindingSource
            // 
            this.CustProductsBindingSource.DataSource = typeof(RelationalCustomerProduct.Product);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(4, 4);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(908, 28);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.customerInfo);
            this.tabControl1.Controls.Add(this.products);
            this.tabControl1.Location = new System.Drawing.Point(7, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 711);
            this.tabControl1.TabIndex = 1;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(959, 751);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.customerInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.products.ResumeLayout(false);
            this.products.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustProductsBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage customerInfo;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label _address;
        private System.Windows.Forms.Label _name;
        private System.Windows.Forms.Label _account;
        private System.Windows.Forms.Label customerInformation;
        private System.Windows.Forms.Label _customerid;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.Label _postcode;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.Button linkToExistingProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label customers_label;
        private System.Windows.Forms.Label _city;
        private System.Windows.Forms.Label _country;
        private System.Windows.Forms.Label _state;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        internal System.Windows.Forms.TextBox customerid;
        internal System.Windows.Forms.DataGridView dgvCustomerProduct;
        private System.Windows.Forms.BindingSource CustProductsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.TabControl tabControl1;
        protected internal System.Windows.Forms.DataGridView dgvCustProducts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCSVToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        protected System.Windows.Forms.TextBox account_;
    }
}