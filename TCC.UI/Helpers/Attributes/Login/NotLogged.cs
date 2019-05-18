using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Public.Security;

namespace TCC.UI.Helpers.Attributes.Login
{
    /// <summary>
    /// Permissão para não logados.
    /// </summary>
    public class NotLogged : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = BLUser<ETUserPublic>.GetLogged();

            if (user != null)
            {
                filterContext.Result = new RedirectResult(HelpersMethods.GetLastUrl());
            }
        }
    }
}