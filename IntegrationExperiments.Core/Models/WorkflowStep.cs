using IntegrationExperiments.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Models
{
    public class WorkflowStep : IWorkflowStep
    {
        public Guid Uid { get; set; }
        public bool Finished { get; set; }
        public IWorkflowStepSettings Settings { get; set; }
    }
}
