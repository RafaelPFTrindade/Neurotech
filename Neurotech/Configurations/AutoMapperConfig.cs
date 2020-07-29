using Microsoft.Extensions.DependencyInjection;
using Neurotech.Application.AutoMapper;
using System;
using AutoMapper;

namespace Neurotech.Api.Configurations
{

    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(ViewModelToDomainMappingProfile));
        }
    }
}
