using MediatR;
using NetDevPack.Messaging;
using Neurotech.Domain.Models;
using Neurotech.Domain.Results;

namespace Neurotech.Domain.Commands
{
    public class SyncRegisterCommand : Command
    {
        public SyncRegisterCommand(InputVO submit, PropertiesVO[] properties)
        {
            Submit = submit;
            Properties = properties;
        }

        public AuthenticationVO Authentication { get; set; }

        public InputVO Submit { get; set; }

        public PropertiesVO[] Properties { get; set; }
    }
}
