using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities.Admin
{
    public class ETMenuItem : ETBase, IMenuItem
    {
        public decimal? IdMenu { get; set; }
        public decimal? IdMenuType { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public decimal? Order { get; set; }
        public string Icon { get; set; }
        public virtual List<decimal?> IdParents { get; set; }
        public virtual List<ETMenuParent> Parents { get; set; }
    }

    public class ETMenuParent : ETBase
    {
        public ETMenuParent() { }

        public ETMenuParent(decimal? idMenuItem, decimal? idMenuParent)
        {
            IdMenuItem = idMenuItem;
            IdMenuParent = idMenuParent;
        }

        public decimal? IdMenuItem { get; set; }
        public decimal? IdMenuParent { get; set; }

        public virtual ETMenuItem MenuItem { get; set; }
    }
}
