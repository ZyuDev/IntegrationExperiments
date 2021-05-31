using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Abstract
{
    public interface IWorkflowStep
    {
        Guid Uid { get; set; }
        IWorkflowStepSettings Settings { get; set; }
        bool Finished { get; set; }

    }
}
