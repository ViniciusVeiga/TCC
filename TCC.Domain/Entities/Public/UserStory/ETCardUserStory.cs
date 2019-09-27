using System.Collections.Generic;

namespace TCC.Domain.Entities
{
    public class ETCardUserStory : ETCard
    {
        public decimal? IdCardActor { get; set; }

        public virtual ETCardActor CardActor { get; set; }
        public virtual List<ETCardLineUserStory> CardLines { get; set; }
    }
}
