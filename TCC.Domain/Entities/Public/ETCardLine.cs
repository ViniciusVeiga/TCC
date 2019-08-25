using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETCardLine : ETBase, ICardLine
    {
        public decimal? IdCard { get; set; }
        public string Line { get; set; }
        public int Order { get; set; }
    }
}
