using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUmbler.Shared
{
    public class Domain
    {
            public string Name { get; set; }
            public string Ip { get; set; }
            public string WhoIs { get; set; }
            public string HostedAt { get; set; }
    }

    public class DomainValidation
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Preencha um dominio.")]
        [RegularExpression(".*\\.com", ErrorMessage = "Preencha um dominio valido.")]
        public string? Name { get; set; }
    }
}
