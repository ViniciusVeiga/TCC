using System;
using System.Collections.Generic;
using System.Web;
using TCC.Domain.Entities;
using TCC.Entity.Context;
using TCC.Entity.CRUD;

namespace TCC.Entity.Context
{
    public class DAOContext
    {
        #region Obter Contexto

        public static EFContext GetContext()
        {
            try
            {
                EFContext context = HttpContext.Current.Session["CONTEXT"] as EFContext;

                if (context == null)
                {
                    context = new EFContext();
                    HttpContext.Current.Session["CONTEXT"] = context;
                }

                return context;
            }
            catch (Exception)
            {
                EFContext context = new EFContext();
                HttpContext.Current.Session["CONTEXT"] = context;

                return context;
            }
        }

        #endregion
    }
}
