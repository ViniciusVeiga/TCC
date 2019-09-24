
namespace TCC.Domain.Entities
{
    public class ETCardLineUserStory : ETCardLine
    {
        public virtual ETCardUserStory Card { get; set; }
    }
}
