using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class Content
    {
        public int ContentID { get; set; }
        public int ProductID { get; set; }
        public int MaterialID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
        public Material Material { get; set; }
    }
}
