using AutoMapper;
using Neurotech.Application.ViewModels;
using Neurotech.Domain.Commands;
using Neurotech.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Neurotech.Domain.Results;

namespace Neurotech.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RegisterViewModel, SyncRegisterCommand>()
                .ForPath(d => d.Submit.Inputs, opts => opts.MapFrom(s => s.Submit.Inputs.Select(x => new InputValueVO(x.Name, x.Value))))
                .ForMember(d => d.Properties, opts => opts.MapFrom(s => s.Properties.Select(x => new PropertiesVO(x.Key, x.Value))));

        }
    }
}
