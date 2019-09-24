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
        private static readonly DbContext _ctx = DAOContext.GetContext();
        private static IDbSet<T> Entities => _ctx.Set<T>();
        private static string _errorMessage = string.Empty;

        public static List<T> All() => Entities.ToList();

        public static List<T> Actives() => Entities.Where(e => e.Active).ToList();

        public static T Find(decimal id) => Entities.Find(id);

        public static T FindActive(decimal id) => Entities.First(e => e.Active && e.Id == id);

        public static T Find(Expression<Func<T, bool>> predicate) => Entities.FirstOrDefault(predicate);

        public static List<T> FindAll(Expression<Func<T, bool>> predicate) => Entities.Where(predicate).ToList();

        public static void Add(T entity)
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

        public static void AddOrUpdate(List<T> entities)
        {
            foreach (var entity in entities)
            {
                AddOrUpdate(entity);
            }
        }

        public static void AddOrUpdate(T entity)
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

        public static void Update(T entity)
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

        public static void DeleteLogical(T entity)
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

        public static void DeletePhysical(List<T> entities)
        {
            foreach (var entity in entities)
            {
                DeletePhysical(entity);
            }
        }

        public static void DeletePhysical(T entity)
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
    }
}
