using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardActor : MPCard<ETCardActor>
    {
        public MPCardActor()
        {
            ToTable("ADM_TCC_CARD_ACTOR");
        }
    }
}
