﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Domain.Entities;

namespace TCC.Domain.Interfaces
{
    public interface ICard
    {
        decimal? IdHistoric { get; set; }
    }
}
