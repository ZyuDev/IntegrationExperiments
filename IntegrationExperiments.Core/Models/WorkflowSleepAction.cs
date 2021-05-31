using IntegrationExperiments.Core.Abstract;
using IntegrationExperiments.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Models
{
    public class WorkflowSleepAction : IWorkflowStepAction
    {
        public Guid Uid { get; set; }
        public int DelayMilliseconds { get; set; }
        public WorkflowActionKinds Kind { get; } = WorkflowActionKinds.Sleep;

    }
}
