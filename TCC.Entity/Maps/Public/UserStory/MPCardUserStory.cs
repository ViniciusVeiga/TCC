using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardUserStory : MPCard<ETCardUserStory>
    {
        public MPCardUserStory()
        {
            ToTable("PUB_TCC_CARD_USER_STORY");

            Property(e => e.IdCardActor)
                .IsRequired()
                .HasColumnName("ID_CARD_ACTOR_N");

            HasRequired(e => e.Historic)
                .WithMany(e => e.CardUserStories)
                .HasForeignKey(e => e.IdHistoric);
        }
    }
}
