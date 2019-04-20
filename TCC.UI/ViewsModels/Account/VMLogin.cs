using System.ComponentModel.DataAnnotations;
using TCC.Domain.Interfaces.Entities;

namespace TCC.UI.ViewsModels.Account
{
    public class VMLogin : IUser
    {
        public string Name { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "{0} inválido")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembrar-me?")]
        public bool RememberMe { get; set; }
    }
}