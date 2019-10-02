using System;
using System.Web.Mvc;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Attributes.TutorialDynamic;
using TCC.UI.Helpers.Toastrs;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.Extensions
{
    public interface ITutorialDynamicBaseController : IController
    {
        ActionResult Index();
        ActionResult Page_Final();
        ActionResult NextTutorial();
        ActionResult Export();
    }
}