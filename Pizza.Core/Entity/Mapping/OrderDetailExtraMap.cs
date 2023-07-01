using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class OrderDetailExtraMap: EntityTypeConfiguration<OrderDetailExtra>
    {
        public OrderDetailExtraMap()
        {
            HasKey(o => o.OrderDetailExtraID);
                        
            HasRequired(o => o.OrderDetail).WithMany(o => o.OrderDetailExtra).HasForeignKey(o => o.OrderDetailID);
            HasRequired(o => o.Material).WithMany(o => o.OrderDetailExtra).HasForeignKey(o => o.MaterialID);


            Property(o => o.OrderDetailExtraID).HasColumnName("OrderDetailExtraID");
            Property(o => o.OrderDetailID).HasColumnName("OrderDetailID");
            Property(o => o.MaterialID).HasColumnName("MaterialID");

            ToTable("OrderDetailExtras");
        }
    }
}
