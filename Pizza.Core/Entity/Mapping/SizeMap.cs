using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class SizeMap: EntityTypeConfiguration<Size>
    {
        public SizeMap()
        {
            HasKey(s => s.SizeID);

            HasRequired(s => s.User).WithMany(s => s.Size).HasForeignKey(s => s.UserID).WillCascadeOnDelete(false);

            Property(s => s.SizeID).HasColumnName("SizeID");
            Property(s => s.SizeName).HasColumnName("SizeName");
            Property(s => s.ModifiedDate).HasColumnName("ModifiedDate");
            Property(s => s.UserID).HasColumnName("UserID");

            ToTable("Sizes");
        }
    }
}
