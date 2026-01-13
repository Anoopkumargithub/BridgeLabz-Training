namespace loanApplication
{
    interface IApprovable
    {
        bool ApproveLoan(Applicant a);
        double CalculateEMI();
    }
}
