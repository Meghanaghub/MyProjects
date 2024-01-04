
class Program
{
    static void Main(string[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>();

        while (true)
        {
            Console.WriteLine("Bank Account Management System");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. View Account Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            var transaction = new Transactions();

            //Convert is a class that have some methods to change the datatype
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateAccount(accounts);
                    Console.WriteLine();
                    break;
                case 2:
                    // calling the static method from Transactions class
                    transaction.DepositMoney(accounts);
                    Console.WriteLine();
                    break;
                case 3:
                    transaction.WithdrawMoney(accounts);
                    Console.WriteLine();
                    break;
                case 4:
                    transaction.ViewAccountBalance(accounts);
                    Console.WriteLine();
                    break;
                case 5:
                    // exits from the working environment and closes the output console
                    Environment.Exit(0);
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    break;
            }
        }
    }

    static void CreateAccount(List<BankAccount> accounts)
    {
        // give the user name to create an account
        Console.Write("Enter account holder name: ");
        string accountHolder = Console.ReadLine();
        
        //creating a new object of BankAccount with the name of user
        BankAccount newAccount = new BankAccount(accountHolder);

        // adding the new user to the list of accounts
        accounts.Add(newAccount);
        Console.WriteLine($"Account created successfully. Account Number: {newAccount.AccountNumber}");
    }

    
}