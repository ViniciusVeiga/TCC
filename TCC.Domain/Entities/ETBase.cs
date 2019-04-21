using System;
using TCC.Domain.Interfaces;

namespace TCC.Domain.Entities
{
    public abstract class ETBase : IBase
    {
        public decimal? Id { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public bool Active { get; set; } = true;
    }
}
