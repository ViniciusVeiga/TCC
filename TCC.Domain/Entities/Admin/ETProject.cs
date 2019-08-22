using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETProject : ETBase, IProject
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
