using System;
using System.Collections.Generic;
using System.Linq;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Factories
{
    public class NotificationSenderFactory : INotificationSenderFactory
    {
        private readonly Dictionary<NotificationType, INotificationSender> _senders;

        public NotificationSenderFactory(IEnumerable<INotificationSender> senders)
        {
            _senders = senders.ToDictionary(s => s.SupportedType);
        }

        public INotificationSender GetSender(NotificationType type)
        {
            if (_senders.TryGetValue(type, out var sender))
            {
                return sender;
            }

            throw new InvalidOperationException($"No sender registered for {type}");
        }
    }
}
