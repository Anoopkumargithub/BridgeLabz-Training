using System;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Services
{
    public class NotificationIntakeService : INotificationIntakeService
    {
        private readonly INotificationValidator _validator;
        private readonly INotificationQueue _queue;

        public NotificationIntakeService(
            INotificationValidator validator,
            INotificationQueue queue)
        {
            _validator = validator;
            _queue = queue;
        }

        public bool TryAccept(Notification notification, out string rejectionReason)
        {
            rejectionReason = null;

            try
            {
                if (!_validator.Validate(notification, out string? validationError))
                {
                    rejectionReason = validationError ?? "Validation failed";
                    notification.MarkAsFailed(rejectionReason);
                    return false;
                }

                _queue.Enqueue(notification);
                return true;
            }
            catch (Exception ex)
            {
                rejectionReason = $"Unexpected error during intake: {ex.Message}";
                notification.MarkAsFailed(rejectionReason);
                return false;
            }
        }
    }
}
