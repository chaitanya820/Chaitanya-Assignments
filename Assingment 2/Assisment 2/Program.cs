namespace AccountManagementSystem
{
    class Accounts
    {
        private string accountNo;
        private string customerName;
        private string accountType;
        private char transactionType; 
        private double amount;
        private double balance;

        public Accounts(string accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = 0; 
        }

        public void accept(string accountNo, string customerName, string accountType, char transactionType, double amount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;

        }

        public void credit(double amt)
        {
            this.balance += amt;
        }


        public void debit(double amt)
        {
            if (amt <= this.balance)
            {
                this.balance -= amt;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void showData()
        {
            Console.WriteLine($"Account No.: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {(transactionType == 'D' ? "Deposit" : "Withdrawal")}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accounts account = new Accounts("123456", "John Doe", "Savings");

            account.accept("123456", "chaitanya", "Savings", 'D', 500);
            account.credit(500);
            account.showData();

            account.accept("123456", "ravi", "Savings", 'W', 200);
            account.debit(200); 
            account.showData();
        }
    }
}