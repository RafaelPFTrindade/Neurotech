using FluentValidation.Results;
using MediatR;
using NetDevPack.Messaging;
using Neurotech.Domain.Models;
using Neurotech.Domain.Results;

namespace Neurotech.Domain.Commands
{
    public class SyncRegisterCommand : IRequest<ValidationResult>
    {
        public SyncRegisterCommand(InputVO submit)
        {
            Submit = submit;
        }

        public AuthenticationVO Authentication { get; set; }

        public InputVO Submit { get; set; }

        public PropertiesVO[] Properties { get; set; }
    }
}
