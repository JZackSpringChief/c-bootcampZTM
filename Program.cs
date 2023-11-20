
Console.WriteLine("Welcome to the Accounting System 1.0");
//The accounting system should have a checking account and a premium account;
Checking c1 = new(100, 0);
Premium p1 = new(200, 0);
Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
double depositAmount = c1.Deposit();
c1.Balance = depositAmount;
double premiumDepositAmount = p1.Deposit();
p1.Balance = premiumDepositAmount;
Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
double depo = p1.TransferDeposit();
c1.Balance = depo;
Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
public class Checking
{
    public Checking(int id, double balance)
    {
        ID = id;
        Balance = balance;
    }
    public int ID { get; set; }
    public double Balance { get; set; }
    public double Deposit()
    {
        Console.WriteLine("please enter amount you wish to deposit: ");
        double a = Convert.ToDouble(Console.ReadLine());
        return a + Balance;
    }
    public virtual double Interest()
    {
        double interestRate = Convert.ToDouble(Console.ReadLine());
        return Balance * interestRate;
    }
    public virtual double TransferDeposit()
    {
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Depositing {amount} from Account ID '{ID}'.");
        return Balance += amount;
    }
    public virtual double TransferWithdraw()
    {
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Withdrawing {amount} from Account ID '{ID}'.");
        return Balance -= amount;
    }
}
public class Premium : Checking
{
    public Premium(int id, double balance) : base(id, balance)
    {
    }

    public override double Interest()
    {
        return base.Interest() * 0.1;
    }
    public override double TransferWithdraw()
    {
        return base.TransferWithdraw();
    }
    public override double TransferDeposit()
    {
        return base.TransferDeposit();
    }
}


// you should be able to calculate interest based on the current balance of the checking account;

// you should be able to calculate interest based on the current balance of the checking account and an input

//you should be able to print the ID and the current blanace of a checking account at anytime;

//the premimun account has the same behavior as the checking account.
//The only difference is that tha premium account gets a 1% extra interest on top of the user input;

//you should be able to transfer money from the one account to another at any time;

//