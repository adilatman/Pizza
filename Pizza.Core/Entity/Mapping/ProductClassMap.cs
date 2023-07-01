using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class ProductClassMap: EntityTypeConfiguration<ProductClass>
    {
        public ProductClassMap()
        {
            HasKey(p => p.ProductClassID);
            Property(p => p.ProductClassName)
                .IsRequired()
                .HasMaxLength(20);

            HasRequired(p => p.User).WithMany(p => p.ProductClass).HasForeignKey(p => p.UserID).WillCascadeOnDelete(false);

            Property(p => p.ProductClassID).HasColumnName("ProductClassID");
            Property(p => p.ProductClassName).HasColumnName("ProductClassName");
            Property(p => p.ModifiedDate).HasColumnName("ModifiedDate");
            Property(p => p.UserID).HasColumnName("UserID");

            ToTable("ProductClasses");
        }
    }
}
