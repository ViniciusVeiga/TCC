using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using TCC.Domain.Entities;
using TCC.Domain.Interfaces.Repositories;

namespace TCC.Entity.Repositories
{
    public class RBase<T> : IRBase<T> where T : ETBase
    {
        private readonly DbContext _ctx;
        private IDbSet<T> _entities;
        private string _errorMessage = string.Empty;

        public RBase(DbContext ctx) => _ctx = ctx;

        public IEnumerable<T> All => Entities.ToList();

        public IEnumerable<T> Actives => Entities.Where(e => e.Active).ToList();

        public T Find(int id) => Entities.Find(id);

        public T FindActive(int id) => Entities.First(e => e.Active && e.Id == id);

        public IEnumerable<T> Find(Func<T, bool> predicate) => Entities.Where(predicate);

        public void Add(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                entity.AddedDate = DateTime.Now;
                Entities.Add(entity);
                _ctx.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                dbEx.EntityValidationErrors.ToList().ForEach(eve => eve.ValidationErrors.ToList()
                    .ForEach(vr => _errorMessage += $"Property: {vr.PropertyName} Error: {vr.ErrorMessage}" + Environment.NewLine));

                throw new Exception(_errorMessage, dbEx);
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                _ctx.Set<T>().Attach(entity);
                _ctx.Entry(entity).State = EntityState.Modified;
                entity.ModifiedDate = DateTime.Now;
                _ctx.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                dbEx.EntityValidationErrors.ToList().ForEach(eve => eve.ValidationErrors.ToList()
                    .ForEach(vr => _errorMessage += $"Property: {vr.PropertyName} Error: {vr.ErrorMessage}" + Environment.NewLine));

                throw new Exception(_errorMessage, dbEx);
            }
        }

        public void DeleteLogical(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                entity.Active = false;
                _ctx.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                dbEx.EntityValidationErrors.ToList().ForEach(eve => eve.ValidationErrors.ToList()
                    .ForEach(vr => _errorMessage += $"Property: {vr.PropertyName} Error: {vr.ErrorMessage}" + Environment.NewLine));

                throw new Exception(_errorMessage, dbEx);
            }
        }

        public void DeletePhysical(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                Entities.Remove(entity);
                _ctx.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                dbEx.EntityValidationErrors.ToList().ForEach(eve => eve.ValidationErrors.ToList()
                        .ForEach(vr => _errorMessage += $"Property: {vr.PropertyName} Error: {vr.ErrorMessage}" + Environment.NewLine));

                throw new Exception(_errorMessage, dbEx);
            }
        }

        public void Dispose() => _ctx.Dispose();

        public virtual IQueryable<T> Table => Entities;

        private IDbSet<T> Entities => _entities ?? (_entities = _ctx.Set<T>());
    }
}
