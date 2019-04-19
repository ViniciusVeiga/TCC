using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities.Security;

namespace TCC.Entity.Maps
{
    public class MPUser : EntityTypeConfiguration<ETUser>
    {
        public MPUser()
        {
            ToTable("TCC_USER");

            Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("USE_C_NAME");

            Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("USE_C_EMAIL");

            Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("USE_C_PASSWORD");
        }
    }
}
