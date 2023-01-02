using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core
{
    public class Order:BaseEntity
    {
        public int Id { get; set; } 
        public int CompanyId { get; set; }
        public Company company { get; set; }
        public int ProductsId { get; set; }
        public Products products { get; set; }
        public string? CustomerName { get; set; }    
        public DateTime OrderDate { get; set; } 
    }
}
