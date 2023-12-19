namespace RacingProject;
public class Race
{
    public Race(string races, string dates, string track)
    {
        Races = races;
        Dates = dates;
        Track = track;
        Drivers = new List<Driver>();
    }

    public string Races { get; }
    public string Dates { get; }
    public string Track { get; }

    public readonly int MaxDrivers = 20;

    public List<Driver> Drivers { get; }

    public bool AddDriver(Driver driver)
    {
        if (Drivers.Count < MaxDrivers)
        {
            Drivers.Add(driver);
            return true;
        }

        return false;
    }

}
