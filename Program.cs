Person p1 = new("zack");
Person p2 = new("kyle");

Console.WriteLine(p1.Name);

class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}