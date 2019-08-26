using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardActor : MPCard<ETCardActor>
    {
        public MPCardActor()
        {
            ToTable("PUB_TCC_CARD_ACTOR");

            HasRequired(e => e.Historic)
                .WithMany(e => e.CardActors)
                .HasForeignKey(e => e.IdHistoric);
        }
    }
}
