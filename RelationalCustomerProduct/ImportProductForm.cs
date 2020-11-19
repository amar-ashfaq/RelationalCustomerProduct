using System.Collections.Generic;
using System.Windows.Forms;
using FileHelpers;
using System;
using System.IO;

namespace RelationalCustomerProduct
{
    public partial class ImportProductForm : Form
    {
        private DataAccess dataAccess; //central data access storage
        FileHelperEngine<Product> engine = new FileHelperEngine<Product>();

        public ImportProductForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataAccess = new DataAccess();
        }

        private void ImportProductForm_Load(object sender, System.EventArgs e)
        {
            AcceptBtn.Enabled = false;
        }

        private void ChooseFileBtn_Click(object sender, System.EventArgs e)
        {
            ImportProductCSV();
        }

        private void ImportProductCSV()
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
                    ProductImportBindingSource.DataSource = PopulateProductGrid(directoryPath);                                     
                }
            }
        }

        public List<Product> PopulateProductGrid(string path)
        {
            try
            {
                engine.ErrorMode = ErrorMode.ThrowException;
                List<Product> products = new List<Product>();
                Product[] _products = engine.ReadFile(path);

                if (_products.Length == 0)
                {
                    throw new EmptyListException();
                }
                           
                foreach (Product product in _products)
                {
                    products.Add(product);
                }
                return products;
            }
            catch (Exception ex)
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
                else if(ex is IOException)
                {
                    AcceptBtn.Enabled = false;
                    MessageBox.Show("Please close down the CSV file first before importing...");
                }
                else
                {
                    AcceptBtn.Enabled = false;
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }

        private void AcceptBtn_Click(object sender, System.EventArgs e)
        {
            foreach (Product product in ProductImportBindingSource.DataSource as List<Product>)
            {
                if (!dataAccess.IsExistingProductCode(product.code))
                {
                    dataAccess.InsertProduct(product);
                }

                else
                {
                    try
                    {
                        dataAccess.UpdateProductsCSV(product);
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