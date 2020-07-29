using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Domain
{
    public class InputVO
    {
        public InputVO(int id, string policy, string version, string resultingVariable, InputValueVO[] inputs)
        {
            Id = id;
            Policy = policy;
            Version = version;
            ResultingVariable = resultingVariable;
            Inputs = inputs;
        }

        public int Id { get; set; }

        public string Policy { get; set; }

        public string Version { get; set; }

        public string ResultingVariable { get; set; }

        public InputValueVO[] Inputs { get; set; }
    }
}
