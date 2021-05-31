using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Core.Enums
{
    public enum WorkflowActionKinds
    {
        Undefined = 0,
        HttpConnector = 1,
        Sleep = 2,
        DataSource = 3
    }
}
