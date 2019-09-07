using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardLineUserStory : MPCardLine<ETCardLineUserStory>
    {
        public MPCardLineUserStory()
        {
            ToTable("PUB_TCC_CARD_LINE_USER_STORY");
        }
    }
}
