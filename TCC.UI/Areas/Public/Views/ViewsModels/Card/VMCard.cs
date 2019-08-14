using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.UI.Areas.Public.Views.ViewsModels.UserStory
{
    public class VMCard
    {
        public decimal? IdUserPublic { get; set; }
        public decimal? IdMenuItem { get; set; }

        public List<VMCardLine> CardLines { get; set; }
    }
}