using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public Guid OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int SizeID { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public Size Size { get; set; }
        public ICollection<OrderDetailExtra> OrderDetailExtra { get; set; }

    }
}
