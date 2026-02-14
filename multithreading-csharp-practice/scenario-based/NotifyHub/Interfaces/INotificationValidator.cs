using System;
using NotifyHub.Models;

namespace NotifyHub.Interfaces
{
    public interface INotificationValidator
    {
        bool Validate(Notification notification, out string? validationError);
    }
}
