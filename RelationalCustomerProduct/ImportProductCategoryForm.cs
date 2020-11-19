using FileHelpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RelationalCustomerProduct
{
    public partial class ImportProductCategoryForm : Form
    {
        private DataAccess dataAccess;
        FileHelperEngine<Category> engine = new FileHelperEngine<Category>();

        public ImportProductCategoryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataAccess = new DataAccess();
        }

        private void ImportProductCategoryForm_Load(object sender, System.EventArgs e)
        {
            AcceptBtn.Enabled = false;
        }

        private void ChooseFileBtn_Click(object sender, System.EventArgs e)
        {
            ImportCategoryCSV();
        }

        private void ImportCategoryCSV()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                string filter = "CSV file (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm|All Files(*.*)|*.*";
                ofd.Filter = filter;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string _filename = ofd.FileName;
                    string directoryPath = _filename;

                    AcceptBtn.Enabled = true;

                    if (PopulateCategoryGrid(directoryPath) != null)
                    {
                        CategoryBindingSource.DataSource = PopulateCategoryGrid(directoryPath);
                    }
                    else
                    {
                        MessageBox.Show("Nothing to import!");
                    }                                   
                }
            }
        }

        public List<Category> PopulateCategoryGrid(string path)
        {
            try
            {
                engine.ErrorMode = ErrorMode.ThrowException;
                Category[] _categories = engine.ReadFile(path);
                List<Category> categories = new List<Category>();

                if (_categories.Length == 0)
                {
                    throw new EmptyListException();
                }

                foreach (Category category in _categories)
                {
                    categories.Add(category);
                }

                return categories;
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
            foreach (Category category in CategoryBindingSource.DataSource as List<Category>)
            {
                if (!dataAccess.IsExistingCategoryCode(category.code))
                {
                    dataAccess.InsertProductCategory(category);
                }
                else
                {
                    dataAccess.UpdateProductCategory(category, category.code);
                }               
            }

            MessageBox.Show("Record(s) created/updated successfully!");
            DialogResult = DialogResult.OK;
        }        
    }
}