using IntegrationExperiments.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Models
{
    public class WorkflowActionStepSettings : WorkflowStepSettingsBase
    {

        public IWorkflowStepAction Action { get; set; }

        public WorkflowActionStepSettings()
        {
            Kind = Enums.WorkflowStepKinds.Action;
        }
    }
}