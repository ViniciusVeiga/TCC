using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities.Public;
using TCC.Domain.Entities.Public.Security;

namespace TCC.Entity.Maps
{
    public class MPUserPublicMenuItem : EntityTypeConfiguration<ETUserPublicMenuItem>
    {
        public MPUserPublicMenuItem()
        {
            ToTable("PUC_TCC_USER_PUBLIC_MENU_ITEM");

            Property(e => e.IdUserPublic)
                .IsRequired()
                .HasColumnName("N_ID_USER_PUBLIC");

            Property(e => e.IdMenuItem)
                .IsRequired()
                .HasColumnName("N_ID_MENU_ITEM");
        }
    }
}
