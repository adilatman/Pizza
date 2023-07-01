using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasKey(c => c.CategoryID);
            Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            HasRequired(c => c.User).WithMany(c => c.Category).HasForeignKey(c => c.UserID).WillCascadeOnDelete(false);

            Property(c => c.CategoryID).HasColumnName("CategoryID");
            Property(c => c.CategoryName).HasColumnName("Category");
            Property(c => c.ModifiedDate).HasColumnName("ModifiedDate");
            Property(c => c.UserID).HasColumnName("UserID");

            ToTable("Categories");
        }
    }
}
