using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class Size
    {
        public int SizeID { get; set; }
        public string SizeName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public ICollection<Price> Price { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public override string ToString()
        {
            return SizeName;
        }
    }
}
