Person p1 = new();
Person p2 = new Employee();
Person p3 = new Customer();

p1.Greeting();
p2.Greeting();
p3.Greeting();



public class Person
{
    public virtual void Greeting()
    {
        Console.WriteLine("I am a reg");
    }
}
public class Employee : Person
{
    public override void Greeting()
    {
        Console.WriteLine("I am an Employee");
    }
}
public class Customer : Person
{
    public override void Greeting()
    {
        Console.WriteLine("I am a Customer");
    }
}
