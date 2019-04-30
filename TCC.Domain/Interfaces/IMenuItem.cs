using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Domain.Interfaces
{
    public interface IMenuItem
    {
        string Title { get; set; }
        string Url { get; set; }
        decimal? Order { get; set; }
    }
}
