using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDevPack.Mediator;
using Neurotech.Application.Interfaces;
using Neurotech.Application.Services;
using Neurotech.Domain.Commands;
using Neurotech.Domain.Handler;
using Neurotech.Infra.CrossCutting.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            // Application
            services.AddScoped<INeurotechService, NeurotechService>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<SyncRegisterCommand, ValidationResult>, SyncRegisterHandler>();

            services.AddHttpClient("neurotech", client => configuration.GetSection("Neurotech").Bind(client));
        }
    }
}
