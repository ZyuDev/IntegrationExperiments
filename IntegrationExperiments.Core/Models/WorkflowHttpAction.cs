using IntegrationExperiments.Core.Abstract;
using IntegrationExperiments.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Models
{
    public class WorkflowHttpAction : IWorkflowStepAction
    {
        public Guid Uid { get; set; }
        public string Url { get; set; }
        public HttpMethods Method { get; set; }
        public bool AutoParse { get; set; } = true;
        public WorkflowActionKinds Kind { get; } = WorkflowActionKinds.HttpConnector;

    }
}
