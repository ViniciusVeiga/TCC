using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using TCC.Domain.Entities;
using TCC.Entity.Context;

namespace TCC.Entity.CRUD
{
    public class CRUDHistoric : CRUD<ETHistoric>
    {
        private static readonly DbContext _ctx = DAOContext.GetContext();
        private static IDbSet<ETHistoric> Entities => _ctx.Set<ETHistoric>();

        public new static ETHistoric Find(Expression<Func<ETHistoric, bool>> predicate)
        {
            _ctx.Configuration.LazyLoadingEnabled = false;

            return Entities
                .Include(i => i.Project)
                .Include(i => i.CardActors.Select(o => o.CardLines))
                .Include(i => i.CardUserStorys.Select(o => o.CardLines))
                .Include(i => i.CardBDDs.Select(o => o.CardLines))
                .FirstOrDefault(predicate);
        }

        public new static List<ETHistoric> FindAll(Expression<Func<ETHistoric, bool>> predicate)
        {
            _ctx.Configuration.LazyLoadingEnabled = false;

            return Entities.Where(predicate).ToList();
        }
    }
}
