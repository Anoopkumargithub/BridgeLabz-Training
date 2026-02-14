using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace NotifyHub.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidRecipientAttribute : ValidationAttribute
    {
        private static readonly Regex EmailRegex =
            new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        private static readonly Regex PhoneRegex =
            new(@"^\+?[0-9]{8,15}$", RegexOptions.Compiled);

        protected override ValidationResult? IsValid(
            object? value,
            ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Recipient is required.");

            var recipient = value.ToString();

            if (EmailRegex.IsMatch(recipient) || PhoneRegex.IsMatch(recipient))
                return ValidationResult.Success;

            return new ValidationResult("Recipient must be valid email or phone number.");
        }
    }
}
