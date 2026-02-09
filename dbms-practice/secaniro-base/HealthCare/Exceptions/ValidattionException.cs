using System;

namespace HealthCare.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base   (message) { }
    }
}