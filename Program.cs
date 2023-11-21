
using System.Collections.Concurrent;
using System.Xml.XPath;

Console.WriteLine("Welcome to the Accounting System 1.0");
Checking c1 = new(100, 0);
Premium p1 = new(200, 0);
Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
Console.WriteLine("Please enter amount you wish to deposit in Checking account: ");
double checkingDeposit = Convert.ToDouble(Console.ReadLine());
double result = c1.Deposit(checkingDeposit);
c1.Balance = result;
Console.WriteLine("Please enter amount you wish to depsit in Premium account: ");
double premiumDeposit = Convert.ToDouble(Console.ReadLine());
double result2 = p1.Deposit(premiumDeposit);
p1.Balance = result2;
Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
Console.WriteLine("How much would you like to transfer to your Checking account?");
double premiumWithraw = Convert.ToDouble(Console.ReadLine());
double result3 = p1.Withdraw(premiumWithraw);

// c1.Balance += result3;
// Console.WriteLine(c1.Balance);

// double depositAmount = c1.Deposit(a);
// c1.Balance = depositAmount;
// 
// double b = Convert.ToDouble(Console.ReadLine());
// double premiumDepositAmount = p1.Deposit(b);
// p1.Balance = premiumDepositAmount;
// Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
// Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
// Console.WriteLine("Please enter amount you wish to Withdraw or transfer into your Checking Account: ");
// double c = Convert.ToDouble(Console.ReadLine());
// p1.Balance = premiumDepositAmount - c;
// c1.Balance = depositAmount + c;
// p1.Withdraw(c);
// Console.WriteLine(c1.Balance);
// Console.WriteLine(p1.Balance);

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
        //double interestRate = Convert.ToDouble(Console.ReadLine());
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
        return base.Interest(d) + 0.01;
    }
}

// you should be able to calculate interest based on the current balance of the checking account;

// you should be able to calculate interest based on the current balance of the checking account and an input

//the premimun account has the same behavior as the checking account.
//The only difference is that tha premium account gets a 1% extra interest on top of the user input;

//you should be able to transfer money from the one account to another at any time;
