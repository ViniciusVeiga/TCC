using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities.Admin;

namespace TCC.Entity.Maps
{
    public class MPContent : EntityTypeConfiguration<ETContent>
    {
        public MPContent()
        {
            ToTable("ADM_TCC_CONTENT");

            Property(e => e.IdMenuItem)
                .HasPrecision(18, 0)
                .IsRequired()
                .HasColumnName("ID_MENU_ITEM_N");

            Property(e => e.Title)
                .IsRequired()
                .HasColumnName("TITLE_C");

            Property(e => e.UrlDynamicTutorial)
                .HasColumnName("URL_DYNAMIC_TUTORIAL_C");

            Property(e => e.Text)
                .HasMaxLength(Int32.MaxValue)
                .IsRequired()
                .HasColumnName("TEXT_C");

            HasRequired(m => m.MenuItem)
                .WithMany()
                .HasForeignKey(c => c.IdMenuItem);
        }
    }
}
