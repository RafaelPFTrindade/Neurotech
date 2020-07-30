using AutoMapper;
using MediatR;
using NetDevPack.Mediator;
using Neurotech.Application.EventSourcedNomalizers;
using Neurotech.Application.Interfaces;
using Neurotech.Application.ViewModels;
using Neurotech.Domain;
using Neurotech.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Neurotech.Application.Services
{
    public class NeurotechService : INeurotechService
    {
        private readonly IMapper _mapper;

        private readonly IMediator _mediator;

        public NeurotechService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<RegisterResultData> Submit(RegisterViewModel model)
        {
            var registerCommand = new SyncRegisterCommand(_mapper.Map<InputVO>(model));
            await _mediator.Send(registerCommand);
            throw new NotImplementedException();
        }
    }
}
