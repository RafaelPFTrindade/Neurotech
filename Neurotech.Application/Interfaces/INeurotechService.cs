using Neurotech.Application.EventSourcedNomalizers;
using Neurotech.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Neurotech.Application.Interfaces
{
    public interface INeurotechService : IDisposable
    {
        Task<RegisterResultData> Submit(RegisterViewModel model);
    }
}
