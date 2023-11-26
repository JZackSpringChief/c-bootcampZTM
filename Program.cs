

public class Human
{
    public Human(string name, string jobClass)
    {
        Name = name;
        JobClass = jobClass;
    }
    public string Name { get; set; }
    public string JobClass { get; set; }

    public string WeaponOfChioce()
    {
        Console.WriteLine("Choose 'a' for Sword or 'b' for Axe");
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        if (a)
        {
            Console.WriteLine("Take this Excalabur");
        }
        else if (b)
        {
            Console.WriteLine("Take this Armadeus");
        }
    }
}