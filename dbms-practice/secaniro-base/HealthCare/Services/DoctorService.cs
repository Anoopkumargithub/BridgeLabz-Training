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

        public DoctorService()
        {
            _doctorRepository = new DoctorRepository();
        }

        // 1. Add Doctor
        public void AddDoctor()
        {
            try
            {
                Console.Write("Doctor Name: ");
                string name = Console.ReadLine();

                Console.Write("Speciality ID: ");
                int specialityId = int.Parse(Console.ReadLine());

                Console.Write("Contact: ");
                string contact = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Consultation Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());

                Doctor doctor = new Doctor(
                    name,
                    specialityId,
                    contact,
                    email,
                    fee
                );

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
                int id = int.Parse(Console.ReadLine());

                Console.Write("New Contact: ");
                string contact = Console.ReadLine();

                Console.Write("New Email: ");
                string email = Console.ReadLine();

                Console.Write("New Consultation Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());

                Doctor doctor = new Doctor
                {
                    DoctorId = id,
                    Contact = contact,
                    Email = email,
                    ConsultationFee = fee
                };

                bool updated = _doctorRepository.UpdateDoctor(doctor);

                Console.WriteLine(updated
                    ? "Doctor updated successfully"
                    : "Doctor not updated");
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
                int id = int.Parse(Console.ReadLine());

                Doctor doctor = _doctorRepository.GetDoctorById(id);

                Console.WriteLine("\nDoctor Details");
                Console.WriteLine($"ID: {doctor.DoctorId}");
                Console.WriteLine($"Name: {doctor.Name}");
                Console.WriteLine($"Speciality ID: {doctor.SpecialityID}");
                Console.WriteLine($"Contact: {doctor.Contact}");
                Console.WriteLine($"Email: {doctor.Email}");
                Console.WriteLine($"Consultation Fee: {doctor.ConsultationFee}");
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
                string speciality = Console.ReadLine();

                List<Doctor> doctors = _doctorRepository.GetDoctorsBySpeciality(speciality);

                if (doctors.Count == 0)
                {
                    Console.WriteLine("No doctors found");
                    return;
                }

                Console.WriteLine("\nDoctors List:");
                foreach (var d in doctors)
                {
                    Console.WriteLine(
                        $"{d.DoctorId} | {d.Name} | {d.Email} | Fee: {d.ConsultationFee}"
                    );
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
                Console.Write("Doctor ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                bool deleted = _doctorRepository.DeleteDoctor(id);

                Console.WriteLine(deleted
                    ? "Doctor deactivated successfully"
                    : "Doctor not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
