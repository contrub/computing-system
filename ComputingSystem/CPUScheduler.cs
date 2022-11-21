using System;
using System.Collections.Generic;
using System.Text;
using Queues;

namespace ComputingSystem
{
	class CPUScheduler
	{
        public CPUScheduler(Resource resource, IQueueable<Process> queue)
		{
			this.resource = resource;
            this.queue = queue;
		}

		public IQueueable<Process> Session()
		{
            Process newActiveProcess = queue.Item();
            newActiveProcess.Status = ProcessStatus.running;
            queue.Remove();
            resource.ActiveProcess = newActiveProcess;
            return queue;
        }

		private readonly Resource resource;
		private readonly IQueueable<Process> queue;
	}
}