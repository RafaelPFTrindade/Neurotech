using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Neurotech.Domain
{
    public class InputValueVO
    {
        public InputValueVO(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [Required]
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
