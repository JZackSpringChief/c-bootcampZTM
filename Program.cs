//extention methods
var p1 = new Person("Zack", "Spring Chief");
Console.WriteLine(p1.ToFullName());

public static class PersonExtention
{
    public static string ToFullName(this Person p1)
    {
        return $"{p1.FirstName} {p1.LastName}";
    }
}

public class Person
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}