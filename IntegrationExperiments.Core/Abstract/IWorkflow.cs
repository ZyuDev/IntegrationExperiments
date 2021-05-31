using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Abstract
{
    public interface IWorkflow
    {
        Guid Uid { get; set; }
        IWorkflowSettings Settings { get; set; }
        bool Finished { get; set; }

        IEnumerable<IWorkflowStep> Steps { get; }


    }
}
