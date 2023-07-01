using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class CustomerMap: EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(c => c.CustomerID);
            Property(c=>c.CustomerName)
                .IsRequired()
                .HasMaxLength(50);

            HasRequired(c => c.User).WithMany(c => c.Customer).HasForeignKey(c => c.UserID).WillCascadeOnDelete(false);

            Property(c => c.CustomerID).HasColumnName("CustomerID");
            Property(c => c.CustomerName).HasColumnName("CustomerName");
            Property(c => c.ModifiedDate).HasColumnName("ModifiedDate");
            Property(c => c.UserID).HasColumnName("UserID");

            ToTable("Customers");

        }
    }
}
