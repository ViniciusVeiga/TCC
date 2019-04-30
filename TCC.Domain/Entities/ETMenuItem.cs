using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETMenuItem : ETBase, IMenuItem
    {
        public decimal? IdMenu { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public decimal? Order { get; set; }
    }
}
