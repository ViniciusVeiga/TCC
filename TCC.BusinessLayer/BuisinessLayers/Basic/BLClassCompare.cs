using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using TCC.Domain.Entities;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLClassCompare<T> : IEqualityComparer<T> where T : ETBase
    {
        public bool Equals(T t1, T t2)
        {
            try
            {
                if (t1.Id == null)
                    return false;

                if (t2.Id == null)
                    return false;

                if (t1.Id == t2.Id)
                    return true;
            }
            catch { }

            return false;
        }

        public int GetHashCode(T obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
