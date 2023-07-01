using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class OrderDetailExtra
    {
        public int OrderDetailExtraID { get; set; }
        public int OrderDetailID { get; set; }
        public int MaterialID { get; set; }

        public Material Material { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
