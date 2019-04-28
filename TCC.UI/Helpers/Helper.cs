using System;
using System.Linq;
using System.Web;

namespace TCC.UI.Helpers
{
    public static class Helper
    {
        #region Mudando Classes

        /// <summary>
        ///  Copia os valores de uma model para outra, os nomes das propriedades devem ser iguais.
        /// </summary>
        public static T2 CopyValues<T, T2>(T modelOrigin)
        {
            T2 modelDestiny = (T2)Activator.CreateInstance(typeof(T2), new object[] { });

            var propOrigin = typeof(T).GetProperties();
            var propDestiny = typeof(T2).GetProperties();

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

        #endregion

        #region Última Url

        public static string GetLastUrl()
            => $"../{(HttpContext.Current.Request.UrlReferrer.Segments.Skip(1).Take(1).SingleOrDefault() ?? "Home").Trim('/')}/{(HttpContext.Current.Request.UrlReferrer.Segments.Skip(2).Take(1).SingleOrDefault() ?? "Index").Trim('/')}";

        #endregion
    }
}