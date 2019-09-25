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
        public new static CRUDHistoric Instance => new CRUDHistoric();

        public CRUDHistoric() : base()
        {
            _ctx.Configuration.LazyLoadingEnabled = false;
        }

        public override ETHistoric Find(Expression<Func<ETHistoric, bool>> predicate)
        {
            return Entities
                .Include(i => i.Project)
                .Include(i => i.CardActors.Select(o => o.CardLines))
                .Include(i => i.CardUserStories.Select(o => o.CardLines))
                .Include(i => i.CardBDDs.Select(o => o.CardLines))
                .FirstOrDefault(predicate);
        }

        public override List<ETHistoric> FindAll(Expression<Func<ETHistoric, bool>> predicate)
        {
             return Entities.Where(predicate).ToList();
        }
    }
}
