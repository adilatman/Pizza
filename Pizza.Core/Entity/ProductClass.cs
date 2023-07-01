using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class ProductClass
    {
        public int ProductClassID { get; set; }
        public string ProductClassName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public ICollection<Price> Price { get; set; }
        public ICollection<Product> Product { get; set; }
        public override string ToString()
        {
            return ProductClassName; 
        }
    }
}
