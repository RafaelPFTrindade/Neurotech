using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.Configuration;
using NetDevPack.Messaging;
using Neurotech.Domain.Commands;
using Neurotech.Domain.Models;
using Neurotech.Domain.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Neurotech.Domain.Handler
{
    public class SyncRegisterHandler : IRequestHandler<SyncRegisterCommand, Resultado>
    {
        private readonly IHttpClientFactory httpClientFactory;

        private readonly IConfiguration configuration;

        public SyncRegisterHandler(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            this.httpClientFactory = httpClientFactory;
            this.configuration = configuration;
        }

        public async Task<Resultado> Handle(SyncRegisterCommand request, CancellationToken cancellationToken)
        {

            var httpClient = httpClientFactory.CreateClient("neurotech");
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "text/plain; application/json");
            var stringContent = PrepararBody(request);
            var content = new StringContent(stringContent, Encoding.UTF32, "application/json");
            using (var result = await httpClient.PostAsync($"/services/rest/workflow/submit", content))
            {
                if (result.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Problema na comunicação com o motor Neurotech");
                }
                return DeserializeResponse<Resultado>(result.Content);
            }
        }

        private string PrepararBody(SyncRegisterCommand request)
        {
            var Login = configuration.GetValue<string>("Neurotech:Login");
            var Password = configuration.GetValue<string>("Neurotech:Password");

            request.Authentication = new AuthenticationVO(Login, Password);
            request.Properties = new PropertiesVO[1];
            request.Properties[0] = new PropertiesVO("FILIAL_ID", "0"); ;

            return JsonConvert.SerializeObject(request, Formatting.Indented);
        }

        private T DeserializeResponse<T>(HttpContent responseContent)
        {
            string _responseContent = responseContent.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<T>(_responseContent);
        }
    }
}
