using System;

namespace EmailValidatorCollegeAdmissionPortal.Exceptions
{
    public class DataValidationException : Exception
    {
        public DataValidationException(string message) : base(message) { }
    }
}