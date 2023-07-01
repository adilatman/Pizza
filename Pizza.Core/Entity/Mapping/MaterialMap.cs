using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class MaterialMap: EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
            HasKey(m => m.MaterialID);
            Property(m => m.MaterialName)
                .IsRequired()
                .HasMaxLength(50);

            HasRequired(m => m.User).WithMany(m => m.Material).HasForeignKey(m => m.UserID).WillCascadeOnDelete(false);

            Property(m => m.MaterialID).HasColumnName("MaterialID");
            Property(m => m.MaterialName).HasColumnName("MaterialName");
            Property(m => m.ModifiedDate).HasColumnName("ModifiedDate");
            Property(m => m.UserID).HasColumnName("UserID");

            ToTable("Materials");
        }
    }
}
