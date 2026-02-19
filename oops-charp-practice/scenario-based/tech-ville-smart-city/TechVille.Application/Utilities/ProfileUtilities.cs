using System.Text.RegularExpressions;

namespace TechVille.Application.Utilities
{
    /// <summary>
    /// Utility class for handling string operations related to citizen profiles.
    /// </summary>
    public static class ProfileUtilities
    {
        /// <summary>
        /// Formats name to Title Case.
        /// </summary>
        public static string FormatName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return string.Empty;

            name = name.ToLower();

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo
                .ToTitleCase(name);
        }

        /// <summary>
        /// Validates email using simple pattern.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// Extracts PIN code from address.
        /// </summary>
        public static string ExtractPinCode(string address)
        {
            Match match = Regex.Match(address, @"\b\d{6}\b");
            return match.Success ? match.Value : "Not Found";
        }

        /// <summary>
        /// Performs case-insensitive name search.
        /// </summary>
        public static bool NameMatches(string source, string searchTerm)
        {
            return source.Contains(searchTerm,
                StringComparison.OrdinalIgnoreCase);
        }
    }
}
