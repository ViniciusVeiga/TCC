using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Domain.Interfaces
{
    public interface IUserPublicMenuItem
    {
        decimal? IdUserPublic { get; set; }
        decimal? IdMenuItem { get; set; }
    }
}
