using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCC.Domain.Entities
{
    public class ETHistoricPlus
    {
        public string Page { get; set; }
        public ETHistoric Historic { get; set; }
        public List<ETProject> UserProjects { get; set; }
    }
}
