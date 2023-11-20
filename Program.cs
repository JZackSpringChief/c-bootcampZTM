//greet user with "Welcome to the Accounting System 1.0"
Console.WriteLine("Welcome to the Accounting System 1.0");

//The accounting system should have a checking account and a premium account;
Checking c1 = new(200, 98.78);
c1.Deposit();
Console.WriteLine(c1.Balance);

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
        Console.WriteLine("please enter amount you wish to deposit");
        double a = Convert.ToDouble(Console.ReadLine());
        return a + Balance;
    }
}

//a checking account has an ID(number) and a balance(decimal number);

//You should be able to set a starting balance when creating a checking account;

// you should be able to calculate interest based on the current balance of the checking account;

// you should be able to calculate interest based on the current balance of the checking account and an input

//you should be able to print the ID and the current blanace of a checking account at anytime;

//the premimun account has the same behavior as the checking account.
//The only difference is that tha premium account gets a 1% extra interest on top of the user input;

//you should be able to transfer money from the one account to another at any time;

//