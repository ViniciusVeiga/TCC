using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardLineActor : MPCardLine<ETCardLineActor>
    {
        public MPCardLineActor()
        {
            ToTable("PUB_TCC_CARD_LINE_ACTOR");
        }
    }
}
