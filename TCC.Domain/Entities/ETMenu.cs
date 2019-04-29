using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETMenu : ETBase, IMenu
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public decimal? Order { get; set; }
    }
}
