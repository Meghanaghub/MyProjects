

public class BankAccount
{
    
    private static int accountNumberSeed = 1000;

    public int AccountNumber { get; }
    public string AccountHolder { get; }
    public double Balance { get; private set; }

   

    public BankAccount(string accountHolder)
    {
        // Gives an unique id every time 
        AccountNumber = accountNumberSeed++;
        AccountHolder = accountHolder;
        Balance = 0;
    }

    public string Deposit(double amount)
    {
        try
        {
            if (amount > 0)
            {
                Balance += amount;
                return "success";
            }
            else
            {
                throw new Exception("Deposit Failed! Please check the amount entered");
            }
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        
    }

    public string Withdraw(double amount)
    {
        try
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return "success";
            }
            else
            {
                throw new Exception("Withdraw Failed! Please check the amount entered and the account Balance");
            }
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}