﻿using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities.Admin;

namespace TCC.Entity.Maps
{
    public class MPMenuType : EntityTypeConfiguration<ETMenuType>
    {
        public MPMenuType()
        {
            ToTable("ADM_TCC_MENU_TYPE");

            Property(e => e.IdMenu)
                .HasPrecision(18, 0)
                .IsRequired()
                .HasColumnName("ID_MENU_N");

            Property(e => e.Title)
                .IsRequired()
                .HasColumnName("TITLE_C");

            Property(e => e.Order)
                .IsRequired()
                .HasPrecision(18, 0)
                .HasColumnName("ORDER_N");

            Property(e => e.Icon)
                .HasMaxLength(50)
                .HasColumnName("ICON_C");
        }
    }
}
