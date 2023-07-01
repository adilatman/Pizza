using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class PriceMap: EntityTypeConfiguration<Price>
    {
        public PriceMap()
        {
            HasKey(p => p.PriceID);
            Property(p => p.UnitPrice)
                .IsRequired();

            HasRequired(p => p.User).WithMany(p => p.Price).HasForeignKey(p => p.UserID).WillCascadeOnDelete(false);
            HasRequired(p => p.Size).WithMany(p => p.Price).HasForeignKey(p => p.SizeID);
            HasRequired(p => p.ProductClass).WithMany(p => p.Price).HasForeignKey(p => p.ProductClassID);
            HasRequired(p => p.Category).WithMany(p => p.Price).HasForeignKey(p => p.CategoryID);


            Property(p => p.PriceID).HasColumnName("PriceID");
            Property(p => p.SizeID).HasColumnName("SizeID");
            Property(p => p.ProductClassID).HasColumnName("ProductClassID");
            Property(p => p.CategoryID).HasColumnName("CategoryID");
            Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            Property(p => p.ModifiedDate).HasColumnName("ModifiedDate");
            Property(p => p.UserID).HasColumnName("UserID");

            ToTable("Prices");
        }
    }
}
