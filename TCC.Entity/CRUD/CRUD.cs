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
    public class CRUD<T> where T : ETBase
    {
        protected readonly DbContext _ctx;
        protected IDbSet<T> Entities => _ctx.Set<T>();
        protected static string _errorMessage = string.Empty;

        public static CRUD<T> Instance => new CRUD<T>();

        public CRUD()
        {
            _ctx = DAOContext.GetContext();
            _ctx.Configuration.LazyLoadingEnabled = true;
        }

        #region Methods

        public virtual List<T> All() => Entities.ToList();

        public virtual List<T> Actives() => Entities.Where(e => e.Active).ToList();

        public virtual T Find(decimal id) => Entities.Find(id);

        public virtual T FindActive(decimal id) => Entities.First(e => e.Active && e.Id == id);

        public virtual T Find(Expression<Func<T, bool>> predicate) => Entities.FirstOrDefault(predicate);

        public virtual List<T> FindAll(Expression<Func<T, bool>> predicate) => Entities.Where(predicate).ToList();

        public virtual void Add(T entity)
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

        public virtual void AddOrUpdate(List<T> entities)
        {
            foreach (var entity in entities)
            {
                AddOrUpdate(entity);
            }
        }

        public virtual void AddOrUpdate(T entity)
        {
            try
            {
                if (entity.Id.HasValue)
                {
                    Update(entity);
                }
                else
                    Add(entity);
            }
            catch (DbEntityValidationException dbEx)
            {
                dbEx.EntityValidationErrors.ToList().ForEach(eve => eve.ValidationErrors.ToList()
                    .ForEach(vr => _errorMessage += $"Property: {vr.PropertyName} Error: {vr.ErrorMessage}" + Environment.NewLine));

                throw new Exception(_errorMessage, dbEx);
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                T existing = _ctx.Set<T>().Find(entity.Id);
                _ctx.Entry(existing).CurrentValues.SetValues(entity);
                _ctx.Entry(existing).State = EntityState.Modified;
                existing.ModifiedDate = DateTime.Now;
                _ctx.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                dbEx.EntityValidationErrors.ToList().ForEach(eve => eve.ValidationErrors.ToList()
                    .ForEach(vr => _errorMessage += $"Property: {vr.PropertyName} Error: {vr.ErrorMessage}" + Environment.NewLine));

                throw new Exception(_errorMessage, dbEx);
            }
        }

        public virtual void DeleteLogical(T entity)
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

        public virtual void DeletePhysical(List<T> entities)
        {
            foreach (var entity in entities)
            {
                DeletePhysical(entity);
            }
        }

        public virtual void DeletePhysical(T entity)
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

        #endregion
    }
}
