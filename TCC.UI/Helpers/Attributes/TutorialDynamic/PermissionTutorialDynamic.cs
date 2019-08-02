﻿using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using TCC.BusinessLayer.Public;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Admin;
using TCC.Domain.Entities.Public.Security;

namespace TCC.UI.Helpers.Attributes.TutorialDynamic
{
    public class PermissionTutorialDynamic : ActionFilterAttribute
    {
        public string Key { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var nopermission = BLUserPublicMenuItem.HasPermissionOfTutorialDynamic(Key, out List<ETMenuItem> remainingParents);

            if (nopermission == true)
            {
                var values = new RouteValueDictionary(new
                {
                    action = "Index",
                    controller = "PermissionTutorialDynamic",
                    remainingParents
                });

                filterContext.Result = new RedirectToRouteResult(values);
            }
        }
    }
}