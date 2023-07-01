using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Core.Entity.Mapping
{
    public class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(u => u.UserID);
            Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(30);
            Property(u=>u.Password)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            Property(c => c.UserID).HasColumnName("UserID");
            Property(c => c.UserName).HasColumnName("UserName");
            Property(c => c.Password).HasColumnName("Password");
            Property(c => c.ModifiedDate).HasColumnName("ModifiedDate");
            Property(c => c.UserID).HasColumnName("UserID");

            ToTable("Users");
        }
    }
}
