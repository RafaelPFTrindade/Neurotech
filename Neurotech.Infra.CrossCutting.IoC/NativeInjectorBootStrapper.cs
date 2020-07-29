using Microsoft.Extensions.DependencyInjection;
using Neurotech.Application.Interfaces;
using Neurotech.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<INeurotechService, NeurotechService>();
        }
    }
}
