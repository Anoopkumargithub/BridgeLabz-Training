using System;
using System.Threading;
using System.Threading.Tasks;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Senders
{
    public class EmailNotificationSender : INotificationSender
    {
        public NotificationType SupportedType => NotificationType.Email;

        public async Task SendAsync(Notification notification, CancellationToken cancellationToken)
        {
            // Simulate network delay
            await Task.Delay(800, cancellationToken);

            // Simulate occasional failure
            if (notification.Recipient.Contains("fail"))
            {
                throw new Exception("SMTP server failed.");
            }

            Console.WriteLine($"[EMAIL SENT] To: {notification.Recipient} | Message: {notification.Message}");
        }
    }
}
