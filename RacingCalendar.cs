namespace RacingProject;
public class RacingCalendar
{
    private readonly List<Race> _races = new();
    private readonly WaitingList _waitingList = new();

    public void ScheduleRaces()
    {
        _races.Add(new Race("Time Trial", "12/04/2023", "MySpeedway"));
        _races.Add(new Race("Demolition", "12/14/2023", "CrashSpeedway"));
        _races.Add(new Race("Circuit Race", "12/22/2023", "EnduranceSpeedway"));
    }

    public void AssignDriversToRaces(Queue<Driver> drivers)
    {
        foreach (var race in _races)
        {
            for (var i = 0; i < race.MaxDrivers; i++)
            {
                if (drivers.Count > 0)
                {
                    var driver = drivers.Dequeue();
                    if (race.AddDriver(driver))
                    {
                        Console.WriteLine($"Added {driver.DriverName} to {race.Races}");
                    }
                }
                else { break; }
            }
        }
    }

    public void AddRemainingDriversToWaitingList(Queue<Driver> drivers)
    {
        Console.WriteLine($"Adding remaining drivers to waiting list...");
        while (drivers.Count > 0)
        {
            _waitingList.AddDriver(drivers.Dequeue());
        }
    }

    public void Show()
    {
        Console.WriteLine("\nRacing Calendar");
        Console.WriteLine("================");
        foreach (var race in _races)
        {
            Console.WriteLine($"\n {race.Races} - {race.Dates} - {race.Track}");
            Console.WriteLine("Drivers:");
            foreach (var driver in race.Drivers)
            {
                Console.WriteLine($"\t{driver.DriverName}");
            }
        }
    }

    public void ShowWaitingList()
    {
        _waitingList.Show();
    }

}