
namespace TCC.Domain.Entities
{
    public class ETCardLineActor : ETCardLine
    {
        public virtual ETCardActor Card { get; set; }
    }
}
