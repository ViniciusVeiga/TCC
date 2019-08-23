using System.Collections.Generic;

namespace TCC.Domain.Entities
{
    public class Historic : ETBase
    {
        public decimal? IdUserPublic { get; set; }
        public decimal? IdProject { get; set; }
    }

    #region Histórico Completo

    public class HistoricComplete : Historic
    {
        public virtual ETProject Project { get; set; }
        public virtual List<ETCardActor> CardActors { get; set; }
        public virtual List<ETCardUserStory> CardUserStorys { get; set; }
        public virtual List<ETCardBDD> CardBDDs { get; set; }
    }

    #endregion

    #region Histórico 0

    public class Historic_0 : Historic
    {
        public virtual ETProject Project { get; set; }
    }

    #endregion

    #region Histórico 1

    public class Historic_1 : Historic
    {
        public virtual ETProject Project { get; set; }
        public virtual List<ETCardActor> CardActors { get; set; }
    }

    #endregion

    #region Histórico 2

    public class Historic_2 : Historic
    {
        public virtual ETProject Project { get; set; }
        public virtual List<ETCardActor> CardActors { get; set; }
        public virtual List<ETCardUserStory> CardUserStorys { get; set; }
    }

    #endregion

    #region Histórico 3

    public class Historic_3 : Historic
    {
        public virtual ETProject Project { get; set; }
        public virtual List<ETCardUserStory> CardUserStorys { get; set; }
        public virtual List<ETCardActor> CardActors { get; set; }
    }

    #endregion
}
