
Race race1 = new(racename: "FastBoi", date: "11 / 24 / 2023", trackname: "Turtle");
Race race2 = new(racename: "FasterBoi", date: "11 / 30 / 2023", trackname: "Hare");
Race race3 = new(racename: "FastestBoi", date: "12 / 02 / 2023", trackname: "Godzilla");
var racesCalendar = new Queue<string>();
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race1.RaceName} Date: {race1.Date} Trackname: {race1.TrackName}'");
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race2.RaceName} Date: {race2.Date} Trackname: {race2.TrackName}'");
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race3.RaceName} Date: {race3.Date} Trackname: {race3.TrackName}'");

while (racesCalendar.Count > 0)
{
    var raceCalender = racesCalendar.Dequeue();
    Console.WriteLine(raceCalender);
}
Driver d1 = new("Zack");
Driver d2 = new("Daniel");
Driver d3 = new("Kyld");
race1.AddDriver(d1.Name);
race1.AddDriver(d2.Name);
race1.AddDriver(d3.Name);
public class Race
{
    public Race(string racename, string date, string trackname)
    {
        RaceName = racename;
        Date = date;
        TrackName = trackname;
    }
    public string RaceName { get; set; }
    public string Date { get; set; }
    public string TrackName { get; set; }
    public void AddDriver(string name)
    {
        int drivercount = 0;
        if (drivercount <= 0)
        {
            drivercount++;
            Console.WriteLine($"{name} has been added to the race: {RaceName}, which is held on {Date}. Good luck in the {TrackName} Race!");
            Console.WriteLine(drivercount);
        }
        else if (drivercount >= 20)
        {
            Console.WriteLine($"{name} cound not be added to race. {name} is now in queue");
        }
        else
        {
            Console.WriteLine("Please add driver");
        }

    }
}
public class Driver
{
    public Driver(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}