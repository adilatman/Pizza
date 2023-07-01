using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class Order
    {
        public Guid OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }        
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public Customer Customer { get; set; }
    }
}
