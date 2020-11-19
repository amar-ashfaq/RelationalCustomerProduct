using Devart.Data.Universal;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RelationalCustomerProduct
{
    public class DataAccess
    {
        //SELECT OPERATIONS - CustomerForm.cs
        public List<Customer> LoadCustomers()
        {
            List<Customer> customers = new List<Customer>();

            string sql = "SELECT id, account, name, address_line_1, address_line_2, address_line_3, address_line_4, address_postcode FROM customers ORDER BY id";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {                
                con.Open();

                UniCommand command = new UniCommand(sql, con);

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Customer customer = new Customer();

                            customer.id = dr.GetInt32(CustomerConstants.CustomerId);
                            customer.account = dr.GetString(CustomerConstants.Account);
                            customer.name = dr.GetString(CustomerConstants.Name);
                            customer.address_line_1 = dr.GetString(CustomerConstants.AddressLine1);
                            customer.address_line_2 = dr.GetString(CustomerConstants.AddressLine2);
                            customer.address_line_3 = dr.GetString(CustomerConstants.AddressLine3);
                            customer.address_line_4 = dr.GetString(CustomerConstants.AddressLine4);
                            customer.address_postcode = dr.GetString(CustomerConstants.AddressPostcode);

                            customers.Add(customer);
                        }
                    }
                }
                               
                con.Close();                
            }

            return customers;
        }

        public List<Product> LoadCustomerProducts(int id)
        {
            CustomerForm customerForm = new CustomerForm();
            List<Product> products = new List<Product>();

            string sql = "SELECT products.id, products.code, products.description, products.category FROM products INNER JOIN customer_products ON products.id = customer_products.product_id WHERE customer_products.customer_id = :id ORDER BY products.code";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {
                con.Open();

                UniCommand command = new UniCommand(sql, con);
                command.Parameters.Add("id", UniDbType.Int).Value = id;

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Product product = new Product();

                            product.id = dr.GetInt32(ProductConstants.ProductId);
                            product.code = dr.GetString(ProductConstants.Code);
                            product.description = dr.GetString(ProductConstants.Description);
                            product.category = dr.GetString(ProductConstants.Category);

                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }   

        public bool IsExistingCustomerAccount(string account)
        {
            string sql = "SELECT account FROM customers WHERE account = :account";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {
                con.Open();

                UniCommand command = new UniCommand(sql, con);
                command.Parameters.Add("account", UniDbType.VarChar).Value = account;

                using (UniDataReader dr = command.ExecuteReader())
                {

                    if (dr.Read())
                    {
                        con.Close();
                        return true;
                    }

                    con.Close();
                    return false;
                }
            }
        }

        //INSERT OPERATIONS - CustomerForm.cs
        public void InsertCustomer(Customer customer)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {               
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniCommand command = new UniCommand("INSERT into customers(account, name, address_line_1, address_line_2, address_line_3, address_line_4, address_postcode) VALUES (:account, :name, :address_line_1, :address_line_2, :address_line_3, :address_line_4, :address_postcode) returning id", con))
                    {
                        //INSERT OPERATION BELOW..                      
                        command.Parameters.Add("account", UniDbType.VarChar).Value = customer.account;
                        command.Parameters.Add("name", UniDbType.VarChar).Value = customer.name;
                        command.Parameters.Add("address_line_1", UniDbType.VarChar).Value = customer.address_line_1;
                        command.Parameters.Add("address_line_2", UniDbType.VarChar).Value = customer.address_line_2;
                        command.Parameters.Add("address_line_3", UniDbType.VarChar).Value = customer.address_line_3;
                        command.Parameters.Add("address_line_4", UniDbType.VarChar).Value = customer.address_line_4;
                        command.Parameters.Add("address_postcode", UniDbType.VarChar).Value = customer.address_postcode;

                        int newCustomerID = (int)command.ExecuteScalar();                                             
                    }
                }

                con.Close();                
            }
        }

        public void CreateProductSelection(int customerid, int productid)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {                
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {

                    using (UniCommand command = new UniCommand("INSERT into customer_products(customer_id, product_id) VALUES (:customer_id, :product_id) returning id", con))
                    {
                        //INSERT OPERATION BELOW..                      
                        command.Parameters.Add("customer_id", UniDbType.Int).Value = customerid;
                        command.Parameters.Add("product_id", UniDbType.Int).Value = productid;

                        command.ExecuteScalar();
                    }
                }
                else
                {
                    MessageBox.Show("Not open...");
                }
               
                con.Close();               
            }
        }

        //UPDATE OPERATIONS - CustomerForm.cs
        public void UpdateCustomer(Customer customer)
        {            
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {               
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                { 
                    using (UniCommand command = new UniCommand("UPDATE customers SET account = :account, name = :name, address_line_1 = :address_line_1, address_line_2 = :address_line_2, address_line_3 = :address_line_3, address_line_4 = :address_line_4, address_postcode = :address_postcode WHERE id = :id", con))
                    {
                        command.Parameters.Add("id", UniDbType.Int).Value = customer.id;
                        command.Parameters.Add("account", UniDbType.VarChar).Value = customer.account;
                        command.Parameters.Add("name", UniDbType.VarChar).Value = customer.name;
                        command.Parameters.Add("address_line_1", UniDbType.VarChar).Value = customer.address_line_1;
                        command.Parameters.Add("address_line_2", UniDbType.VarChar).Value = customer.address_line_2;
                        command.Parameters.Add("address_line_3", UniDbType.VarChar).Value = customer.address_line_3;
                        command.Parameters.Add("address_line_4", UniDbType.VarChar).Value = customer.address_line_4;
                        command.Parameters.Add("address_postcode", UniDbType.VarChar).Value = customer.address_postcode;

                        command.ExecuteNonQuery();                              
                    }
                }
                else
                {
                    MessageBox.Show("Not open...");
                }
                              
                con.Close();               
            }           
        }


        //DELETE OPERATIONS - CustomerForm.cs
        public void RemoveProductSelection(int customerID, int productID)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {               
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    UniCommand command = new UniCommand("DELETE FROM customer_products WHERE customer_products.customer_id = :customerID AND customer_products.product_id = :productID", con);

                    command.Parameters.Add("customerID", UniDbType.Int).Value = customerID;
                    command.Parameters.Add("productID", UniDbType.Int).Value = productID;
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Not open...");
                }                
                
                con.Close();               
            }
        }

        public void DeleteProductSelection(Customer customer, List<Product> products)
        {        
            foreach (Product product in products.Where(p => p.isSelected))
            {
                RemoveProductSelection(customer.id, product.id); //pass id to the remove function                   
            }                       
        }

        public void DeleteCustomer(Customer customer)
        {           
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {                
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    UniCommand command = new UniCommand("DELETE FROM customers WHERE id = :customerid", con);

                    command.Parameters.Add("customerid", UniDbType.Int).Value = customer.id;
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Not open...");
                }
                              
                con.Close();
            }          
        }

        //SELECT OPERATIONS - ProductSelectionForm.cs
        public List<Product> LoadCustomerProducts()
        {
            List<Product> products = new List<Product>();

            string sql = "SELECT id, code, description, height, width, depth FROM products ORDER BY id";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {                
                con.Open();

                UniCommand command = new UniCommand(sql, con);

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Product product = new Product();

                            product.id = dr.GetInt32(ProductConstants.ProductId);
                            product.code = dr.GetString(ProductConstants.Code);
                            product.description = dr.GetString(ProductConstants.Description);
                            product.height = dr.GetInt32(ProductConstants.Height);
                            product.width = dr.GetInt32(ProductConstants.Width);
                            product.depth = dr.GetInt32(ProductConstants.Depth);

                            products.Add(product);
                        }
                    }
                }
                                              
                con.Close();
                
                return products;
            }
        }

        //SELECT OPERATIONS - ProductForm.cs
        public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            string sql = "SELECT id, code, description, height, width, depth, colour, image, category FROM products ORDER BY id";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {               
                con.Open();

                UniCommand command = new UniCommand(sql, con);

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Product product = new Product();
                            ImageConversion images = new ImageConversion();

                            product.id = dr.GetInt32(ProductConstants.ProductId);
                            product.code = dr.GetString(ProductConstants.Code);
                            product.description = dr.GetString(ProductConstants.Description);
                            product.height = dr.GetInt32(ProductConstants.Height);
                            product.width = dr.GetInt32(ProductConstants.Width);
                            product.depth = dr.GetInt32(ProductConstants.Depth);
                            product.colour = Color.FromArgb(dr.GetInt32(ProductConstants.Colour));
                            product.image = images.Base64ToImage(dr.GetString(ProductConstants.Image));
                            product.category = dr.GetString(ProductConstants.Category);

                            products.Add(product);
                        }
                    }
                }                               
                con.Close();                
            }
            return products;
        }

        public List<string> LoadCategoryComboBox()
        {
            List<string> categories = new List<string>();
            categories.Add("");

            string sql = "SELECT code FROM product_categories ORDER BY code";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {               
                con.Open();

                UniCommand command = new UniCommand(sql, con);

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            categories.Add(dr.GetString("code"));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not open...");
                }                               
                
                con.Close();
                
                return categories;
            }
        }

        public bool IsExistingProductCode(string code)
        {
            string sql = "SELECT code FROM products WHERE code = :code";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {
                con.Open();

                UniCommand command = new UniCommand(sql, con);
                command.Parameters.Add("code", UniDbType.VarChar).Value = code;

                using (UniDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        con.Close();
                        return true;
                    }

                    con.Close();
                    return false;
                }
            }
        }

        //INSERT OPERATIONS - ProductForm.cs
        public void InsertProduct(Product product)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {               
                con.Open();
                   
                using (UniCommand command = new UniCommand("INSERT into products(code, description, height, width, depth, colour, image, category) VALUES (:code, :description, :height, :width, :depth, :colour, :image, :category) returning id", con))
                {
                    ImageConversion images = new ImageConversion();

                    //INSERT OPERATION BELOW..                      
                    command.Parameters.Add("code", UniDbType.VarChar).Value = product.code;
                    command.Parameters.Add("description", UniDbType.VarChar).Value = product.description;
                    command.Parameters.Add("height", UniDbType.Int).Value = product.height;
                    command.Parameters.Add("width", UniDbType.Int).Value = product.width;
                    command.Parameters.Add("depth", UniDbType.Int).Value = product.depth;
                    command.Parameters.Add("colour", UniDbType.Int).Value = product.colour.ToArgb();
                    command.Parameters.Add("image", UniDbType.VarChar).Value = images.ImageToBase64(product.image); //passing base64 string in
                    command.Parameters.Add("category", UniDbType.VarChar).Value = product.category;

                    int newProductID = (int)command.ExecuteScalar();                     
                }
                           
                con.Close();              
            }
        }

        //UPDATE OPERATIONS - ProductForm.cs
        public void UpdateProduct(Product product) {
            
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {               
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {                            
                    using (UniCommand command = new UniCommand("UPDATE products SET code = :code, description = :description, height = :height, width = :width, depth = :depth, colour = :colour, image = :image, category = :category WHERE id = :id", con))
                    {
                        ImageConversion images = new ImageConversion();

                        command.Parameters.Add("id", UniDbType.VarChar).Value = product.id;
                        command.Parameters.Add("code", UniDbType.VarChar).Value = product.code;
                        command.Parameters.Add("description", UniDbType.VarChar).Value = product.description;
                        command.Parameters.Add("height", UniDbType.Int).Value = product.height;
                        command.Parameters.Add("width", UniDbType.Int).Value = product.width;
                        command.Parameters.Add("depth", UniDbType.Int).Value = product.depth;
                        command.Parameters.Add("colour", UniDbType.Int).Value = product.colour.ToArgb();
                        command.Parameters.Add("image", UniDbType.VarChar).Value = images.ImageToBase64(product.image); //passing base64 string in
                        command.Parameters.Add("category", UniDbType.VarChar).Value = product.category;

                        command.ExecuteNonQuery();                          
                    }
                }
                                
                con.Close();               
            }
            
        }

        //DELETE OPERATIONS - ProductForm.cs
        public void DeleteProduct(Product product)
        {            
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {                
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniCommand command = new UniCommand("DELETE FROM products WHERE id = :id", con))
                    {
                        command.Parameters.Add("id", UniDbType.VarChar).Value = product.id;
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Not open...");
                }
                               
                con.Close();                                  
            }
        }

        //SELECT OPERATIONS - ProductCategoriesForm.cs
        public List<Category> LoadProductCategories()
        {
            List<Category> categories = new List<Category>();

            string sql = "SELECT code, description FROM product_categories ORDER BY code";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {               
                con.Open();

                UniCommand command = new UniCommand(sql, con);

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Category category = new Category();

                            category.code = dr.GetString(ProductCategoriesConstants.Code);
                            category.description = dr.GetString(ProductCategoriesConstants.Description);
                            category.IsNewRecord = false;
                            categories.Add(category);
                        }
                    }
                }

                con.Close();                
            }
            return categories;
        }

        public bool IsExistingCategoryCode(string code)
        {
            string sql = "SELECT code FROM product_categories WHERE code = :code";

            using (UniConnection con = DatabaseConnection.MakeConnection())
            {
                con.Open();

                UniCommand command = new UniCommand(sql, con);
                command.Parameters.Add("code", UniDbType.VarChar).Value = code;

                using (UniDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        con.Close();
                        return true;
                    }

                    con.Close();
                    return false;
                }
            }
        }

        //INSERT OPERATIONS - ProductCategoriesForm.cs
        public void InsertProductCategory(Category category)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {                
                con.Open();

                using (UniCommand command = new UniCommand("INSERT into product_categories(code, description) VALUES (:code, :description)", con))
                {
                    //INSERT OPERATION BELOW..                      
                    command.Parameters.Add("code", UniDbType.VarChar).Value = category.code;
                    command.Parameters.Add("description", UniDbType.VarChar).Value = category.description;

                    command.ExecuteNonQuery();                     
                }
                    
                con.Close();               
            }
        }


        //UPDATE OPERATIONS - ProductCategoriesForm.cs
        public void UpdateProductCategory(Category category, string old_code)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {              
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                { 
                    using (UniCommand command = new UniCommand("UPDATE product_categories SET code = :code, description = :description WHERE code = :pcode", con))
                    {
                        command.Parameters.Add("code", UniDbType.VarChar).Value = category.code;
                        command.Parameters.Add("description", UniDbType.VarChar).Value = category.description;
                        command.Parameters.Add("pcode", UniDbType.VarChar).Value = old_code;

                        command.ExecuteNonQuery();                          
                    }
                }
                else
                {
                    MessageBox.Show("Not open...");
                }
   
                con.Close();                
            }
        }

        //DELETE OPERATIONS - ProductCategoriesForm.cs
        public void DeleteProductCategory(Category category)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {              
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniCommand command = new UniCommand("DELETE FROM product_categories WHERE code = :code", con))
                    {
                        //INSERT OPERATION BELOW..                      
                        command.Parameters.Add("code", UniDbType.VarChar).Value = category.code;
                        command.ExecuteNonQuery();  
                    }
                }
                else
                {
                    MessageBox.Show("Not open...");
                }
                               
                con.Close();              
            }
        }

        public void UpdateCustomersCSV(Customer customer)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {                
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniCommand command = new UniCommand("UPDATE customers SET name = :name, address_line_1 = :address_line_1, address_line_2 = :address_line_2, address_line_3 = :address_line_3, address_line_4 = :address_line_4, address_postcode = :address_postcode WHERE account = :account", con))
                    {
                        command.Parameters.Add("account", UniDbType.VarChar).Value = customer.account;
                        command.Parameters.Add("name", UniDbType.VarChar).Value = customer.name;
                        command.Parameters.Add("address_line_1", UniDbType.VarChar).Value = customer.address_line_1;
                        command.Parameters.Add("address_line_2", UniDbType.VarChar).Value = customer.address_line_2;
                        command.Parameters.Add("address_line_3", UniDbType.VarChar).Value = customer.address_line_3;
                        command.Parameters.Add("address_line_4", UniDbType.VarChar).Value = customer.address_line_4;
                        command.Parameters.Add("address_postcode", UniDbType.VarChar).Value = customer.address_postcode;

                        command.ExecuteNonQuery(); 
                    }
                }
                else
                {
                    MessageBox.Show("Not open...");
                }
                                
                con.Close();                
            }
        }

        public void UpdateProductsCSV(Product product)
        {
            using (UniConnection con = DatabaseConnection.MakeConnection())
            {              
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    using (UniCommand command = new UniCommand("UPDATE products SET description = :description, height = :height, width = :width, depth = :depth, colour = :colour, image = :image, category = :category WHERE code = :code", con))
                    {
                        ImageConversion images = new ImageConversion();

                        command.Parameters.Add("code", UniDbType.VarChar).Value = product.code;
                        command.Parameters.Add("description", UniDbType.VarChar).Value = product.description;
                        command.Parameters.Add("height", UniDbType.Int).Value = product.height;
                        command.Parameters.Add("width", UniDbType.Int).Value = product.width;
                        command.Parameters.Add("depth", UniDbType.Int).Value = product.depth;
                        command.Parameters.Add("colour", UniDbType.Int).Value = product.colour.ToArgb();
                        command.Parameters.Add("image", UniDbType.VarChar).Value = images.ImageToBase64(product.image); //passing base64 string in
                        command.Parameters.Add("category", UniDbType.VarChar).Value = product.category;

                        command.ExecuteNonQuery();
                    }
                }

                con.Close();               
            }
        }
    }
}