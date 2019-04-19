using System;

namespace TCC.Domain.Entities
{
    public abstract class ETBase
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public bool Active { get; set; } = true;
    }
}
