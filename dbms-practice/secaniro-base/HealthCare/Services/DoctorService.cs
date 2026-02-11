using System;
using System.Collections.Generic;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Repository;
using HealthCare.Exceptions;

namespace HealthCare.Service
{
    public class DoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly ISpecialityRepository _specialityRepository;

        public DoctorService()
        {
            _doctorRepository = new DoctorRepository();
            _specialityRepository = new SpecialityRepository();
        }

        // 1. Add Doctor
        public void AddDoctor()
        {
            try
            {
                Console.Write("Doctor Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                    throw new ValidationException("Doctor name cannot be empty.");

                // Show Specialities
                var specialities = _specialityRepository.GetAllSpecialities();
                if (specialities.Count == 0)
                    throw new Exception("No specialities available. Add speciality first.");

                Console.WriteLine("\nAvailable Specialities:");
                foreach (var s in specialities)
                    Console.WriteLine($"{s.SpecialityID} - {s.SpecialityName}");

                Console.Write("Select Speciality ID: ");
                if (!int.TryParse(Console.ReadLine(), out int specialityId))
                    throw new ValidationException("Invalid Speciality ID.");

                var speciality = _specialityRepository.GetById(specialityId);
                if (speciality == null)
                    throw new NotFoundException("Speciality not found.");

                Console.Write("Contact: ");
                string contact = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Consultation Fee: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal fee))
                    throw new ValidationException("Invalid fee amount.");

                Doctor doctor = new Doctor(name, specialityId, contact, email, fee);

                int id = _doctorRepository.AddDoctor(doctor);

                Console.WriteLine($"Doctor added successfully. ID = {id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // 2. Update Doctor
        public void UpdateDoctor()
        {
            try
            {
                Console.Write("Doctor ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                    throw new ValidationException("Invalid Doctor ID.");

                var existingDoctor = _doctorRepository.GetDoctorById(id);
                if (existingDoctor == null)
                    throw new NotFoundException("Doctor not found.");

                Console.Write("New Contact: ");
                string contact = Console.ReadLine();

                Console.Write("New Email: ");
                string email = Console.ReadLine();

                Console.Write("New Consultation Fee: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal fee))
                    throw new ValidationException("Invalid fee.");

                existingDoctor.Contact = contact;
                existingDoctor.Email = email;
                existingDoctor.ConsultationFee = fee;

                bool updated = _doctorRepository.UpdateDoctor(existingDoctor);

                Console.WriteLine(updated
                    ? "Doctor updated successfully."
                    : "Doctor update failed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        // 3. Get Doctor By ID
        public void GetDoctorById()
        {
            try
            {
                Console.Write("Doctor ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                    throw new ValidationException("Invalid Doctor ID.");

                var doctor = _doctorRepository.GetDoctorById(id);

                if (doctor == null)
                    throw new NotFoundException("Doctor not found.");

                Console.WriteLine("\nDoctor Details:");
                Console.WriteLine($"ID: {doctor.DoctorId}");
                Console.WriteLine($"Name: {doctor.Name}");
                Console.WriteLine($"Speciality: {doctor.SpecialityName}");
                Console.WriteLine($"Contact: {doctor.Contact}");
                Console.WriteLine($"Email: {doctor.Email}");
                Console.WriteLine($"Fee: {doctor.ConsultationFee}");
                Console.WriteLine($"Active: {doctor.IsActive}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        // 4. Get Doctors By Speciality
        public void GetDoctorsBySpeciality()
        {
            try
            {
                Console.Write("Speciality Name: ");
                string specialityName = Console.ReadLine();

                var doctors = _doctorRepository.GetDoctorsBySpeciality(specialityName);

                if (doctors.Count == 0)
                {
                    Console.WriteLine("No doctors found.");
                    return;
                }

                Console.WriteLine("\nDoctors List:");
                foreach (var d in doctors)
                {
                    Console.WriteLine($"{d.DoctorId} | {d.Name} | {d.SpecialityName} | {d.Email} | Fee: {d.ConsultationFee}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // 5. Delete Doctor (Soft Delete)
        public void DeleteDoctor()
        {
            try
            {
                Console.Write("Doctor ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                    throw new ValidationException("Invalid Doctor ID.");

                bool deleted = _doctorRepository.DeleteDoctor(id);

                Console.WriteLine(deleted
                    ? "Doctor deactivated successfully."
                    : "Doctor not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
