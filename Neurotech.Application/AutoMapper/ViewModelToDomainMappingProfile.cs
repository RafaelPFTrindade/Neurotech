using AutoMapper;
using Neurotech.Application.ViewModels;
using Neurotech.Domain.Commands;
using Neurotech.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Neurotech.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RegisterViewModel, SyncRegisterCommand>()
                .ConstructUsing(c =>
                new SyncRegisterCommand(
                    new InputVO(c.Inputs.Id, c.Inputs.Policy, c.Inputs.Version, c.Inputs.ResultingVariable, c.Inputs.Inputs.Select(x => new InputValueVO(x.Name, x.Value)).ToArray()),
                    c.Properties.Select(x => new PropertiesVO(x.Key, x.Value)).ToArray()));
        }
    }
}
