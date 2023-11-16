Person p1 = new();
Person p2 = new();

p1.Name = "Kyle";
Console.WriteLine(p1.Name);

class Person
{
    private string name;
    public Person()
    {
        name = "zack";
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}