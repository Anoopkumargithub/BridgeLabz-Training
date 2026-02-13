using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EmailValidatorCollegeAdmissionPortal.Models;
using EmailValidatorCollegeAdmissionPortal.Interfaces;
using EmailValidatorCollegeAdmissionPortal.Exceptions;
using EmailValidatorCollegeAdmissionPortal.Utilities;

namespace EmailValidatorCollegeAdmissionPortal.Services
{
    public class AdmissionService
    {
        private readonly IStudentRepository _repository;

        public AdmissionService(IStudentRepository repository)
        {
            _repository = repository;
        }

        // Add Student
        public void AddStudent()
        {
            try
            {
                int id = InputHelper.ReadInt("Enter Id: ");
                string name = InputHelper.ReadRequired("Enter Name: ");
                string email = InputHelper.ReadRequired("Enter Email: ");

                Student student = new Student(id, name, email);

                ValidateStudent(student);

                _repository.AddStudent(student);

                Console.WriteLine("Student Added Successfully.");
            }
            catch (DataValidationException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }

        // Delete Student
        public void DeleteStudent()
        {
            int id = InputHelper.ReadInt("Enter Student Id to delete: ");
            _repository.Delete(id);
        }

        // Central Validation Method
        private void ValidateStudent(Student student)
        {
            var context = new ValidationContext(student);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(
                student,
                context,
                results,
                true);

            if (!isValid)
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }

                throw new DataValidationException("Student data is invalid.");
            }
        }
    }
}
