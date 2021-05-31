using IntegrationExperiments.Core.Abstract;
using IntegrationExperiments.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegrationExperiments.Core.Models
{
    public abstract class WorkflowStepSettingsBase : IWorkflowStepSettings
    {
        protected List<Guid> _inSteps = new List<Guid>();
        protected List<Guid> _outSteps = new List<Guid>();


        public Guid Uid { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public WorkflowStepKinds Kind { get; set; }

        public IEnumerable<Guid> InSteps => _inSteps;

        public IEnumerable<Guid> OutSteps => _outSteps;

        public virtual Guid InUid
        {
            get
            {
                return _inSteps.FirstOrDefault();
            }
            set
            {

                if (_inSteps.Any())
                {
                    _inSteps.Clear();
                }
                _inSteps.Add(value);


            }
        }

        public virtual Guid OutUid
        {
            get
            {
                return _outSteps.FirstOrDefault();
            }
            set
            {

                if (_outSteps.Any())
                {
                    _outSteps.Clear();
                }
                _outSteps.Add(value);


            }
        }


    }
}
