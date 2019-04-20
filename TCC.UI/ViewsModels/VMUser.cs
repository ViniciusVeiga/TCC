using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TCC.Domain.Interfaces;

namespace TCC.UI.ViewsModels
{
    public class VMUser
    {
        public class VMNewAccount : IUser
        {
            [Required, DisplayName("Nome")]
            public string Name { get; set; }

            [Required, DisplayName("Email")]
            public string Email { get; set; }

            [Required, DisplayName("Senha")]
            public string Password { get; set; }

            [Required, DisplayName("Confimar Senha")]
            public string ConfirmPassword { get; set; }
        }
    }
}