using TCC.Domain.Entities;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Admin.Entities
{
    public class ETMenuItem : ETBase, IMenuItem
    {
        public decimal? IdMenu { get; set; }
        public decimal? IdMenuType { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public decimal? Order { get; set; }
        public string Icon { get; set; }
    }
}
