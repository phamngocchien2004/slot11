using slot11.amslot11;

public class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.SoDuThayDoi += Account_SoDuThayDoi;


        account.Deposit(1000000);
        account.Withdraw(1000000);
    }

    private static void Account_SoDuThayDoi(object sender, EventArgs e)
    {
        BankAccount account = (BankAccount)sender;
        Console.WriteLine($"Bien dong so du: {account.Balance}");
    }
}
