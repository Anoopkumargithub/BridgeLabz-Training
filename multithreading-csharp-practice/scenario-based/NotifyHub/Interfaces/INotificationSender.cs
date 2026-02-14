using System;
using System.Threading;
using System.Threading.Tasks;
using NotifyHub.Models;

namespace NotifyHub.Interfaces
{
    public interface INotificationSender
    {
        NotificationType SupportedType { get; }

        Task SendAsync(Notification notification, CancellationToken cancellationToken);
    }
}