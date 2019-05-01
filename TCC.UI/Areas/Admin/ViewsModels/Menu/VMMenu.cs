using System.ComponentModel.DataAnnotations;

namespace TCC.UI.Areas.Admin.ViewsModels.Menu
{
    public class VMMenu
    {
        public decimal Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O Limite é de {1} caracteres")]
        [Display(Name = "Título")]
        public string Title { get; set; }
    }
}