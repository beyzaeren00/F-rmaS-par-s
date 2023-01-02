using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core
{
    public class Products:BaseEntity
    {
        public int productName { get; set; }
        public int? productStock { get; set; }
        public decimal? productPrice { get; set; }
        public int CompanyId { get; set; }    
        public Company Company { get; set; }    
    }
}
