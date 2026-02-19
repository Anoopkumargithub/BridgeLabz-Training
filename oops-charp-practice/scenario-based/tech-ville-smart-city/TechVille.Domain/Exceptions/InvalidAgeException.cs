using System;

namespace TechVille.Domain.Exceptions
{
    /// <summary>
    /// Thrown when citizen age is invalid.
    /// </summary>
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message)
            : base(message)
        {
        }
    }
}
