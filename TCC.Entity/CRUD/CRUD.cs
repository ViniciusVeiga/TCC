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
    public static class CRUD<T> where T : ETBase
    {
        private static readonly DbContext _ctx = new EFContext();
        private static IDbSet<T> _entities;
        private static string _errorMessage = string.Empty;

        public static List<T> All => Entities.ToList();

        public static List<T> Actives => Entities.Where(e => e.Active).ToList();

        public static T Find(int id) => Entities.Find(id);

        public static T FindActive(int id) => Entities.First(e => e.Active && e.Id == id);

        public static T Find(Expression<Func<T, bool>> predicate) => Entities.Find(predicate);

        public static List<T> List(Expression<Func<T, bool>> predicate) => Entities.Where(predicate).ToList();

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

        public static void Update(T entity)
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

        public static void Dispose() => _ctx.Dispose();

        //public static virtual IQueryable<T> Table => Entities;

        private static IDbSet<T> Entities => _entities ?? (_entities = _ctx.Set<T>());
    }
}
