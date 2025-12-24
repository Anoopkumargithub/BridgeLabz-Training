using System;


class SalaryAndBonus
{
    static void Main()
    {
        double[] EmployeesSalary = new double[10];
        double[] EmployeesServices = new double[10];
        double[] NewSalary = new double[10];
        double[] NewBonus = new double[10];
        double TotalBonus = 0;
        double TotalOldSalary = 0;
        double TotalNewSalary = 0;

        int idx = 0;

        while (idx < 10)
        {
            Console.WriteLine($"Enter salary for employee:");
            double Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Enter years of service for employee:");
            double Years = Convert.ToDouble(Console.ReadLine());

            if (Salary <= 0 || Years < 0)
            {
                Console.WriteLine("Invalid input. Please enter again.");
                continue;
            }

            EmployeesSalary[idx] = Salary;
            EmployeesServices[idx] = Years;
            idx++;
        }


        for (int i = 0; i < 10; i++)
        {
            if (EmployeesServices[i] > 5)
            {
                NewBonus[i] = EmployeesSalary[i] * 0.05;
            }
            else
            {
                NewBonus[i] = EmployeesSalary[i] * 0.02;
            }

            NewSalary[i] = EmployeesSalary[i] + NewBonus[i];

            TotalBonus += NewBonus[i];
            TotalOldSalary += EmployeesSalary[i];
            TotalNewSalary += NewSalary[i];
        }



        Console.WriteLine($"Total Old Salary: {TotalOldSalary}");
        Console.WriteLine($"Total Bonus Paid: {TotalBonus}");
        Console.WriteLine($"Total New Salary: {TotalNewSalary}");


    }
}
