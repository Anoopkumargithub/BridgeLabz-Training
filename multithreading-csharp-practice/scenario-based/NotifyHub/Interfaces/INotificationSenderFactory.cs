using System;
using NotifyHub.Models;

namespace NotifyHub.Interfaces
{
    public interface INotificationSenderFactory
    {
        INotificationSender GetSender(NotificationType type);
    }
}
