using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Neurotech.Application.ViewModels
{
    public class InputValueViewModel
    {
        [Required]
        public string NmParametro { get; set; }

        public string VlParametro { get; set; }
    }
}
