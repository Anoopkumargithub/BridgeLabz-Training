using System;
using System.Threading;
using System.Threading.Tasks;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Senders
{
    public class AppNotificationSender : INotificationSender
    {
        public NotificationType SupportedType => NotificationType.AppAlert;

        public async Task SendAsync(Notification notification, CancellationToken cancellationToken)
        {
            await Task.Delay(300, cancellationToken);

            Console.WriteLine($"[APP ALERT SENT] User: {notification.Recipient} | Message: {notification.Message}");
        }
    }
}
