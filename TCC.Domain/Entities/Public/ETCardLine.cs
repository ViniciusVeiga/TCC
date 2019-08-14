using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities.Public
{
    public class ETCardLine : ETBase, ICardLine
    {
        public decimal? IdCard { get; set; }
        public string Line { get; set; }
    }
}
