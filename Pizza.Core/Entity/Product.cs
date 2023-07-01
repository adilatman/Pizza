using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int ProductClassID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }
        
        public User User { get; set; }
        public Category Category { get; set; }
        public ProductClass ProductClass { get; set; }
        public ICollection<Content> Content { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public override string ToString()
        {
            return ProductName;
        }
    }
}
