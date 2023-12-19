namespace RacingProject;
public class WaitingList
{
    private readonly Queue<Driver> _drivers = new();

    public void AddDriver(Driver driver)
    {
        _drivers.Enqueue(driver);
    }

    public void Show()
    {
        Console.WriteLine("\n Waiting List");
        Console.WriteLine("=============");

        var count = 1;
        foreach (var driver in _drivers)
        {
            Console.WriteLine($"{count++}: {driver.DriverName}");
        }
    }
}