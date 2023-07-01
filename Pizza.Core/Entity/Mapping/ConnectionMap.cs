using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class ConnectionMap: EntityTypeConfiguration<Connection>
    {
        public ConnectionMap()
        {
            HasKey(c=>c.ConnectionID);
            Property(c => c.ConnectionDetail)
                .IsRequired()
                .HasMaxLength(200);

            HasRequired(c=>c.User).WithMany(c=>c.Connection).HasForeignKey(c=>c.UserID).WillCascadeOnDelete(false);
            HasRequired(c=>c.Customer).WithMany(c=>c.Connection).HasForeignKey(c=>c.CustomerID);
            HasRequired(c => c.ConnectionType).WithMany(c => c.Connection).HasForeignKey(c => c.ConnectionTypeID);

            Property(c => c.ConnectionID).HasColumnName("ConnectionID");
            Property(c => c.ConnectionDetail).HasColumnName("ConnectionDetail");
            Property(c => c.CustomerID).HasColumnName("CustomerID");
            Property(c => c.ConnectionTypeID).HasColumnName("ConnectionTypeID");
            Property(c => c.ModifiedDate).HasColumnName("ModifiedDate");
            Property(c => c.UserID).HasColumnName("UserID");

            ToTable("Connections");
        }
    }
}
