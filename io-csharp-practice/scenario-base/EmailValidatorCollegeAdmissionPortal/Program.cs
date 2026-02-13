using System;
using EmailValidatorCollegeAdmissionPortal.Services;
using EmailValidatorCollegeAdmissionPortal.Interfaces;
using EmailValidatorCollegeAdmissionPortal.Repositories;
using EmailValidatorCollegeAdmissionPortal.Utilities;

public class Program
{
    public static void Main()
    {
        IStudentRepository repository = new StudentRepository();
        AdmissionService service = new AdmissionService(repository);

        int choice;

        do
        {
            Console.WriteLine("--------Welcome to College Admission Portal--------------");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("0. Exit");

            choice = InputHelper.ReadInt("Enter your choice: ");

            switch(choice)
            {
                case 1:
                    service.AddStudent();
                    break;
                case 2:
                    service.DeleteStudent();
                    break;
                case 0:
                    Console.WriteLine("Exiting....");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
                }
        }while(choice != 0);
    }
}