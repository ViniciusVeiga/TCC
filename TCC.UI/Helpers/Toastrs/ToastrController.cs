using System.Web.Mvc;

namespace TCC.UI.Helpers.Toastrs
{
    public static class ToastrController
    {
        public static ToastrMessage AddToastMessage(this Controller controller, string title, string message, ToastrType toastType = ToastrType.Info)
        {
            var toastr = controller.TempData["Toastr"] as Toastr;
            toastr = toastr ?? new Toastr();

            var toastMessage = toastr.AddToastMessage(title, message, toastType);
            controller.TempData["Toastr"] = toastr;
            return toastMessage;
        }
    }
}