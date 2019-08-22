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
                .HasColumnName("ID_MENU_N");

            Property(e => e.IdMenuType)
                .HasPrecision(18, 0)
                .IsRequired()
                .HasColumnName("ID_MENU_TYPE_N");

            Property(e => e.Title)
                .IsRequired()
                .HasColumnName("TITLE_C");

            Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("URL_C");

            Property(e => e.Icon)
                .HasMaxLength(100)
                .HasColumnName("ICON_C");

            Property(e => e.Order)
                .IsRequired()
                .HasPrecision(18, 0)
                .HasColumnName("ORDER_N");

            Property(e => e.Key)
                .HasMaxLength(100)
                .HasColumnName("KEY_C");
        }
    }
}
