using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPMenu : EntityTypeConfiguration<ETMenuItem>
    {
        public MPMenu()
        {
            ToTable("ADM_TCC_MENU");

            Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME_C");

            Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("URL_C");

            Property(e => e.Order)
                .IsRequired()
                .HasPrecision(18, 0)
                .HasColumnName("ORDER_N");
        }
    }
}
