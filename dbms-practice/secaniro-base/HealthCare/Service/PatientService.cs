using System;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Repository;
using HealthCare.Exceptions;
using HealthCare.Utils;

namespace HealthCare.Service
{
    public class PatientService
    {
        private readonly IPatientRepository _repository;

        public PatientService()
        {
            _repository = new PatientRepository();
        }

        public void AddPatient()
        {
            try
            {
                string name = InputHelper.ReadRequired("Name: ");

                DateTime dob = InputHelper.ReadDate("Date of Birth (yyyy-mm-dd): ");

                string contact = InputHelper.ReadRequired("Contact: ");

                string address = InputHelper.ReadRequired("Address: ");

                string bloodGroup = InputHelper.ReadRequired("Blood Group: ");

                string email = InputHelper.ReadRequired("Email: ");

                string gender = InputHelper.ReadRequired("Gender: ");

                Patient patient = new Patient(
                    name, email, gender, dob, bloodGroup, contact, address
                );

                int id = _repository.AddPatient(patient);
                Console.WriteLine($"Patient added successfully. ID = {id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void UpdatePatient()
        {
            try
            {
                int id = InputHelper.ReadInt("Patient ID: ");

                string contact = InputHelper.ReadRequired("New Contact: ");

                string address = InputHelper.ReadRequired("New Address: ");

                string email = InputHelper.ReadRequired("New Email: ");

                Patient patient = new Patient
                {
                    PatientId = id,
                    Contact = contact,
                    Address = address,
                    Email = email
                };

                bool updated = _repository.UpdatePatient(patient);

                Console.WriteLine(updated
                    ? "Patient updated successfully"
                    : "No patient updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void SearchPatient()
        {
            string keyword = InputHelper.ReadRequired("Enter name or contact: ");

            try
            {
                var patients = _repository.SearchPatient(keyword);

                if (patients.Count == 0)
                {
                    Console.WriteLine("No patients found");
                    return;
                }

                foreach (var p in patients)
                {
                    Console.WriteLine($"{p.PatientId} | {p.Name} | {p.Contact}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void GetPatientById()
        {
            int id = InputHelper.ReadInt("Enter Patient ID: ");

            try
            {
                var patient = _repository.GetPatientById(id);

                Console.WriteLine("Patient Details");
                Console.WriteLine($"Name: {patient.Name}");
                Console.WriteLine($"Email: {patient.Email}");
                Console.WriteLine($"Gender: {patient.Gender}");
                Console.WriteLine($"DOB: {patient.DateOfBirth:d}");
                Console.WriteLine($"Contact: {patient.Contact}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
