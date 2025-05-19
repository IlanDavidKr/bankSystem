namespace BankSystem
{
    public abstract class BankAccount : IBank
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;
        protected BankBranch branch;

        public BankAccount(int accountNumber, double initialBalance, Customer customerOwner, BankBranch branch)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.customerOwner = customerOwner;
            this.branch = branch;
        }

        public int GetAccountNumber()
        {
            return this.accountNumber;
        }
        public double GetBalance()
        {
            return this.balance;
        }
        public Customer GetCustomerOwner()
        {
            return this.customerOwner;
        }
        public BankBranch GetBranch()
        {
            return this.branch;
        }

        public void SetAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public void SetCustomerOwner(Customer customerOwner)
        {
            this.customerOwner = customerOwner;
        }
        public void SetBranch(BankBranch branch)
        {
            this.branch = branch;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

        public virtual void PrintDetails()
        {
            Console.WriteLine("Account Details:");
            Console.WriteLine("Account Number: " + this.accountNumber);
            Console.WriteLine("Balance: " + this.balance);
            Console.WriteLine("Owner ID: " + this.customerOwner.GetId());
            Console.WriteLine("Branch #: " + this.branch.GetBranchNumber());
        }
    }
}
