using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class OrderDetailMap: EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            HasKey(o => o.OrderDetailID);
            Property(o => o.Quantity)
                .IsRequired();

            HasRequired(o => o.User).WithMany(o => o.OrderDetail).HasForeignKey(o => o.UserID).WillCascadeOnDelete(false);
            HasRequired(o => o.Order).WithMany(o => o.OrderDetail).HasForeignKey(o => o.OrderID);
            HasRequired(o => o.Product).WithMany(o => o.OrderDetail).HasForeignKey(o => o.ProductID);
            HasRequired(o => o.Size).WithMany(o => o.OrderDetail).HasForeignKey(o => o.SizeID);

            Property(o => o.OrderDetailID).HasColumnName("OrderDetailID");
            Property(o => o.OrderID).HasColumnName("OrderID");
            Property(o => o.ProductID).HasColumnName("ProductID");
            Property(o => o.Quantity).HasColumnName("Quantity");
            Property(o => o.SizeID).HasColumnName("SizeID");
            Property(o => o.UserID).HasColumnName("UserID");

            ToTable("OrderDetails");
        }
    }
}
