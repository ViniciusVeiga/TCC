using System.ComponentModel.DataAnnotations;

namespace TCC.UI.Areas.Admin.ViewsModels.Menu
{
    public class VMMenu
    {
        public decimal? Id { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(100, ErrorMessage = "Limite de caracteres é de {1} caracteres.")]
        [Display(Name = "Título")]
        public string Title { get; set; }
    }
}