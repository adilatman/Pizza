using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class ConnectionType
    {
        public int ConnectionTypeID { get; set; }
        public string ConnectionTypeName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public ICollection<Connection> Connection { get; set; }
        public override string ToString()
        {
            return ConnectionTypeName;
        }
    }
}
