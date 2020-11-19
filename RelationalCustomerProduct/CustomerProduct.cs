using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalCustomerProduct
{
    class CustomerProduct
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public int product_id { get; set; }
    }
}
