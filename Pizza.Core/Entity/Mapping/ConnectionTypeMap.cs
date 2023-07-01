using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class ConnectionTypeMap: EntityTypeConfiguration<ConnectionType>
    {
        public ConnectionTypeMap()
        {
            HasKey(c => c.ConnectionTypeID);
            Property(c=>c.ConnectionTypeName)
                .IsRequired()
                .HasMaxLength(20);

            HasRequired(c => c.User).WithMany(c => c.ConnectionType).HasForeignKey(c => c.UserID).WillCascadeOnDelete(false);

            Property(c => c.ConnectionTypeID).HasColumnName("ConnectionTypeID");
            Property(c => c.ConnectionTypeName).HasColumnName("ConnectionTypeName");
            Property(c => c.ModifiedDate).HasColumnName("ModifiedDate");
            Property(c => c.UserID).HasColumnName("UserID");

            ToTable("ConnectionTypes");
        }
    }
}
