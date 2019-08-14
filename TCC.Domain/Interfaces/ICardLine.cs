using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Domain.Interfaces
{
    public interface ICardLine
    {
        decimal? IdCard { get; set; }
        string Line { get; set; }
    }
}
