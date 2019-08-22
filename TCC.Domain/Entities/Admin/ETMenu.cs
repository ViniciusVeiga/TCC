using TCC.Domain.Entities;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETMenu : ETBase, IMenu
    {
        public string Title { get; set; }
    }
}
