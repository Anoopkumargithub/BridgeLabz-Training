using System;

namespace loanApplication
{
    class Program
    {
        static void Main()
        {
            Applicant a =
                new Applicant("Amit", 700, 40000, 300000);

            Loan loan =
                new Loan(a, "Personal Loan", 36, 10);

            Console.WriteLine("Applicant Name: " + a.name);
            Console.WriteLine("Loan Type: " + loan.loanType);

            bool result = loan.ApproveLoan(a);
            loan.ShowStatus();

            if (result)
            {
                double emi = loan.CalculateEMI();
                Console.WriteLine("Monthly EMI: " + (int)emi);
            }
        }
    }
}
