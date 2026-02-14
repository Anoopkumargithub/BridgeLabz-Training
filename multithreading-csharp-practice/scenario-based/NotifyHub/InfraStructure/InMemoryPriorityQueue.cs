using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Infrastructure
{
    public class InMemoryPriorityQueue : INotificationQueue
    {
        private readonly PriorityQueue<Notification, int> _queue;
        private readonly SemaphoreSlim _signal;
        private readonly object _lock = new object();

        public InMemoryPriorityQueue()
        {
            _queue = new PriorityQueue<Notification, int>();
            _signal = new SemaphoreSlim(0);
        }

        public int Count
        {
            get
            {
                lock (_lock)
                {
                    return _queue.Count;
                }
            }
        }

        public void Enqueue(Notification notification)
        {
            if (notification == null)
                throw new ArgumentNullException(nameof(notification));

            lock (_lock)
            {
                // Negative priority so higher priority processed first
                int priority = -(int)notification.Priority;
                _queue.Enqueue(notification, priority);
            }

            _signal.Release(); // Notify waiting consumers
        }

        public Notification? Dequeue()
        {
            _signal.Wait();

            lock (_lock)
            {
                return _queue.Dequeue();
            }
        }

        public async Task<Notification> DequeueAsync(CancellationToken cancellationToken)
        {
            await _signal.WaitAsync(cancellationToken);

            lock (_lock)
            {
                return _queue.Dequeue();
            }
        }
    }
}
