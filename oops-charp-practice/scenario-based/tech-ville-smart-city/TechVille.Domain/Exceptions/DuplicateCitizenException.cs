using System;

namespace TechVille.Domain.Exceptions
{
    /// <summary>
    /// Thrown when a duplicate citizen registration is attempted.
    /// </summary>
    public class DuplicateCitizenException : Exception
    {
        public DuplicateCitizenException(string message)
            : base(message)
        {
        }
    }
}
