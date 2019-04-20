using System;
using System.Collections.Generic;
using TCC.Domain.Interfaces.Entities;

namespace TCC.Domain.Interfaces.Repositories
{
    public interface IRBase<T> : IDisposable where T : IBase
    {
        IEnumerable<T> All { get; }
        IEnumerable<T> Actives { get; }
        T Find(int id);
        T FindActive(int id);
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Add(T entity);
        void Update(T entity);
        void DeleteLogical(T entity);
        void DeletePhysical(T entity);
    }
}
