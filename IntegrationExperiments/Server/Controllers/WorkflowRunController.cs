using IntegrationExperiments.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationExperiments.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WorkflowRunController : ControllerBase
    {
        [HttpGet("Ping")]
        public ResponseDto<string> Ping()
        {
            var responseData = new ResponseDto<string>()
            {
                Status = 200,
                Message = "OK",
                Data = $"OK-{DateTime.Now}"
            };

            return responseData;
        }
    }
}
