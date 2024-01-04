
public class Transactions
{
    
    /* Static methods are Utility methods.Utility methods are typically designed to be called without creating instances 
     * because they don't have to maintain state across multiple calls or interact with the properties of specific objects. */
    public  void DepositMoney(List<BankAccount> accounts)
    {
        Console.Write("Enter account number: ");
        // converting the type of input to int
        int accountNumber = Convert.ToInt32(Console.ReadLine());
        BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);
        if (account != null)
        {
            Console.Write("Enter the amount to deposit: ");
            // converting the type of input to double
            double amount = Convert.ToDouble(Console.ReadLine());
            // calling the Deposit method to add amount
            account.Deposit(amount);
            Console.WriteLine($"Deposited {amount:C} into Account {account.AccountNumber}. New balance: {account.Balance:C}");
        }
        else
        {
            Console.WriteLine("Account not found. Please enter a valid account number.");
        }
    }

    public  void WithdrawMoney(List<BankAccount> accounts)
    {
        Console.Write("Enter account number: ");
        // converting the type of input to int
        int accountNumber = Convert.ToInt32(Console.ReadLine());
        BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);
        if (account != null)
        {
            Console.Write("Enter the amount to withdraw: ");
            // converting the type of input to double
            double amount = Convert.ToDouble(Console.ReadLine());

            // calling the Withdraw method to deduct the amount and return a boolean value
            if (account.Withdraw(amount) == "success")
            {
                Console.WriteLine($"Withdrawn {amount:C} from Account {account.AccountNumber}. New balance: {account.Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance to withdraw.");
            }
        }
        else
        {
            Console.WriteLine("Account not found. Please enter a valid account number.");
        }
    }

    public  void ViewAccountBalance(List<BankAccount> accounts)
    {
        Console.Write("Enter account number: ");
        // converting the type of input to int
        int accountNumber = Convert.ToInt32(Console.ReadLine());
        BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);
        if (account != null)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Account Holder: {account.AccountHolder}");
            Console.WriteLine($"Balance: {account.Balance:C}");
        }
        else
        {
            Console.WriteLine("Account not found. Please enter a valid account number.");
        }
    }
}