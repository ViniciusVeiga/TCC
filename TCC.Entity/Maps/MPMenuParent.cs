﻿using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities.Admin;

namespace TCC.Entity.Maps
{
    public class MPMenuParent : EntityTypeConfiguration<ETMenuParent>
    {
        public MPMenuParent()
        {
            ToTable("ADM_TCC_MENU_PARENT");

            Property(e => e.IdMenuItem)
                .HasPrecision(18, 0)
                .IsRequired()
                .HasColumnName("ID_MENU_ITEM_N");

            Property(e => e.IdMenuParent)
                .HasPrecision(18, 0)
                .IsRequired()
                .HasColumnName("ID_MENU_PARENT_N");

            HasRequired(e => e.MenuItem)
                .WithMany(e => e.Parents)
                .HasForeignKey(e => e.IdMenuItem);
        }
    }
}