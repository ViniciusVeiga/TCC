using System.Collections.Generic;

namespace TCC.Domain.Entities
{
    public class ETCardBDD : ETCard
    {
        public decimal? IdCardUserStory { get; set; }

        public virtual ETCardUserStory CardUserStory { get; set; }
        public virtual List<ETCardLineBDD> CardLines { get; set; }
    }
}
