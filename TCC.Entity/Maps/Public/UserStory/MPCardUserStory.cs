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

            HasRequired(e => e.Historic)
                .WithMany(e => e.CardUserStories)
                .HasForeignKey(e => e.IdHistoric);
        }
    }
}
