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

            Property(e => e.IdCardUserStory)
                .IsRequired()
                .HasColumnName("ID_CARD_USER_STORY_N");

            HasRequired(e => e.Historic)
                .WithMany(e => e.CardBDDs)
                .HasForeignKey(e => e.IdHistoric)
                .WillCascadeOnDelete(false);

            HasRequired(e => e.CardUserStory)
                .WithMany(e => e.CardBDDs)
                .HasForeignKey(e => e.IdCardUserStory)
                .WillCascadeOnDelete(true);
        }
    }
}
