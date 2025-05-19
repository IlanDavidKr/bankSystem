namespace BankSystem
{
    public class CheckingAccount : BankAccount
    {
        private double overdraftLimit;

        public CheckingAccount(int accountNumber, double initialBalance, Customer customerOwner, BankBranch branch, double overdraftLimit)
            : base(accountNumber, initialBalance, customerOwner, branch)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public double GetOverdraftLimit()
        {
            return this.overdraftLimit;
        }
        public void SetOverdraftLimit(double limit)
        {
            this.overdraftLimit = limit;
        }

        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
            }
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= (this.balance + this.overdraftLimit))
            {
                this.balance -= amount;
            }
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Overdraft Limit: " + this.overdraftLimit);
        }
    }
}
