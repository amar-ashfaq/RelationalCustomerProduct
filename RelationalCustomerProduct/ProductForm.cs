using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FileHelpers;
using System.Linq;

namespace RelationalCustomerProduct
{
    public partial class ProductForm : Form
    {
        DataAccess dataAccess;
        FileHelperEngine<Product> engine = new FileHelperEngine<Product>();
        ErrorProvider errorProvider = new ErrorProvider();
        string directoryPath = "";

        public ProductForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataAccess = new DataAccess();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            productid.Enabled = false;
            LoadCategoryComboBox();
            LoadProducts();

            if (dgvProducts.Rows.Count > 0)
            {
                dgvProducts.CurrentRow.Selected = true;
            }
            else
            {
                DisableFields();
            }           
        }

        //refactored
        private void LoadProducts()
        {
            try
            {
                ProductBindingSource.DataSource = dataAccess.LoadProducts();                
            }
            finally
            {
                ProductBindingSource.ResetBindings(false);
            }           
        }

        //refactored
        private void LoadCategoryComboBox()
        {
            try
            {
                category_comboBox.DataSource = dataAccess.LoadCategoryComboBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
            }            
        }

        private void DisableFields()
        {
            code_.Enabled = false;
            description.Enabled = false;
            height.Enabled = false;
            width.Enabled = false;
            depth.Enabled = false;
            colour_pictureBox.Enabled = false;
            category_comboBox.Enabled = false;
            browse.Enabled = false;
            save.Enabled = false;
            delete.Enabled = false;
        }

        private void EnableFields()
        {
            code_.Enabled = true;
            description.Enabled = true;
            height.Enabled = true;
            width.Enabled = true;
            depth.Enabled = true;
            colour_pictureBox.Enabled = true;
            category_comboBox.Enabled = true;
            browse.Enabled = true;
            save.Enabled = true;
            delete.Enabled = true;
        }

