using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardBDD : MPCard<ETCardBDD>
    {
        public MPCardBDD()
        {
            ToTable("PUB_TCC_CARD_BDD");

            HasRequired(e => e.Historic)
                .WithMany(e => e.CardBDDs)
                .HasForeignKey(e => e.IdHistoric);
        }
    }
}
