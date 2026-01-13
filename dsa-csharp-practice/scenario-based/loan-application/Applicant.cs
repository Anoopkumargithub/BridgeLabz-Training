namespace loanApplication
{
    class Applicant
    {
        private int creditScore;

        public string name;
        public double income;
        public double loanAmount;

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            this.name = name;
            this.creditScore = creditScore;
            this.income = income;
            this.loanAmount = loanAmount;
        }

        public int GetCreditScore()
        {
            return creditScore;
        }
    }
}
