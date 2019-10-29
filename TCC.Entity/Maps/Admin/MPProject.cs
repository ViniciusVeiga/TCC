using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPProject : EntityTypeConfiguration<ETProject>
    {
        public MPProject()
        {
            ToTable("ADM_TCC_PROJECT");

            Property(e => e.IdUserPublic)
                .HasColumnName("ID_USER_PUBLIC_N");

            Property(e => e.Title)
                .IsRequired()
                .HasColumnName("TITLE_C");

            Property(e => e.Text)
                .HasMaxLength(250)
                .IsRequired()
                .HasColumnName("TEXT_C");

            Ignore(e => e.Selected);
        }
    }
}
