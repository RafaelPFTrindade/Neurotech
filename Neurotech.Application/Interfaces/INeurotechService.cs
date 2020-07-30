using Neurotech.Application.EventSourcedNomalizers;
using Neurotech.Application.ViewModels;
using Neurotech.Domain.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Neurotech.Application.Interfaces
{
    public interface INeurotechService : IDisposable
    {
        Task<Resultado> Submit(RegisterViewModel model);
    }
}
