using System;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities.Public
{
    public class ETUserPublicMenuItem : ETBase, IUserPublicMenuItem
    {
        public decimal? IdUserPublic { get; set; }
        public decimal? IdMenuItem { get; set; }
    }
}
