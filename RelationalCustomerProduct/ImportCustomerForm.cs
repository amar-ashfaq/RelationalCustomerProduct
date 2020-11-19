using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FileHelpers;

namespace RelationalCustomerProduct
{
    public partial class ImportCustomerForm : Form
    {
        private DataAccess dataAccess; //central data access storage
        FileHelperEngine<Customer> engine = new FileHelperEngine<Customer>();

        public ImportCustomerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataAccess = new DataAccess();
        }

        private void ImportCustomerForm_Load(object sender, EventArgs e)
        {
            AcceptBtn.Enabled = false;
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            ImportCustomerCSV();       
        }

        private void ImportCustomerCSV()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                string filter = "CSV file (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm|All Files(*.*)|*.*";
                ofd.Filter = filter;

                if (ofd.ShowDialog() == DialogResult.OK) //if file is chosen, change 'Choose File' to 'Accept'
                {
                    string _filename = ofd.FileName;
                    string directoryPath = _filename;
                    AcceptBtn.Enabled = true;

                    if (PopulateCustomerGrid(directoryPath) != null)
                    {
                        CustomerImportBindingSource.DataSource = PopulateCustomerGrid(directoryPath);
                    }
                    else
                    {
                        MessageBox.Show("Nothing to import!");
                    }                 
                }
            }
        }

        public List<Customer> PopulateCustomerGrid(string path)
        {
            try
            {
                engine.ErrorMode = ErrorMode.ThrowException;
                Customer[] _customers = engine.ReadFile(path);
                List<Customer> customers = new List<Customer>();

                if (_customers.Length == 0)
                {
                    throw new EmptyListException();
                }

                foreach (Customer customer in _customers)
                {
                    customers.Add(customer);
                }
                return customers;
            }
            catch(Exception ex)
            {
                if (ex is BadUsageException || ex is ConvertException)
                {
                    AcceptBtn.Enabled = false;
                    MessageBox.Show("CSV file is not in the correct structure!");
                }
                else if (ex is EmptyListException)
                {
                    AcceptBtn.Enabled = false;
                    MessageBox.Show("Empty CSV file!");
                }
                else
                {
                    AcceptBtn.Enabled = false;
                    MessageBox.Show(ex.Message);
                }
            }
            return null;           
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            foreach (Customer customer in CustomerImportBindingSource.DataSource as List<Customer>)
            {
                if (!dataAccess.IsExistingCustomerAccount(customer.account))
                {
                    dataAccess.InsertCustomer(customer);
                }
                else
                {
                    try
                    {
                        dataAccess.UpdateCustomersCSV(customer);
                        //CustomerForm customerForm = new CustomerForm();
                        //customerForm.LoadCustomers(); //refresh table

                        //if (customerForm.dgvCustomerProduct.CurrentRow != null)
                        //{
                            //customerForm.dgvCustomerProduct.CurrentRow.Selected = true;
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                    }
                }
            }

            MessageBox.Show("Record(s) created/updated successfully!");
            DialogResult = DialogResult.OK;
        }
    }
}
