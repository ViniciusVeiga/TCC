using System;

namespace TCC.UI.Helpers.Toastrs
{
    [Serializable]
    public class ToastrMessage
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public ToastrType ToastType { get; set; }
        public bool IsSticky { get; set; }
    }
}