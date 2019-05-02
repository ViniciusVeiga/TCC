using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC.UI.Areas.Admin.ViewsModels.Menu
{
    public class VMMenuType
    {
        public decimal? Id { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(100, ErrorMessage = "Limite de caracteres é de {1} caracteres.")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [Display(Name = "Ordem")]
        public decimal Order { get; set; }

        [Display(Name = "Icone")]
        public string Icon { get; set; }
    }
}