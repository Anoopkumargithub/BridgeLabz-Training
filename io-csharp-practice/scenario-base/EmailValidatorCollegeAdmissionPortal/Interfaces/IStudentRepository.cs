using System;
using EmailValidatorCollegeAdmissionPortal.Models;

namespace EmailValidatorCollegeAdmissionPortal.Interfaces
{
    public interface IStudentRepository
    {
        // Add Student
        void AddStudent(Student student);

        // Delete Student
        void Delete(int id);
    }
}