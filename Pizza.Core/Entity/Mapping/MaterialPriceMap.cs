using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class MaterialPriceMap: EntityTypeConfiguration<MaterialPrice>
    {
        public MaterialPriceMap()
        {
            HasKey(m => m.MaterialPriceID);

            HasRequired(m => m.User).WithMany(m => m.MaterialPrice).HasForeignKey(m => m.UserID).WillCascadeOnDelete(false);
            HasRequired(m => m.Material).WithMany(m => m.MaterialPrice).HasForeignKey(m => m.MaterialID);

            Property(m => m.MaterialPriceID).HasColumnName("MaterialPriceID");
            Property(m => m.MaterialID).HasColumnName("MaterialID");
            Property(m => m.MaterialUnitPrice).HasColumnName("MaterialUnitPrice");
            Property(m => m.ModifiedDate).HasColumnName("ModifiedDate");
            Property(m => m.UserID).HasColumnName("UserID");

            ToTable("MaterialPrices");
        }
    }
}
