using System;
using System.IO;
using System.Text.Json;
using EmailValidatorCollegeAdmissionPortal.Models;
using EmailValidatorCollegeAdmissionPortal.Interfaces;
using EmailValidatorCollegeAdmissionPortal.Exceptions;

namespace EmailValidatorCollegeAdmissionPortal.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        // File Path 
        private readonly string _filePath = "student.json";

        // Ensure FIle Exists
        private void EnsureFileExists()
        {
            if(!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath,"[]"); // create empty Json File
            }
        }

        // Read All Students
        private List<Student> ReadAll()
        {
            EnsureFileExists();

            string json = File.ReadAllText(_filePath); // read all data from the file 

            return JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
        }

        // Write All Employee
        private void WriteAll(List<Student> students)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(students, options);
            File.WriteAllText(_filePath,json) ;
        }


        // Add Student
        public void AddStudent(Student student)
        {
            var students = ReadAll();
            students.Add(student);
            WriteAll(students);
        }

        // Delete student by ID
        public void Delete(int id)
        {
            var students = ReadAll();

            var studentToRemove = students.FirstOrDefault(e => e.Id == id);

            if(studentToRemove != null){
                students.Remove(studentToRemove);
                WriteAll(students);
                Console.WriteLine("Student Deleted SucessFully.");
            }
            else{
                Console.WriteLine("Student Not Found");
            }
        }
        
    }
}