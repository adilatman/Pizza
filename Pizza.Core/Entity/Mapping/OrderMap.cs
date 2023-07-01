using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class OrderMap: EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            HasKey(o => o.OrderID);

            HasRequired(o => o.User).WithMany(o => o.Order).HasForeignKey(o => o.UserID).WillCascadeOnDelete(false);
            HasRequired(o => o.Customer).WithMany(o => o.Order).HasForeignKey(o => o.CustomerID);

            Property(o => o.OrderID).HasColumnName("OrderID");
            Property(o => o.CustomerID).HasColumnName("CustomerID");
            Property(o => o.OrderDate).HasColumnName("OrderDate");
            Property(o => o.UserID).HasColumnName("UserID");

            ToTable("Orders");
        }
    }
}
