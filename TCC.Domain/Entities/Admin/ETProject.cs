using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETProject : ETBase, IProject
    {
        public decimal? IdUserPublic { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public virtual bool Selected { get; set; }
        public virtual bool IsBaseProject() => IdUserPublic == null;
    }
}
