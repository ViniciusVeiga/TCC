using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPMenu : EntityTypeConfiguration<ETMenu>
    {
        public MPMenu()
        {
            ToTable("ADM_TCC_MENU");

            Property(e => e.Title)
                .IsRequired()
                .HasColumnName("TITLE_C");
        }
    }
}
