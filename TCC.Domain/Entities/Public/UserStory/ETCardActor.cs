using System.Collections.Generic;

namespace TCC.Domain.Entities
{
    public class ETCardActor : ETCard
    {
        public virtual List<ETCardLineActor> CardLines { get; set; }
    }
}
