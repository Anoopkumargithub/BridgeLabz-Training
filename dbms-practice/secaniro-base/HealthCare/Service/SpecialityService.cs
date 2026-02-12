using System;
using System.Collections.Generic;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Repository;

namespace HealthCare.Service
{
    public class SpecialityService
    {
        private readonly ISpecialityRepository _repository;

        public SpecialityService()
        {
            _repository = new SpecialityRepository();
        }

        // 1. Add Speciality
        public void AddSpeciality()
        {
            try
            {
                Console.Write("Enter Speciality Name: ");
                string name = Console.ReadLine();

                int id = _repository.AddSpeciality(name);
                Console.WriteLine($"Speciality added successfully. ID = {id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // 2. Show All Specialities
        public void ShowAllSpecialities()
        {
            List<Speciality> list = _repository.GetAllSpecialities();

            if (list.Count == 0)
            {
                Console.WriteLine("No specialities found");
                return;
            }

            Console.WriteLine("\nAvailable Specialities:");
            foreach (var s in list)
            {
                Console.WriteLine($"{s.SpecialityID} - {s.SpecialityName}");
            }
        }

        // 3. Search Speciality
        public void SearchSpeciality()
        {
            Console.Write("Search keyword: ");
            string keyword = Console.ReadLine();

            List<Speciality> list = _repository.SearchSpeciality(keyword);

            if (list.Count == 0)
            {
                Console.WriteLine("No matching specialities");
                return;
            }

            Console.WriteLine("\nSearch Results:");
            foreach (var s in list)
            {
                Console.WriteLine($"{s.SpecialityID} - {s.SpecialityName}");
            }
        }

        // 4. Get Speciality By ID (internal use)
        public Speciality GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
