using Namespaces.Data;
Person person = new();
public const int Year = 2023;

int result = SuperMath.Sum(10, 32);
Console.WriteLine(result);
Console.WriteLine(SuperMath.PI);
public static class SuperMath
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static double PI
    {
        get { return 3.14734d; }
    }
}