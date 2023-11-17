//Inheritance
Person p1 = new("Aric");
Employee p2 = new("Zack", "CEO");

Console.WriteLine($"{p1.Name}: {p1.GetId()}");
Console.WriteLine($"{p2.Name}: {p2.GetId()}");
public class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public string GetId()
    {
        return Name.ToLower();
    }
}

public class Employee : Person
{
    public string Role { get; set; }
    public Employee(string name, string role) : base(name)
    {
        Role = role;
    }
}