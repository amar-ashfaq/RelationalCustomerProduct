using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RelationalCustomerProduct
{
    public partial class CustomerProductSelectionForm : Form
    {
        DataAccess dataAccess = new DataAccess();
        public CustomerProductSelectionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //refactored
        private void CustomerProductSelectionForm_Load(object sender, EventArgs e)
        {
            LoadCustomerProducts();

            if (dgvSelectProducts.CurrentRow != null)
            {
                dgvSelectProducts.CurrentRow.Selected = true;
            }
        }

        //refactored
        private void LoadCustomerProducts()
        {
            try
            {
                SelectProductsBindingSource.DataSource = dataAccess.LoadCustomerProducts();
                SelectProductsBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
            }           
        }

        //refactored
        public void AcceptSelection_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
       
        //refactored
        public List<Product> GetSelectedProducts()
        {
            List<Product> products = SelectProductsBindingSource.DataSource as List<Product>;       
            return products.Where(p => p.isSelected).ToList();
        }
    }
}