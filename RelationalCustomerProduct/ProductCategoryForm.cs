using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RelationalCustomerProduct
{
    public partial class ProductCategoryForm : Form
    {
        DataAccess dataAccess;
        FileHelperEngine<Category> engine = new FileHelperEngine<Category>();
        ErrorProvider errorProvider = new ErrorProvider();
        string old_code = " ";

        public ProductCategoryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataAccess = new DataAccess();
        }

        private void ProductCategoryForm_Load(object sender, EventArgs e)
        {
            LoadProductCategories();

            if (dgvProductCategories.Rows.Count > 0)
            {
                dgvProductCategories.CurrentRow.Selected = true;
            }
            else
            {
                DisableFields();
            }            
        }

        private void EnableFields()
        {
            category_code.Enabled = true;
            category_description.Enabled = true;
            save.Enabled = true;
            delete.Enabled = true;
        }

        private void DisableFields()
        {
            category_code.Enabled = false;
            category_description.Enabled = false;          
            save.Enabled = false;
            delete.Enabled = false;
        }

        //refactored
        private void LoadProductCategories()
        {
            try
            {
                ProductCategoriesBindingSource.DataSource = dataAccess.LoadProductCategories();
            }
            finally
            {
                ProductCategoriesBindingSource.ResetBindings(false);
            }          
        }   
       
        private void AddProductCategory_Click(object sender, EventArgs e)
        {
            if (dgvProductCategories.Rows.Count == 1)
            {
                EnableFields();
            }

            add.Enabled = false;
            delete.Enabled = false;
            ProductCategoriesBindingSource.AddNew();
            dgvProductCategories.DataSource = ProductCategoriesBindingSource;
            dgvProductCategories.CurrentRow.Selected = true; //once added, it's selected
            category_code.Focus();
        }

        //refactored
        private void InsertProductCategory(Category category, bool showMessage)
        {
            try
            {
                dataAccess.InsertProductCategory(category);
                LoadProductCategories(); //refresh table
                delete.Enabled = true;

                string created = "created";
                ShowMessage(showMessage, created);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
            }          
        }

        private void ShowMessage(bool showMessage, string action)
        {
            if (showMessage == true) MessageBox.Show("Record "+ action + " successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        //refactored
        private void UpdateProductCategory(Category category, bool showMessage)
        {
            if (MessageBox.Show("Update record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataAccess.UpdateProductCategory(category, old_code);
                    LoadProductCategories();
                    dgvProductCategories.CurrentRow.Selected = true;

                    string created = "updated";
                    ShowMessage(showMessage, created);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                }               
            }
        }

        //refactored
        private void SaveProductCategory_Click(object sender, EventArgs e)
        {
            add.Enabled = true;
            Category category = (Category)ProductCategoriesBindingSource.Current;

            if (category.IsNewRecord)
            {
                if (!IsExistingCategoryCode(category.code, true))
                {
                    if (!ErrorCheck())
                    {
                        InsertProductCategory(category, true);
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
                    UpdateProductCategory(category, true);
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

            string categorycode = category_code.Text;
            string categorydescription = category_description.Text;

            //code
            if (string.IsNullOrWhiteSpace(categorycode))
            {
                category_code.Focus();
                errorProvider.SetError(category_code, "Please enter a valid category code!");
                check = true;
            }

            else if (categorycode.Length > 10)
            {
                category_code.Focus();
                errorProvider.SetError(category_code, "Please enter a valid category code of up to 10 characters!");
                check = true;
            }

            if (categorycode.Any(c => char.IsDigit(c)))
            {
                category_code.Focus();
                errorProvider.SetError(category_code, "Numbers are invalid characters!");
                check = true;
            }

            //description
            if (string.IsNullOrWhiteSpace(categorydescription))
            {
                category_description.Focus();
                errorProvider.SetError(category_description, "Please enter a category description!");
                check = true;
            }
            else if (categorydescription.Length > 50)
            {
                category_description.Focus();
                errorProvider.SetError(category_description, "Please enter a valid category description of up to 50 characters!");
                check = true;
            }

            return check;
        }

        private void ClearErrorProvider()
        {
            errorProvider.SetError(category_code, "");
            errorProvider.SetError(category_description, "");
        }

        //refactored
        private bool IsExistingCategoryCode(string code, bool showMessage)
        {
            if (dataAccess.IsExistingCategoryCode(code))
            {
                ClearErrorProvider();

                if (showMessage)
                {
                    ErrorCheck();
                    errorProvider.SetError(category_code, "Category code already exists");
                    MessageBox.Show("Category code already exists! Choose another one...");
                }
                else
                {
                    errorProvider.SetError(category_code, "");
                }
            }
            return dataAccess.IsExistingCategoryCode(code);
        }

        //refactored
        private void DeleteProductCategory_Click(object sender, EventArgs e)
        {          
            if (MessageBox.Show("Delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                add.Enabled = true;
                Category code = ProductCategoriesBindingSource.Current as Category;

                try
                {
                    dataAccess.DeleteProductCategory(code);
                    LoadProductCategories(); //refresh table
                    dgvProductCategories.CurrentRow.Selected = true;

                    MessageBox.Show("Record deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                }                
            }
        }

        private void dgvProductCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearErrorProvider();
            add.Enabled = true;
            delete.Enabled = true;
            LoadProductCategories();
            dgvProductCategories.CurrentRow.Selected = true;
        }

        private void ProductCategoriesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Category c = ProductCategoriesBindingSource.Current as Category;
            string old_description = " ";

            (ProductCategoriesBindingSource.Current as Category).code = c.code;
            old_code = c.code;
            old_description = c.description;
        }

        private void ExportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportProductCategories();
        }

        private void ExportProductCategories()
        {
            List<Category> categories = ProductCategoriesBindingSource.DataSource as List<Category>;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                string filter = "CSV file (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm|All Files(*.*)|*.*";
                sfd.Filter = filter;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filter = sfd.FileName;
                    engine.WriteFile(filter, categories);
                    MessageBox.Show("Product Categories CSV Succesfully Exported...");
                }                                                
            }
        }

        private void ImportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportProductCategoryForm importProductCategoryForm = new ImportProductCategoryForm();
            DialogResult dr = importProductCategoryForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                LoadProductCategories();
            }           
        } 
    }
}