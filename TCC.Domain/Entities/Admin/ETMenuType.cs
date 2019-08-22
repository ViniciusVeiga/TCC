using TCC.Domain.Entities;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETMenuType : ETBase, IMenuType
    {
        public decimal? IdMenu { get; set; }
        public string Title { get; set; }
        public decimal? Order { get; set; }
        public string Icon { get; set; }
    }
}
