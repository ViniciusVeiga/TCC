﻿using System;
using System.Data.Entity.ModelConfiguration;
using TCC.Domain.Entities;

namespace TCC.Entity.Maps
{
    public class MPCardBDD : MPCard<ETCardBDD>
    {
        public MPCardBDD()
        {
            ToTable("ADM_TCC_CARD_USER_STORY");
        }
    }
}
