using System.Collections.Generic;
using System.Linq;
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
        public string Key { get; set; }

        public virtual List<decimal?> IdParents
        {
            get
            {
                try
                {
                    return Parents.Select(x => x.IdMenuParent).ToList();
                }
                catch { return null; }
            }
        }

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
