using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using IntegrationExperiments.Shared;

namespace IntegrationExperiments.Client.Pages
{
    public partial class WorkflowExamplePage: ComponentBase
    {
        private List<string> _responses = new List<string>();

        [Inject]
        public HttpClient Http { get; set; }

        private async Task OnBtnClick()
        {

            var responseDto = await Http.GetFromJsonAsync<ResponseDto<string>>("WorkflowRun/Ping");

            _responses.Add(responseDto?.Data);
        }
    }
}
