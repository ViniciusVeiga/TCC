using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCC.Domain.Entities
{
    public class ETHistoric : ETBase
    {
        public decimal? IdUserPublic { get; set; }
        public decimal? IdProject { get; set; }

        public virtual ETProject Project { get; set; }
        public virtual List<ETCardActor> CardActors { get; set; }
        public virtual List<ETCardUserStory> CardUserStorys { get; set; }
        public virtual List<ETCardBDD> CardBDDs { get; set; }
    }
}
