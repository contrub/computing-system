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
            Process newActiveProc = queue.Item();
            queue.Remove();
            resource.ActiveProcess = newActiveProc;
            return queue;
        }

        private Resource resource;
        private IQueueable<Process> queue;
    }
}