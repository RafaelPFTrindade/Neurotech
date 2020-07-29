using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Neurotech.Application.ViewModels
{
    public class InputsViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Policy { get; set; }

        public string Version { get; set; }

        public string ResultingVariable { get; set; }

        public InputValueViewModel[] Inputs { get; set; }
    }
}
