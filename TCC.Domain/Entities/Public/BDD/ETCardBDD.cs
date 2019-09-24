using System.Collections.Generic;

namespace TCC.Domain.Entities
{
    public class ETCardBDD : ETCard
    {
        public virtual List<ETCardLineBDD> CardLines { get; set; }
    }
}
