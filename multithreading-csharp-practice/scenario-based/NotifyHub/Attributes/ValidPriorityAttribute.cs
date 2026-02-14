using System;
using System.ComponentModel.DataAnnotations;
using NotifyHub.Models;

namespace NotifyHub.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidPriorityAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value,
            ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Priority is required.");

            if (!Enum.IsDefined(typeof(NotificationPriority), value))
                return new ValidationResult("Invalid priority value.");

            return ValidationResult.Success;
        }
    }
}
