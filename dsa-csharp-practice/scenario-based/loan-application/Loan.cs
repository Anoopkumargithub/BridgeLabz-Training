using System;

namespace loanApplication
{
    class Loan : LoanApplication, IApprovable
    {
        Applicant applicant;
        private bool approved;

        public Loan(Applicant applicant, string loanType, int term, double interestRate)
            : base(loanType, term, interestRate)
        {
            this.applicant = applicant;
        }

        public bool ApproveLoan(Applicant a)
        {
            if (a.GetCreditScore() >= 650 && a.income >= 25000)
            {
                approved = true;
            }
            else
            {
                approved = false;
            }
            return approved;
        }

        public double CalculateEMI()
        {
            double P = applicant.loanAmount;
            double R = interestRate / (12 * 100);
            int N = term;

            double emi = (P * R * Math.Pow(1 + R, N)) /
                         (Math.Pow(1 + R, N) - 1);

            return emi;
        }

        public void ShowStatus()
        {
            if (approved)
                Console.WriteLine("Loan Approved");
            else
                Console.WriteLine("Loan Rejected");
        }
    }
}
