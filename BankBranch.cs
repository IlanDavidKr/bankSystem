namespace BankSystem
{
    public class BankBranch
    {
        private int branchNumber;
        private string address;

        private CheckingAccount[] accounts = new CheckingAccount[20];
        private int accountCount = 0;

        private Customer[] customers = new Customer[100];
        private int customerCount = 0;

        public BankBranch(int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
        }

        public int GetBranchNumber()
        {
            return this.branchNumber;
        }
        public string GetAddress()
        {
            return this.address;
        }

        public void SetBranchNumber(int branchNumber)
        {
            this.branchNumber = branchNumber;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }

        public bool AddAccount(CheckingAccount account)
        {
            if (accountCount < accounts.Length)
            {
                accounts[accountCount++] = account;
                return true;
            }
            return false;
        }

        public void AddCustomer(Customer customer)
        {
            if (customerCount < customers.Length)
            {
                customers[customerCount++] = customer;
            }
        }

        public void PrintAccounts()
        {
            Console.WriteLine("Accounts in Branch " + this.branchNumber);
            for (int i = 0; i < accountCount; i++)
            {
                accounts[i].PrintDetails();
            }
        }

        public void PrintCustomers()
        {
            Console.WriteLine("Customers in Branch " + this.branchNumber);
            for (int i = 0; i < customerCount; i++)
            {
                customers[i].PrintDetails();
            }
        }
    }
}
