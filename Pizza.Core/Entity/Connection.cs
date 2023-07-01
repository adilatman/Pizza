using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class Connection
    {
        public int ConnectionID { get; set; }
        public string ConnectionDetail { get; set; }
        public int CustomerID { get; set; }
        public int ConnectionTypeID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public Customer Customer { get; set; }
        public ConnectionType ConnectionType { get; set; }
    }
}
