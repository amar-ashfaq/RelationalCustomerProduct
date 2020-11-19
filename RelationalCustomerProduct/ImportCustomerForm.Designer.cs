namespace RelationalCustomerProduct
{
    partial class ImportCustomerForm
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
            this.dgvCustomerImport = new System.Windows.Forms.DataGridView();
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CustomerImportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressline1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressline2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressline3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressline4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresspostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerImportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerImport
            // 
            this.dgvCustomerImport.AllowUserToAddRows = false;
            this.dgvCustomerImport.AllowUserToDeleteRows = false;
            this.dgvCustomerImport.AutoGenerateColumns = false;
            this.dgvCustomerImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressline1DataGridViewTextBoxColumn,
            this.addressline2DataGridViewTextBoxColumn,
            this.addressline3DataGridViewTextBoxColumn,
            this.addressline4DataGridViewTextBoxColumn,
            this.addresspostcodeDataGridViewTextBoxColumn});
            this.dgvCustomerImport.DataSource = this.CustomerImportBindingSource;
            this.dgvCustomerImport.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomerImport.Name = "dgvCustomerImport";
            this.dgvCustomerImport.RowTemplate.Height = 24;
            this.dgvCustomerImport.Size = new System.Drawing.Size(952, 491);
            this.dgvCustomerImport.TabIndex = 0;
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileBtn.Location = new System.Drawing.Point(12, 525);
            this.ChooseFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(131, 30);
            this.ChooseFileBtn.TabIndex = 18;
            this.ChooseFileBtn.Text = "Choose File...";
            this.ChooseFileBtn.UseVisualStyleBackColor = true;
            this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(869, 525);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(95, 30);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.Location = new System.Drawing.Point(151, 525);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(95, 30);
            this.AcceptBtn.TabIndex = 20;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CustomerImportBindingSource
            // 
            this.CustomerImportBindingSource.DataSource = typeof(RelationalCustomerProduct.Customer);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 170;
            // 
            // addressline1DataGridViewTextBoxColumn
            // 
            this.addressline1DataGridViewTextBoxColumn.DataPropertyName = "address_line_1";
            this.addressline1DataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressline1DataGridViewTextBoxColumn.Name = "addressline1DataGridViewTextBoxColumn";
            this.addressline1DataGridViewTextBoxColumn.Width = 200;
            // 
            // addressline2DataGridViewTextBoxColumn
            // 
            this.addressline2DataGridViewTextBoxColumn.DataPropertyName = "address_line_2";
            this.addressline2DataGridViewTextBoxColumn.HeaderText = "City";
            this.addressline2DataGridViewTextBoxColumn.Name = "addressline2DataGridViewTextBoxColumn";
            // 
            // addressline3DataGridViewTextBoxColumn
            // 
            this.addressline3DataGridViewTextBoxColumn.DataPropertyName = "address_line_3";
            this.addressline3DataGridViewTextBoxColumn.HeaderText = "County";
            this.addressline3DataGridViewTextBoxColumn.Name = "addressline3DataGridViewTextBoxColumn";
            // 
            // addressline4DataGridViewTextBoxColumn
            // 
            this.addressline4DataGridViewTextBoxColumn.DataPropertyName = "address_line_4";
            this.addressline4DataGridViewTextBoxColumn.HeaderText = "Country";
            this.addressline4DataGridViewTextBoxColumn.Name = "addressline4DataGridViewTextBoxColumn";
            // 
            // addresspostcodeDataGridViewTextBoxColumn
            // 
            this.addresspostcodeDataGridViewTextBoxColumn.DataPropertyName = "address_postcode";
            this.addresspostcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.addresspostcodeDataGridViewTextBoxColumn.Name = "addresspostcodeDataGridViewTextBoxColumn";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 571);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ChooseFileBtn);
            this.Controls.Add(this.dgvCustomerImport);
            this.Name = "ImportForm";
            this.Text = "Import Form";
            this.Load += new System.EventHandler(this.ImportCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerImportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerImport;
        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.BindingSource CustomerImportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressline1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressline2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressline3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressline4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresspostcodeDataGridViewTextBoxColumn;
    }
}