using IntegrationExperiments.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Abstract
{
    public interface IWorkflowStepSettings
    {
        Guid Uid { get; set; }
        string Title { get; set; }
        string Name { get; set; }
        string Memo { get; set; }
        WorkflowStepKinds Kind { get; set; }

        IEnumerable<Guid> InSteps { get; }
        IEnumerable<Guid> OutSteps { get; }

        Guid InUid { get; set; }
        Guid OutUid { get; set; }

    }
}
