namespace RacingProject;
internal class Program
{
    static void Main(string[] args)
    {
        var calendar = new RacingCalendar();
        var drivers = GenerateDrivers();

        calendar.ScheduleRaces();
        calendar.AssignDriversToRaces(drivers);
        calendar.AddRemainingDriversToWaitingList(drivers);
        calendar.Show();
        calendar.ShowWaitingList();
    }

    private static Queue<Driver> GenerateDrivers()
    {
        const int totalNumberDrivers = 100;
        var drivers = new Queue<Driver>();
        for (var i = 1; i <= totalNumberDrivers; i++)
        {
            drivers.Enqueue(new Driver($"Driver {i}"));
        }

        return drivers;
    }
}