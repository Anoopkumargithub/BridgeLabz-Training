using System;
using System.ComponentModel.DataAnnotations;
using NotifyHub.Attributes;

namespace NotifyHub.Models
{
    public class Notification
    {
        [ValidNotificationId]
        public string NotificationId { get; set; }

        [ValidRecipient]
        public string Recipient { get; set; }

        [ValidPriority]
        public NotificationPriority Priority { get; set; }

        public NotificationType Type { get; set; }

        public string Message { get; set; }

        public DateTime CreatedTime { get; private set; }

        public NotificationStatus Status { get; private set; }

        public string? FailureReason { get; private set; }

        public Notification(
            string notificationId,
            string recipient,
            string message,
            NotificationPriority priority)
        {
            NotificationId = notificationId ?? throw new ArgumentNullException(nameof(notificationId));
            Recipient = recipient ?? throw new ArgumentNullException(nameof(recipient));
            Message = message ?? throw new ArgumentNullException(nameof(message));
            Priority = priority;

            CreatedTime = DateTime.UtcNow;
            Status = NotificationStatus.Pending;
        }

        public void MarkAsProcessing()
        {
            if (Status != NotificationStatus.Pending)
                throw new InvalidOperationException("Invalid state transition.");

            Status = NotificationStatus.Processing;
        }

        public void MarkAsSent()
        {
            if (Status != NotificationStatus.Processing)
                throw new InvalidOperationException("Invalid state transition.");

            Status = NotificationStatus.Sent;
            FailureReason = null;
        }

        public void MarkAsFailed(string reason)
        {
            Status = NotificationStatus.Failed;
            FailureReason = reason;
        }

            // override ToString() 
            public override string ToString()
            {
                return $"-------------------Notification-------------------\nNotificationId: {NotificationId}\nRecipient: {Recipient}\nMessage: {Message}\nPriority: {Priority}\nCreated At: {CreatedTime}";
            }
    }
}