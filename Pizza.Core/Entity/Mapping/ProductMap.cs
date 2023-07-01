using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class ProductMap: EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(p => p.ProductID);
            Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(50);

            HasRequired(p => p.User).WithMany(p => p.Product).HasForeignKey(p => p.UserID).WillCascadeOnDelete(false);
            HasRequired(p => p.Category).WithMany(p => p.Product).HasForeignKey(p => p.CategoryID);
            HasRequired(p => p.ProductClass).WithMany(p => p.Product).HasForeignKey(p => p.ProductClassID).WillCascadeOnDelete(false);

            Property(p => p.ProductID).HasColumnName("ProductID");
            Property(p => p.ProductName).HasColumnName("ProductName");
            Property(p => p.CategoryID).HasColumnName("CategoryID");
            Property(p => p.ModifiedDate).HasColumnName("ModifiedDate");
            Property(p => p.UserID).HasColumnName("UserID");

            ToTable("Products");
        }
    }
}
