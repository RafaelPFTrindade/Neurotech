using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Neurotech.Application.ViewModels
{
    public class RegisterViewModel
    {
        [Key]
        public string IdProposta { get; set; }

        [Required]
        public string NmPolitica { get; set; }

        public string TagVersaoPolitica { get; set; }

        public string NmFluxoResultado { get; set; }

        public InputValueViewModel[] LsParametros { get; set; }
    }
}
