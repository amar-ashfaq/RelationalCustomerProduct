using Devart.Data.Universal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FileHelpers;
using System.Linq;

namespace RelationalCustomerProduct
{
    public partial class CustomerForm : Form
    {
        private DataAccess dataAccess;
        FileHelperEngine<Customer> engine = new FileHelperEngine<Customer>();
        ErrorProvider errorProvider = new ErrorProvider();

        public CustomerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dataAccess = new DataAccess();
        }

        //refactored
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customerid.Enabled = false;
            LoadCustomers();

            if (dgvCustomerProduct.CurrentRow != null)
            {
                dgvCustomerProduct.CurrentRow.Selected = true;
            }

            Customer customer = CustomerBindingSource.Current as Customer;
            
            if(customer != null)
            {
                customers_label.Text = customer.name + " - Products";
                LoadCustomerProducts(customer.id);

                if (dgvCustProducts.CurrentRow != null)
                {
                    dgvCustProducts.CurrentRow.Selected = true;
                }          
            }    
        }

        //refactored
        public void LoadCustomers()
        {
            try
            {
                CustomerBindingSource.DataSource = dataAccess.LoadCustomers();              
            }
            finally
            {
                CustomerBindingSource.ResetBindings(false);
            }          
        }

        //refactored
        public void LoadCustomerProducts(int id)
        {
            CustProductsBindingSource.DataSource = dataAccess.LoadCustomerProducts(id);
            CustProductsBindingSource.ResetBindings(false);
        }

        //refactored
        private void LinkToExistingProduct_Click(object sender, EventArgs e)
        {
            CustomerProductSelectionForm productSelectionForm = new CustomerProductSelectionForm();
            DialogResult dr = productSelectionForm.ShowDialog();
            LinkToExistingProduct(productSelectionForm, dr);
        }

        private void LinkToExistingProduct(CustomerProductSelectionForm productSelectionForm, DialogResult dr)
        {
            List<Product> productList = new List<Product>();
            Customer customer = CustomerBindingSource.Current as Customer;

            if (dr == DialogResult.OK)
            {
                using (UniConnection con = new UniConnection())
                {
                    productList = productSelectionForm.GetSelectedProducts();

                    foreach (Product product in productList)
                    {
                        try
                        {
                            dataAccess.CreateProductSelection(customer.id, product.id); //perform an insert statement 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                        }
                    }

                    LoadCustomerProducts(customer.id);
                    dgvCustomerProduct.CurrentRow.Selected = true;
                    MessageBox.Show("Selection made successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            add.Enabled = false;
            ClearErrorProvider();

            add.Enabled = false;
            delete.Enabled = false;
            CustomerBindingSource.AddNew();
            dgvCustomerProduct.DataSource = CustomerBindingSource;
            dgvCustomerProduct.CurrentRow.Selected = true;
            account_.Focus();
        }

        //refactored
        private void SaveRecord_Click(object sender, EventArgs e)
        {
            add.Enabled = true;
            Customer customer = (Customer)CustomerBindingSource.Current;

            if (customer.IsNewRecord())
            {
                if (!IsExistingCustomerAccount(customer.account, true))
                {
                    if (!ErrorCheck())
                    {                       
                        InsertCustomer(customer, true);
                    }
                    else
                    {
                        MessageBox.Show("There are validation errors in the form. Please correct them!");
                    }
                }
            }
            else
            {
                if (!ErrorCheck())
                {
                    UpdateCustomer(customer, true);
                }
                else
                {
                    MessageBox.Show("There are validation errors in the form. Please correct them!");
                }
            }                               
        }

        private bool ErrorCheck()
        {
            bool check = false;
            ClearErrorProvider();

            string customer_account = account_.Text;
            string customer_name = name.Text;
            string customer_address = address.Text;
            string customer_city = city.Text;
            string customer_state = state.Text;
            string customer_country = country.Text;
            string customer_postcode = postcode.Text;

            //account
            if (string.IsNullOrWhiteSpace(customer_account))
            {
                account_.Focus();
                errorProvider.SetError(account_, "Please enter a valid account name!");
                check = true;
            }

            else if (customer_account.Length > 10)
            {
                account_.Focus();
                errorProvider.SetError(account_, "Please enter a valid account name of up to 10 characters!");
                check = true;
            }

            //name
            if (string.IsNullOrWhiteSpace(customer_name))
            {
                name.Focus();
                errorProvider.SetError(name, "Please enter a valid customer name!");
                check = true;
            }
            else if (customer_name.Length > 50)
            {
                name.Focus();
                errorProvider.SetError(name, "Please enter a valid customer name of up to 50 characters!");
                check = true;
            }
            if (customer_name.Any(c => char.IsDigit(c)))
            {
                name.Focus();
                errorProvider.SetError(name, "Numbers are invalid characters!");
                check = true;
            }

            //address
            if (string.IsNullOrWhiteSpace(customer_address))
            {
                address.Focus();
                errorProvider.SetError(address, "Please enter a valid address!");
                check = true;
            }
            else if (customer_address.Length > 50)
            {
                address.Focus();
                errorProvider.SetError(address, "Please enter a valid address consisting of up to 50 characters!");
                check = true;
            }

            //city
            if (string.IsNullOrWhiteSpace(customer_city))
            {
                city.Focus();
                errorProvider.SetError(city, "Please enter a valid city name!");
                check = true;
            }
            else if (customer_city.Length > 50)
            {
                city.Focus();
                errorProvider.SetError(city, "Please enter a valid city consisting of up to 50 characters!");
                check = true;
            }
            if (customer_city.Any(c => char.IsDigit(c)))
            {
                city.Focus();
                errorProvider.SetError(city, "Numbers are invalid characters!");
                check = true;
            }

            //state
            if (string.IsNullOrWhiteSpace(customer_state))
            {
                state.Focus();
                errorProvider.SetError(state, "Please enter a valid state name!");
                check = true;
            }
            else if (customer_state.Length > 50)
            {
                state.Focus();
                errorProvider.SetError(state, "Please enter a valid state consisting of up to 50 characters!");
                check = true;
            }
            if (customer_state.Any(c => char.IsDigit(c)))
            {
                state.Focus();
                errorProvider.SetError(state, "Numbers are invalid characters!");
                check = true;
            }

            //country
            if (string.IsNullOrWhiteSpace(customer_country))
            {
                state.Focus();
                errorProvider.SetError(country, "Please enter a valid country name!");
                check = true;
            }
            else if (customer_country.Length > 50)
            {
                country.Focus();
                errorProvider.SetError(country, "Please enter a valid country consisting of up to 50 characters!");
                check = true;
            }
            if (customer_country.Any(c => char.IsDigit(c)))
            {
                country.Focus();
                errorProvider.SetError(country, "Numbers are invalid characters!");
                check = true;
            }

            //postcode
            if (string.IsNullOrWhiteSpace(customer_postcode))
            {
                postcode.Focus();
                errorProvider.SetError(postcode, "Please enter a valid postcode!");
                check = true;
            }
            else if (customer_postcode.Length > 10)
            {
                postcode.Focus();
                errorProvider.SetError(postcode, "Please enter a valid postcode consisting of up to 10 characters!");
                check = true;
            }

            return check;
        }

        private void ClearErrorProvider()
        {
            errorProvider.SetError(account_, "");
            errorProvider.SetError(name, "");
            errorProvider.SetError(address, "");
            errorProvider.SetError(city, "");
            errorProvider.SetError(state, "");
            errorProvider.SetError(country, "");
            errorProvider.SetError(postcode, "");
        }

        //refactored
        private void InsertCustomer(Customer customer, bool showMessage)
        {
            try
            {
                dataAccess.InsertCustomer(customer);

                if (showMessage)
                {
                    MessageBox.Show("Record created successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                              
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
            }
        }
                
        //refactored
        private void UpdateCustomer(Customer customer, bool showMessage)
        {
            if (MessageBox.Show("Update record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataAccess.UpdateCustomer(customer);
                    LoadCustomers();

                    if (dgvCustomerProduct.CurrentRow != null)
                    {
                        dgvCustomerProduct.CurrentRow.Selected = true;
                    }

                    if (showMessage)
                    {
                        MessageBox.Show("Record updated successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                                         
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                }                
            }
        }

        //refactored
        private bool IsExistingCustomerAccount(string account, bool showMessage)
        {
            if (dataAccess.IsExistingCustomerAccount(account))
            {
                ClearErrorProvider();

                if (showMessage)
                {
                    ErrorCheck();
                    errorProvider.SetError(account_, "Customer account already exists!");
                    MessageBox.Show("Customer account already exists! Please choose another...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }             
            }
            else
            {
                errorProvider.SetError(account_, "");
            }            
            return dataAccess.IsExistingCustomerAccount(account);      
        }

        //refactored
        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerBindingSource.Current as Customer; //current selected customer

            if (MessageBox.Show("Are you sure you want to remove this selection?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<Product> products = CustProductsBindingSource.DataSource as List<Product>;

                try
                {
                    dataAccess.DeleteProductSelection(customer, products);
                    LoadCustomerProducts(customer.id); //refresh table
                    MessageBox.Show("Record deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dgvCustProducts.CurrentRow != null)
                    {
                        dgvCustProducts.CurrentRow.Selected = true;
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                }
            }            
        } 

        //refactored
        private void dgvCustomerProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearErrorProvider();

            add.Enabled = true;
            delete.Enabled = true;
            LoadCustomers();
            dgvCustomerProduct.CurrentRow.Selected = true;

            Customer customer = CustomerBindingSource.Current as Customer;

            LoadCustomerProducts(customer.id);
            customers_label.Text = customer.name + " - Products";          
        }  

        //refactored
        private void Delete_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerBindingSource.Current as Customer;

            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataAccess.DeleteCustomer(customer);
                    add.Enabled = true;
                    LoadCustomers(); //refresh table
                    MessageBox.Show("Record deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dgvCustomerProduct.CurrentRow != null)
                    {
                        dgvCustomerProduct.CurrentRow.Selected = true;
                    }                                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                }               
            }
        }

        //refactored
        private void dgvCustProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustProducts.CurrentRow != null)
            {
                dgvCustProducts.CurrentRow.Selected = true;
            }                            
        }

        private void ExportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportCustomers();
        }

        private void ExportCustomers()
        {
            List<Customer> customers = CustomerBindingSource.DataSource as List<Customer>;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                string filter = "CSV file (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm|All Files(*.*)|*.*";
                sfd.Filter = filter;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filter = sfd.FileName;
                    engine.WriteFile(filter, customers);
                    MessageBox.Show("Customer CSV Succesfully Exported...");
                }
            }          
        }

        private void ImportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportCustomerForm importForm = new ImportCustomerForm();
            DialogResult dr = importForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                LoadCustomers();
            }                        
        }
    }
}