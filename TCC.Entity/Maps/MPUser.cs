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
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("NAME_C");

            Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("EMAIL_C");

            Property(e => e.Password)
                .IsRequired()
                .HasColumnName("PASSWORD_C");

            Property(e => e.Token)
                .HasColumnName("TOKEN_C");
        }
    }
}
