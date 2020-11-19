using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelationalCustomerProduct
{
    
    [Serializable]
    public class EmptyListException : Exception
    {
        public EmptyListException()
        : base("List collection is empty!") {}
    }
}
