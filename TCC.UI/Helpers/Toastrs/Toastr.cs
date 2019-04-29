using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.UI.Helpers.Toastrs
{
    [Serializable]
    public class Toastr
    {
        public bool ShowNewestOnTop { get; set; }
        public bool ShowCloseButton { get; set; }
        public string PositionClass { get; set; }

        public List<ToastMessage> ToastMessages { get; set; }

        public ToastMessage AddToastMessage(string title, string message, ToastType toastType, string toastPositionClass = "toast-bottom-right")
        {
            var toast = new ToastMessage()
            {
                Title = title,
                Message = message,
                ToastType = toastType
            };
            ToastMessages.Add(toast);
            return toast;
        }

        public Toastr()
        {
            ToastMessages = new List<ToastMessage>();
            ShowNewestOnTop = false;
            ShowCloseButton = false;
            PositionClass = "toast-bottom-right";
        }
    }
}