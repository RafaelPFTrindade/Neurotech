using AutoMapper;
using Neurotech.Application.ViewModels;
using Neurotech.Domain.Commands;
using Neurotech.Domain;
using System.Linq;

namespace Neurotech.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RegisterViewModel, InputVO>()
                .ForMember(d => d.Id, opts => opts.MapFrom(s => s.IdProposta))
                .ForMember(d => d.Policy, opts => opts.MapFrom(s => s.NmPolitica))
                .ForMember(d => d.ResultingVariable, opts => opts.MapFrom(s => s.NmFluxoResultado))
                .ForMember(d => d.Version, opts => opts.MapFrom(s => s.TagVersaoPolitica))
                .ForMember(d => d.Inputs, opts => opts.MapFrom(s => s.LsParametros.Select(x => new InputValueVO(x.NmParametro, x.VlParametro))));

        }
    }
}
