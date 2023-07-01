using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }        
        public string CategoryName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public ICollection<Product> Product { get; set; }
        public ICollection<Price> Price { get; set; }
        public User User { get; set; }
        public override string ToString()
        {
            return CategoryName;
        }
    }
}