        //refactored
        private void ColourPictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (ProductColorDialog.ShowDialog() == DialogResult.OK)
            {
               (ProductBindingSource.Current as Product).colour = ProductColorDialog.Color;
               colour_pictureBox.BackColor = ProductColorDialog.Color;
            }            
                          
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count == 1)
            {
                EnableFields();
            }
            
            add.Enabled = false;
            ProductBindingSource.AddNew();
            //dgvProducts.DataSource = ProductBindingSource;
            dgvProducts.CurrentRow.Selected = true;
            code_.Focus();
        }

        //refactored
        private void SaveProduct_Click(object sender, EventArgs e)
        {
            add.Enabled = true;
            Product product = (Product)ProductBindingSource.Current;

            if (product.IsNewRecord())
            {
                if (!IsExistingProductCode(product.code, true))
                {
                    if (!ErrorCheck())
                    {
                        InsertProduct(product, true);
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
                    UpdateProduct(product, true);
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
            ImageConversion image = new ImageConversion();
            Bitmap bitmap;

            Product product = ProductBindingSource.Current as Product;
           
            if (product.image != null)
            {
                bitmap = new Bitmap(product.image);
                string product_image = image.ImageToBase64(bitmap);
            }
            else
            {
                _image.Focus();
                errorProvider.SetError(_image, "Please select an image!");
                check = true;
            }

            Color colour = product.colour;
            int a = colour.ToArgb();

            string product_code = code_.Text;
            string product_description = description.Text;
            string product_height = height.Text;
            string product_width = width.Text;
            string product_depth = depth.Text;
            string product_colour = a.ToString();
            string product_category = category_comboBox.Text;

            //code
            if (string.IsNullOrWhiteSpace(product_code))
            {
                code_.Focus();
                errorProvider.SetError(code_, "Please enter a valid product code!");
                check = true;
            }

            else if (product_code.Length > 10)
            {
                code_.Focus();
                errorProvider.SetError(code_, "Please enter a valid product code of up to 10 characters!");
                check = true;
            }

            //description
            if (string.IsNullOrWhiteSpace(product_description))
            {
                description.Focus();
                errorProvider.SetError(description, "Please enter a valid customer name!");
                check = true;
            }
            else if (product_description.Length > 50)
            {
                description.Focus();
                errorProvider.SetError(description, "Please enter a valid customer name of up to 50 characters!");
                check = true;
            }

            //height
            if (string.IsNullOrWhiteSpace(product_height))
            {
                height.Focus();
                errorProvider.SetError(height, "Please enter a valid height value!");
                check = true;
            }
            else if (product_height.Length > 4)
            {
                height.Focus();
                errorProvider.SetError(height, "Please enter a valid height value consisting of up to 4 characters!");
                check = true;
            }
            if(product_height == "0")
            {
                height.Focus();
                errorProvider.SetError(height, "Height value cannot be zero!");
                check = true;
            }

            //width
            if (string.IsNullOrWhiteSpace(product_width))
            {
                width.Focus();
                errorProvider.SetError(width, "Please enter a valid width value!");
                check = true;
            }
            else if (product_width.Length > 4)
            {
                width.Focus();
                errorProvider.SetError(width, "Please enter a valid width value consisting of up to 4 characters!");
                check = true;
            }
            if (product_width == "0")
            {
                width.Focus();
                errorProvider.SetError(width, "Width value cannot be zero!");
                check = true;
            }

            //depth
            if (string.IsNullOrWhiteSpace(product_depth))
            {
                depth.Focus();
                errorProvider.SetError(depth, "Please enter a valid depth value!");
                check = true;
            }
            else if (product_depth.Length > 4)
            {
                depth.Focus();
                errorProvider.SetError(depth, "Please enter a valid depth value consisting of up to 4 characters!");
                check = true;
            }
            if (product_depth == "0")
            {
                depth.Focus();
                errorProvider.SetError(depth, "Depth value cannot be zero!");
                check = true;
            }

            //colour
            if (product_colour == "0")
            {
                _colour.Focus();
                errorProvider.SetError(_colour, "Please select a colour!");
                check = true;
            }

            //category
            if (category_comboBox.Text == "")
            {
                category_comboBox.Focus();
                errorProvider.SetError(category_comboBox, "Please select a category!");
                check = true;
            }

            return check;
        }

        private void ClearErrorProvider()
        {
            errorProvider.SetError(code_, "");
            errorProvider.SetError(description, "");
            errorProvider.SetError(height, "");
            errorProvider.SetError(width, "");
            errorProvider.SetError(depth, "");
            errorProvider.SetError(_colour, "");
            errorProvider.SetError(category_comboBox, "");
            errorProvider.SetError(_image, "");
        }

        private bool IsExistingProductCode(string code, bool showMessage)
        {
            if (dataAccess.IsExistingProductCode(code))
            {
                ClearErrorProvider();

                if (showMessage)
                {
                    ErrorCheck();
                    errorProvider.SetError(code_, "Product code already exists");
                    MessageBox.Show("Product code already exists! Choose another one...");
                }
                else
                {
                    errorProvider.SetError(code_, "");
                }              
            }
            return dataAccess.IsExistingProductCode(code);
        }

        //refactored
        private void InsertProduct(Product product, bool showMessage)
        {
            try
            {
                dataAccess.InsertProduct(product);
                LoadProducts(); //refresh table

                if (showMessage)
                {
                    MessageBox.Show("Record created successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dgvProducts.CurrentRow != null)
                {
                    dgvProducts.CurrentRow.Selected = true;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
            }
        }

        //refactored
        private void UpdateProduct(Product product, bool showMessage)
        {
            product = (Product)ProductBindingSource.Current;

            if (MessageBox.Show("Update record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataAccess.UpdateProduct(product);
                    LoadProducts();

                    if (showMessage)
                    {
                        MessageBox.Show("Record updated successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    if (dgvProducts.CurrentRow != null)
                    {
                        dgvProducts.CurrentRow.Selected = true;
                    }
                                        
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                }                              
            }
        }

        private void Browse_Click(object sender, EventArgs e) //get file path
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string _filename = open.FileName;
                directoryPath = _filename;

                Bitmap m = new Bitmap(open.FileName);
                Bitmap resized = new Bitmap(m, new Size(m.Width / 6, m.Height / 6));

                (ProductBindingSource.Current as Product).image = resized;
                image.Image = resized;
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearErrorProvider();
            add.Enabled = true;
            delete.Enabled = true;
            LoadProducts();
            dgvProducts.CurrentRow.Selected = true;        
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Product product = ProductBindingSource.Current as Product;
           
            if (MessageBox.Show("Delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataAccess.DeleteProduct(product);
                    add.Enabled = true;
                    LoadProducts(); //refresh table
                    MessageBox.Show("Record deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch(Exception ex)
                {
                    MessageBox.Show("An exception occured opening a connection to the database: " + ex.Message);
                }                
            }
            if (dgvProducts.CurrentRow != null)
            {
                dgvProducts.CurrentRow.Selected = true;
            }                       
        } 

        private void ExportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportProducts();
        }

        private void ExportProducts()
        {
            List<Product> products = ProductBindingSource.DataSource as List<Product>;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                string filter = "CSV file (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm|All Files(*.*)|*.*";
                sfd.Filter = filter;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filter = sfd.FileName;
                    engine.WriteFile(filter, products);
                    MessageBox.Show("Product CSV Succesfully Exported...");
                }
            }
        }
        
        private void ImportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportProductForm importProductForm = new ImportProductForm();
            DialogResult dr = importProductForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                LoadProducts();
            }                       
        }
    }
}