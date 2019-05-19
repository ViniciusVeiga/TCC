using System.ComponentModel.DataAnnotations;

namespace TCC.UI.ViewsModels.Account
{
    public class VMLogin
    {
        [Required(ErrorMessage = "Preencha esse campo.")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Endereço de e-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembrar-me?")]
        public bool RememberMe { get; set; }
    }
}