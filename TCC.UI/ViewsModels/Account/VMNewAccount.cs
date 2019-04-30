using System.ComponentModel.DataAnnotations;

namespace TCC.UI.ViewsModels.Account
{
    public class VMNewAccount
    {
        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(50, ErrorMessage = "Limite de caracteres é de {1} caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [EmailAddress(ErrorMessage = "Endereço de e-mail inválido.")]
        [Display(Name = "E-mail")]
        [System.Web.Mvc.Remote("IsValid", "Login", HttpMethod = "POST", ErrorMessage = "Endereço de e-mail já existente.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(30, ErrorMessage = "Limite de é de {2} até {1} caracteres", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "As senhas não coincidem")]
        [Display(Name = "Confirmação da senha")]
        public string ConfirmPassword { get; set; }
    }
}