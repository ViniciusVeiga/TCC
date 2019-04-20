using System.Data.Entity;
using TCC.Domain.Entities.Security;
using TCC.Domain.Interfaces.Repositories;

namespace TCC.Entity.Repositories
{
    public class RUser : RBase<ETUser>, IRUser
    {
        public RUser(DbContext ctx) : base(ctx) { }
    }
}
