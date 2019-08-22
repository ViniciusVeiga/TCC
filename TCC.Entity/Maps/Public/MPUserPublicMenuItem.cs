using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPUserPublicMenuItem : EntityTypeConfiguration<ETUserPublicMenuItem>
    {
        public MPUserPublicMenuItem()
        {
            ToTable("PUB_TCC_USER_PUBLIC_MENU_ITEM");

            Property(e => e.IdUserPublic)
                .IsRequired()
                .HasColumnName("ID_USER_PUBLIC_N");

            Property(e => e.IdMenuItem)
                .IsRequired()
                .HasColumnName("ID_MENU_ITEM_N");
        }
    }
}
