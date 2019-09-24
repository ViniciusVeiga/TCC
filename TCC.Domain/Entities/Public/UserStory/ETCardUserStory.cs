using System.Collections.Generic;

namespace TCC.Domain.Entities
{
    public class ETCardUserStory : ETCard
    {
        public virtual List<ETCardLineUserStory> CardLines { get; set; }
    }
}
