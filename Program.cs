using System.Security.AccessControl;

Person p1 = new("zack", 33, false);
Person p2 = new("kyle", 31, true);
Person p3 = new("Daniel", 35, false);

Hero h1 = new("Blair", 9999, 9999);

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Age);
Console.WriteLine(p3.InSchool);

Console.WriteLine($"Hero Name: {h1.Name}. Hero's Attack: OVER {h1.Attack}. Hero's Defense: {h1.Defense}.");


class Person
{
    public Person(string name, int age, bool inschool)
    {
        Name = name;
        Age = age;
        InSchool = inschool;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
    public bool InSchool { get; private set; }
}
class Hero
{
    public Hero(string name, int attack, int defense)
    {
        Name = name;
        Attack = attack;
        Defense = defense;
    }
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
}