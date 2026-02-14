using System;
using NotifyHub.Models;

namespace NotifyHub.Interfaces
{
    public interface INotificationIntakeService
    {
        bool TryAccept(Notification notification, out string rejectionReason);
    }
}
