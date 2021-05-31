using IntegrationExperiments.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Abstract
{
    public interface IWorkflowStepAction
    {
        Guid Uid { get; set; }
        WorkflowActionKinds Kind { get; }
    }
}
