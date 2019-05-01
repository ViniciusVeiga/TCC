using System.ComponentModel.DataAnnotations;

namespace TCC.UI.Areas.Admin.ViewsModels.Menu
{
    public class VMMenuItem
    {
        public decimal Id { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(100, ErrorMessage = "O Limite é de {1} caracteres")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(250, ErrorMessage = "O Limite é de {1} caracteres")]
        [Display(Name = "Url")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [Display(Name = "Ordem")]
        public decimal Order { get; set; }
    }
}