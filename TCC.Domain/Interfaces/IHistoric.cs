using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Domain.Entities;

namespace TCC.Domain.Interfaces
{
    public interface IHistoric
    {
        decimal? IdUserPublic { get; set; }
        decimal? IdProject { get; set; }

        ETProject Project { get; set; }
        List<ETCardActor> CardActors { get; set; }
        List<ETCardUserStory> CardUserStories { get; set; }
        List<ETCardBDD> CardBDDs { get; set; }
    }
}
