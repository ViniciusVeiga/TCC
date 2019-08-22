using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public class ETCard : ETBase, ICard
    {
        public decimal? IdUserPublic { get; set; }

        public virtual List<ETCardLine> CardLines { get; set; }
    }
}
