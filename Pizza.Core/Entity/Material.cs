using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class Material
    {
        public int MaterialID { get; set; }
        public string MaterialName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public ICollection<MaterialPrice> MaterialPrice { get; set; }
        public ICollection<OrderDetailExtra> OrderDetailExtra { get; set; }
        public ICollection<Content> Content { get; set; }
        public override string ToString()
        {
            return MaterialName;
        }
    }
}
