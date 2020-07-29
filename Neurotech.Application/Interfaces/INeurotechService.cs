using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Neurotech.Application.Interfaces
{
    public interface INeurotechService : IDisposable
    {
        Task<RegisterViewModel> Submit(RegisterViewModel )
    }
}
