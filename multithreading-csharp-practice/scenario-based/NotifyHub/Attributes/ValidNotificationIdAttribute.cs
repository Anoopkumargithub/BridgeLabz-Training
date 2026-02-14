using System;
using System.ComponentModel.DataAnnotations;

namespace NotifyHub.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidNotificationIdAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value,
            ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Notification ID is required.");

            if (string.IsNullOrWhiteSpace(value.ToString()))
                return new ValidationResult("Notification ID cannot be empty.");

            return ValidationResult.Success;
        }
    }
}
