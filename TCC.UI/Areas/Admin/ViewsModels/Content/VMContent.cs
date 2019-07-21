using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TCC.UI.Areas.Admin.ViewsModels.Menu;

namespace TCC.UI.Areas.Admin.ViewsModels.Content
{
    public class VMContent
    {
        public decimal? Id { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [StringLength(100, ErrorMessage = "Limite de caracteres é de {1} caracteres.")]
        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [StringLength(100, ErrorMessage = "Limite de caracteres é de {1} caracteres.")]
        [Display(Name = "Url Tutorial Dinâmico")]
        public string UrlDynamicTutorial { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [Display(Name = "Texto do Conteúdo")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Preencha esse campo.")]
        [Display(Name = "Menu")]
        public decimal? IdMenuItem { get; set; }

        public VMMenuItem MenuItem { get; set; }
    }
}