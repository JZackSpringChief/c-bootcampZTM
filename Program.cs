//extention methods
var p1 = new Person("Zack", "Spring Chief");
Console.WriteLine(p1.ToFullName());
Console.WriteLine(p1.HasId());

public interface IIdentification
{
    int Id { get; }
}
public static class IdentificationExtentions
{
    public static bool HasId(this IIdentification identification)
    {
        return identification.Id > 0;
    }
}

public class Person : IIdentification
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id
    {
        get
        {
            return 7;
        }
    }
}