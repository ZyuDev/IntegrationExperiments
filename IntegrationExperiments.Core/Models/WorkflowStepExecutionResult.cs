using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Models
{
    public class WorkflowStepExecutionResult
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
