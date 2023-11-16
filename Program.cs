using System.Security.AccessControl;

Person p1 = new("zack", 33, false);
Person p2 = new("kyle", 31, true);
Person p3 = new("Daniel", 35, false);

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Age);
Console.WriteLine(p3.InSchool);

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