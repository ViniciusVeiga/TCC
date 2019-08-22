using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETContent : ETBase, IContent
    {
        public string Title { get; set; }
        public string UrlDynamicTutorial { get; set; }
        public string Text { get; set; }
        public decimal? IdMenuItem { get; set; }
        public virtual ETMenuItem MenuItem { get; set; }
    }
}
