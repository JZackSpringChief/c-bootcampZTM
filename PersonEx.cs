public static class PersonExtention
{
    public static string ToFullName(this Person p1)
    {
        return $"{p1.FirstName} {p1.LastName}";
    }
}