using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC.UI.Areas.Admin.ViewsModels.Content
{
    public class VMContent
    {
        public decimal? Id { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(100, ErrorMessage = "Limite de caracteres é de {1} caracteres.")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [Display(Name = "Texto do Conteúdo")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [Display(Name = "Menu")]
        public string IdMenuItem { get; set; }
    }
}