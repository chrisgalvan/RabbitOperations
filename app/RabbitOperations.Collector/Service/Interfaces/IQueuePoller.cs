using System;
using System.Security.Cryptography.X509Certificates;

namespace RabbitOperations.Collector.Service.Interfaces
{
    public interface IQueuePoller : IDisposable
    {
        /// <summary>
        /// Gets the queue name for this poller
        /// </summary>
        string QueueName { get; }
        /// <summary>
        /// Start polling the indicated queue
        /// </summary>
        void Start();
        /// <summary>
        /// Stop polling the indicated queue
        /// </summary>
        void Stop();
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="message"></param>
        void HandleMessage(IRawMessage message);
    }
}