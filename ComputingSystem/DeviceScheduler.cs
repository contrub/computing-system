using System;
using System.Collections.Generic;
using System.Text;
using Queues;

namespace ComputingSystem
{
    class DeviceScheduler
    {
        public DeviceScheduler(Resource resource, IQueueable<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public IQueueable<Process> Session()
        {
            resource.ActiveProcess = queue.Item();

            return queue;
        }

        private Resource resource;
        private IQueueable<Process> queue;
    }
}