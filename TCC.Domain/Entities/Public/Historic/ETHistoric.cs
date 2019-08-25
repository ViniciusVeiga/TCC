using System.Collections.Generic;

namespace TCC.Domain.Entities
{
    #region Histórico

    public class ETHistoric : ETBase
    {
        public decimal? IdUserPublic { get; set; }
        public decimal? IdProject { get; set; }

        //public virtual ETProject Project { get; set; }
        //public virtual List<ETCardActor> CardActors { get; set; }
        //public virtual List<ETCardUserStory> CardUserStorys { get; set; }
        //public virtual List<ETCardBDD> CardBDDs { get; set; }
    }

    #endregion

    #region Histórico 0

    public class ETHistoric_0 : ETHistoric
    {
        //public override List<ETCardActor> CardActors { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        //public override List<ETCardUserStory> CardUserStorys { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        //public override List<ETCardBDD> CardBDDs { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

    #endregion

    #region Histórico 1

    public class ETHistoric_1 : ETHistoric
    {
        //public override List<ETCardUserStory> CardUserStorys { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        //public override List<ETCardBDD> CardBDDs { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

    #endregion

    #region Histórico 2

    public class ETHistoric_2 : ETHistoric
    {
        //public override List<ETCardBDD> CardBDDs { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

    #endregion
}
