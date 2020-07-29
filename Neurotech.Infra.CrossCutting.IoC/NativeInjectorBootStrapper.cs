using Microsoft.Extensions.DependencyInjection;
using NetDevPack.Mediator;
using Neurotech.Application.Interfaces;
using Neurotech.Application.Services;
using Neurotech.Infra.CrossCutting.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            // Application
            services.AddScoped<INeurotechService, NeurotechService>();
        }
    }
}
