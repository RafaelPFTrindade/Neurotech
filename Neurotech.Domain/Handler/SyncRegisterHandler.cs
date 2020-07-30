using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.Configuration;
using NetDevPack.Messaging;
using Neurotech.Domain.Commands;
using Neurotech.Domain.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Neurotech.Domain.Handler
{
    public class SyncRegisterHandler : CommandHandler,
        IRequestHandler<SyncRegisterCommand, ValidationResult>
    {
        private readonly IHttpClientFactory httpClientFactory;

        private readonly IConfiguration configuration;

        public SyncRegisterHandler(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            this.httpClientFactory = httpClientFactory;
            this.configuration = configuration;
        }

        public async Task<ValidationResult> Handle(SyncRegisterCommand request, CancellationToken cancellationToken)
        {

            var httpClient = httpClientFactory.CreateClient("neurotech");
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var Login = configuration.GetValue<string>("Neurotech:Login");
            var Password = configuration.GetValue<string>("Neurotech:Password");

            var json = JsonConvert.SerializeObject(request, Formatting.Indented);
            var stringContent = new StringContent(json);
            using (var result = await httpClient.PostAsync($"/services/rest/workflow/submit", stringContent))
            {
                if (result.StatusCode != HttpStatusCode.OK)
                {
                }
            }
            throw new NotImplementedException();
        }

    }
}
