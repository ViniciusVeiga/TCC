using System.ComponentModel.DataAnnotations;

namespace TCC.UI.Areas.Admin.ViewsModels.Project
{
    public class VMProject
    {
        public decimal? Id { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(100, ErrorMessage = "Limite de caracteres é de {1} caracteres.")]
        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [Display(Name = "Conteudo do Projeto")]
        public string Text { get; set; }
    }
}