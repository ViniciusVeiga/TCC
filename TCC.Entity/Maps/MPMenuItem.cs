using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPMenuItem : EntityTypeConfiguration<ETMenuItem>
    {
        public MPMenuItem()
        {
            ToTable("ADM_TCC_MENU_ITEM");

            Property(e => e.IdMenu)
                .HasPrecision(18, 0)
                .IsRequired()
                .HasColumnName("ID_MENU_C");

            Property(e => e.Title)
                .IsRequired()
                .HasColumnName("TITLE_C");

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
