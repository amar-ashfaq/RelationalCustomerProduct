using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalCustomerProduct
{
    public static class CustomerConstants
    {
        public const string CustomerId = "id";
        public const string Account = "account";
        public const string Name = "name";
        public const string AddressLine1 = "address_line_1";
        public const string AddressLine2 = "address_line_2";
        public const string AddressLine3 = "address_line_3";
        public const string AddressLine4 = "address_line_4";
        public const string AddressPostcode = "address_postcode";
    }

    public static class ProductConstants
    {
        public const string ProductId = "id";
        public const string Code = "code";
        public const string Description = "description";
        public const string Height = "height";
        public const string Width = "width";
        public const string Depth = "depth";
        public const string Colour = "colour";
        public const string Image = "image";
        public const string Category = "category";
    }

    public static class CustomerProductConstants
    {
        public const string Id = "productcategoriesid";
        public const string Customer_id = "customerid";
        public const string Product_id = "productid";
    }

    public static class ProductCategoriesConstants
    {
        public const string Code = "code";
        public const string Description = "description";
    }
}