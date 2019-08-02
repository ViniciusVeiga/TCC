using System;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities.Public
{
    public class ETUserPublicMenuItem : ETBase, IUserPublicMenuItem
    {
        public ETUserPublicMenuItem() { }

        public ETUserPublicMenuItem(decimal? idUserPublic, decimal? idMenuItem)
        {
            IdUserPublic = idUserPublic;
            IdMenuItem = idMenuItem;
        }

        public decimal? IdUserPublic { get; set; }
        public decimal? IdMenuItem { get; set; }
    }
}
