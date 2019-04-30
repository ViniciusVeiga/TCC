using System;
using System.Collections.Generic;

namespace TCC.UI.Helpers.Toastrs
{
    [Serializable]
    public class Toastr
    {
        public bool ShowNewestOnTop { get; set; }
        public bool ShowCloseButton { get; set; }
        public string PositionClass { get; set; }

        public List<ToastrMessage> ToastMessages { get; set; }

        public ToastrMessage AddToastMessage(string title, string message, ToastrType toastType, string toastPositionClass = "toast-bottom-right")
        {
            var toast = new ToastrMessage()
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
            ToastMessages = new List<ToastrMessage>();
            ShowNewestOnTop = false;
            ShowCloseButton = false;
            PositionClass = "toast-bottom-right";
        }
    }
}