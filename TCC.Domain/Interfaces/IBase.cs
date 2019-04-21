using System;

namespace TCC.Domain.Interfaces
{
    public interface IBase
    {
        decimal? Id { get; set; }
        DateTime AddedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        bool Active { get; set; }
    }
}
