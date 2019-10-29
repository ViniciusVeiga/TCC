using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Domain.Interfaces
{
    public interface IProject
    {
        decimal? IdUserPublic { get; set; }
        string Title { get; set; }
        string Text { get; set; }
    }
}
