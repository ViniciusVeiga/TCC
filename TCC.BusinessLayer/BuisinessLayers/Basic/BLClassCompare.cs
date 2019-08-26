using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using TCC.Domain.Entities;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLClassCompare<T> : IEqualityComparer<T> where T : ETBase
    {
        public bool Equals(T x, T y)
        {
            if (x == null)
                return y == null;
            else if (y == null)
                return false;
            else
                return x.Id == y.Id && x.Id == y.Id;
        }

        public int GetHashCode(T obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
