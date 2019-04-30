using System.ComponentModel.DataAnnotations;

namespace TCC.UI.Areas.Admin.ViewsModels.Menu
{
    public class VMMenuItem
    {
        [Required]
        [StringLength(100, ErrorMessage = "O Limite é de {1} caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O Limite é de {1} caracteres")]
        [Display(Name = "Url")]
        public string Url { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "A {0} deve ter entre {2} e {1} caracteres", MinimumLength = 8)]
        [Display(Name = "Ordem")]
        public string Order { get; set; }
    }
}