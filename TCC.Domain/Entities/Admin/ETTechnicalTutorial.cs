using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities.Admin
{
    public class ETTechnicalTutorial : ETBase, ITechnicalTutorial
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public decimal? IdContent { get; set; }
        public virtual ETContent Content { get; set; }
    }
}
