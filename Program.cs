
Console.WriteLine("Welcome to the Accounting System 1.0");
Checking c1 = new(100, 0);
Premium p1 = new(200, 0);
Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
Console.WriteLine("Please enter amount you wish to deposit in Checking account: ");
double a = Convert.ToDouble(Console.ReadLine());
double depositAmount = c1.Deposit(a);
c1.Balance = depositAmount;
Console.WriteLine("Please enter amount you wish to depsit in Premium account: ");
double b = Convert.ToDouble(Console.ReadLine());
double premiumDepositAmount = p1.Deposit(b);
p1.Balance = premiumDepositAmount;
Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
Console.WriteLine("Please enter amount you wish to Withdraw or transfer: ");
double c = Convert.ToDouble(Console.ReadLine());
// double transferAmount = p1.Withdraw();

public class Checking
{
    public Checking(int id, double balance)
    {
        ID = id;
        Balance = balance;
    }
    public int ID { get; set; }
    public double Balance { get; set; }
    public double Deposit(double a)
    {
        double totalAmount = a + Balance;
        return totalAmount;
    }
    public double Withdraw(double c)
    {
        double totalAmount = Balance - c;
        return totalAmount;
    }
    public virtual double Interest(double d)
    {
        double interestRate = Convert.ToDouble(Console.ReadLine());
        return Balance * d;
    }
}
public class Premium : Checking
{
    public Premium(int id, double balance) : base(id, balance)
    {
    }

    public override double Interest(double d)
    {
        return base.Interest(d) * 0.1;
    }
}

// you should be able to calculate interest based on the current balance of the checking account;

// you should be able to calculate interest based on the current balance of the checking account and an input

//the premimun account has the same behavior as the checking account.
//The only difference is that tha premium account gets a 1% extra interest on top of the user input;

//you should be able to transfer money from the one account to another at any time;
