using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInter
{
    public class WorkflowEngine
    {
        private readonly IList<IActivity> list;

        public WorkflowEngine()
        {
            list = new List<IActivity>();
        }

        public void Run()
        {
            if (list.Count == 0)
                throw new InvalidOperationException();

            foreach (var act in list)
                act.Execute();
        }

        public void AddActivity(IActivity activity)
        {
            list.Add(activity);
        }
    }
}
