namespace LoanBuddy
{
    class loanApplication
    {
        public string loanType;
        public int term;            // months
        public double interestRate;

        public LoanApplication(string loanType, int term, double interestRate)
        {
            this.loanType = loanType;
            this.term = term;
            this.interestRate = interestRate;
        }
    }
}
