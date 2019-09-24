using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardLineBDD : MPCardLine<ETCardLineBDD>
    {
        public MPCardLineBDD()
        {
            ToTable("PUB_TCC_CARD_LINE_BDD");

            Property(e => e.IdCard)
                .IsRequired()
                .HasColumnName("ID_CARD_BDD_N");

            HasRequired(e => e.Card)
                .WithMany(e => e.CardLines)
                .HasForeignKey(e => e.IdCard);
        }
    }
}
