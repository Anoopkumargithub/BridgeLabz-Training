using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Services
{
    public class NotificationValidator : INotificationValidator
    {
        public bool Validate(Notification notification, out string validationError)
        {
            var context = new ValidationContext(notification);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(
                notification,
                context,
                results,
                validateAllProperties: true);

            if (!isValid)
            {
                validationError = results[0].ErrorMessage;
                return false;
            }

            validationError = null;
            return true;
        }
    }
}
