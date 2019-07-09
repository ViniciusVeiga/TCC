using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.UI.Helpers
{
    public static class HelpersMethods
    {
        #region Mudando Classes

        /// <summary>
        ///  Copia os valores de uma model para outra, os nomes das propriedades devem ser iguais.
        /// </summary>
        public static Destiny CopyValues<Origin, Destiny>(Origin modelOrigin)
        {
            Destiny modelDestiny = (Destiny)Activator.CreateInstance(typeof(Destiny), new object[] { });

            var propOrigin = typeof(Origin).GetProperties();
            var propDestiny = typeof(Destiny).GetProperties();

            foreach (var item in propOrigin)
            {
                var foundDestiny = propDestiny.Where(p => p.Name == item.Name);
                try
                {
                    var enm = foundDestiny.GetEnumerator();
                    while (enm.MoveNext())
                    {
                        enm.Current?.SetValue(modelDestiny, item.GetValue(modelOrigin, null), null);
                    }

                    enm.Dispose();
                }
                catch { }
            }

            return modelDestiny;
        }

        public static List<Destiny> CopyValues<Origin, Destiny>(List<Origin> listOrigin)
        {
            var listDestiny = new List<Destiny>();

            foreach (var item in listOrigin)
            {
                var modelDestiny = CopyValues<Origin, Destiny>(item);
                listDestiny.Add(modelDestiny);
            }

            return listDestiny;
        }

        #endregion

        #region Última Url

        public static string GetLastUrl()
            => $"../{(HttpContext.Current.Request.UrlReferrer.Segments.Skip(1).Take(1).SingleOrDefault() ?? "Home").Trim('/')}/{(HttpContext.Current.Request.UrlReferrer.Segments.Skip(2).Take(1).SingleOrDefault() ?? "Index").Trim('/')}";

        #endregion
    }
}