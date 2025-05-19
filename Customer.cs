namespace BankSystem
{
    public class Customer : IBank
    {
        private int id;
        private string name;
        private string address;
        private string phoneNumber;
        private int age;
        private string gender;

        public Customer(int id, string name, string address, string phoneNumber, int age, string gender)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.age = age;
            this.gender = gender;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetGender()
        {
            return this.gender;
        }

        public void SetGender(string gender)
        {
            this.gender = gender;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Customer Details:");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Address: " + this.address);
            Console.WriteLine("Phone: " + this.phoneNumber);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Gender: " + this.gender);
        }
    }
}
