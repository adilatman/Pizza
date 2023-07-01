using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class MaterialPrice
    {
        public int MaterialPriceID { get; set; }
        public int MaterialID { get; set; }
        public decimal MaterialUnitPrice { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public Material Material { get; set; }
        public override string ToString()
        {
            return MaterialUnitPrice.ToString();
        }
    }
}
