using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TCC.Domain.Interfaces.Entities;

namespace TCC.UI.ViewsModels.Account
{
    public class VMNewAccount : IUser
    {
        [Required, DisplayName("Nome")]
        public string Name { get; set; }

        [Required, DisplayName("E-mail")]
        public string Email { get; set; }

        [Required, DisplayName("Senha")]
        public string Password { get; set; }

        [Required, DisplayName("Confimar Senha")]
        public string ConfirmPassword { get; set; }
    }
}