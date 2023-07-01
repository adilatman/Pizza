using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<Category> Category { get; set; }
        public ICollection<Connection> Connection { get; set; }
        public ICollection<ConnectionType> ConnectionType { get; set; }
        public ICollection<Content> Content { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<Material> Material { get; set; }
        public ICollection<MaterialPrice> MaterialPrice { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public ICollection<Price> Price { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<ProductClass> ProductClass { get; set; }
        public ICollection<Size> Size { get; set; }
        public override string ToString()
        {
            return UserName;
        }
    }
}
