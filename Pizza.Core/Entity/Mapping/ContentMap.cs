using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class ContentMap: EntityTypeConfiguration<Content>
    {
        public ContentMap()
        {
            HasKey(c=>c.ContentID);

            HasRequired(c => c.User).WithMany(c => c.Content).HasForeignKey(c => c.UserID).WillCascadeOnDelete(false);
            HasRequired(c=>c.Product).WithMany(c=>c.Content).HasForeignKey(c=>c.ProductID);
            HasRequired(c => c.Material).WithMany(c => c.Content).HasForeignKey(c => c.MaterialID);

            Property(c => c.ContentID).HasColumnName("ContentID");
            Property(c => c.ProductID).HasColumnName("ProductID");
            Property(c => c.MaterialID).HasColumnName("MaterialID");
            Property(c => c.ModifiedDate).HasColumnName("ModifiedDate");
            Property(c => c.UserID).HasColumnName("UserID");

            ToTable("Contents");
        }
    }
}
