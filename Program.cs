
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Accounting System 1.0");
        Checking c1 = new(100, 0);
        Premium p1 = new(200, 0);
        Print(c1, p1);
        Console.WriteLine("Please enter amount you wish to deposit in Checking account: ");
        double checkingDeposit = Convert.ToDouble(Console.ReadLine());
        double result = c1.Deposit(checkingDeposit);
        c1.Balance = result;
        Console.WriteLine("Please enter amount you wish to depsit in Premium account: ");
        double premiumDeposit = Convert.ToDouble(Console.ReadLine());
        double result2 = p1.Deposit(premiumDeposit);
        p1.Balance = result2;
        Print(c1, p1);
        Console.WriteLine("How much would you like to transfer to your Checking account?");
        double premiumWithraw = Convert.ToDouble(Console.ReadLine());
        double result3 = p1.Withdraw(premiumWithraw);
        c1.Balance += premiumWithraw;
        Console.WriteLine($"The Account ID '{c1.ID}' has a new checking balance of: {c1.Balance}");
        p1.Balance = result3;
        Console.WriteLine($"The Account ID '{p1.ID}' has a new premium balance of: {p1.Balance}");
        Console.WriteLine("enter amount for interest?");
        double checkingInterest = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Account 1 Interest: {c1.Interest(checkingInterest)}");
        Console.WriteLine($"Account 2 Interest: {p1.Interest(checkingInterest)}");
        double result4 = c1.Interest(checkingInterest);
        double result5 = p1.Interest(checkingInterest);
        c1.Balance += result4;
        p1.Balance += result5;
        Print(c1, p1);

        static void Print(Checking c1, Premium p1)
        {
            Console.WriteLine($"The Account ID '{c1.ID}' has a balance of: {c1.Balance}");
            Console.WriteLine($"The Account ID '{p1.ID}' has a balance of: {p1.Balance}");
        }
    }
}

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
        return base.Interest(d + 0.01);
    }
}
