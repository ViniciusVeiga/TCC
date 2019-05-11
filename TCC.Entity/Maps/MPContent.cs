using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities.Admin;

namespace TCC.Entity.Maps
{
    public class MPContent : EntityTypeConfiguration<ETContent>
    {
        public MPContent()
        {
            ToTable("ADM_TCC_MENU_TYPE");

            Property(e => e.IdMenuItem)
                .HasPrecision(18, 0)
                .IsRequired()
                .HasColumnName("ID_MENU_ITEM_N");

            Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME_C");

            Property(e => e.Text)
                .IsRequired()
                .HasColumnName("TEXT_N");
        }
    }
}
