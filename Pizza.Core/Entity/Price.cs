using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class Price
    {
        public int PriceID { get; set; }
        public int SizeID { get; set; }
        public int ProductClassID { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public Size Size { get; set; }
        public Category Category { get; set; }
        public ProductClass ProductClass { get; set; }
        public override string ToString()
        {
            return UnitPrice.ToString();
        }
    }
}
