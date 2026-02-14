using System;
using System.Threading;
using System.Threading.Tasks;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Senders
{
    public class SmsNotificationSender : INotificationSender
    {
        public NotificationType SupportedType => NotificationType.Sms;

        public async Task SendAsync(Notification notification, CancellationToken cancellationToken)
        {
            await Task.Delay(500, cancellationToken);

            if (notification.Message.Length > 160)
            {
                throw new Exception("SMS exceeds character limit.");
            }

            Console.WriteLine($"[SMS SENT] To: {notification.Recipient} | Message: {notification.Message}");
        }
    }
}
