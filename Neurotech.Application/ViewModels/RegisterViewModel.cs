using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.ViewModels
{
    public class RegisterViewModel
    {
        public AuthenticationViewModel Authentication { get; set; }

        public InputsViewModel Inputs { get; set; }

        public PropertiesViewModel[] Properties { get; set; }
    }
}
