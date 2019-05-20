using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities.Admin;

namespace TCC.Entity.Maps
{
    public class MPTechnicalTutorial : EntityTypeConfiguration<ETTechnicalTutorial>
    {
        public MPTechnicalTutorial()
        {
            ToTable("ADM_TCC_TECHNICAL_TUTORIAL");

            Property(e => e.IdContent)
                .HasPrecision(18, 0)
                .IsRequired()
                .HasColumnName("ID_CONTENT_N");

            Property(e => e.Title)
                .IsRequired()
                .HasColumnName("TITLE_C");

            Property(e => e.Text)
                .HasMaxLength(Int32.MaxValue)
                .IsRequired()
                .HasColumnName("TEXT_C");

            HasRequired(m => m.Content)
                .WithMany()
                .HasForeignKey(c => c.IdContent);
        }
    }
}
