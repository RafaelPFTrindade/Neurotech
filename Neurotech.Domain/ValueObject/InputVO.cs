using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Domain
{
    public class InputVO
    {
        public string Id { get; set; }

        public string Policy { get; set; }

        public string Version { get; set; }

        public string ResultingVariable { get; set; }

        public InputValueVO[] Inputs { get; set; }
    }
}
