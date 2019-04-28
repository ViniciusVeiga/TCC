using System.ComponentModel.DataAnnotations;

namespace TCC.UI.ViewsModels.Account
{
    public class VMLogin
    {
        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}