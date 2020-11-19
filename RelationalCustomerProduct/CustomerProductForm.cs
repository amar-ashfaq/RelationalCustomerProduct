using System;
using System.Windows.Forms;

namespace RelationalCustomerProduct
{ 
    public partial class CustomerProductForm : Form
    {
        public CustomerProductForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MaintainCustomers_Click(object sender, EventArgs e)
        {            
            using (CustomerForm customerForm = new CustomerForm())
            {
                customerForm.ShowDialog();
            }
        }

        private void MaintainProducts_Click(object sender, EventArgs e)
        {
            using (ProductForm productForm = new ProductForm())
            {
                productForm.ShowDialog();
            }
        }

        private void MaintainProductCategories_Click(object sender, EventArgs e)
        {
            using (ProductCategoryForm productCategoriesForm = new ProductCategoryForm())
            {
                productCategoriesForm.ShowDialog();
            }
        }
    }
}