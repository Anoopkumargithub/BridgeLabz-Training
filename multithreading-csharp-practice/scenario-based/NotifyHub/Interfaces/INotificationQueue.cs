using System;
using System.Threading;
using System.Threading.Tasks;
using NotifyHub.Models;

namespace NotifyHub.Interfaces
{
    public interface INotificationQueue
    {
        void Enqueue(Notification notification);
        Notification? Dequeue();
        Task<Notification> DequeueAsync(CancellationToken cancellationToken);
    }
}
