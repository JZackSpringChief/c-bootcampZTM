Race race1 = new(racename: "FastBoi", date: "11 / 24 / 2023", trackname: "Turtle");
Race race2 = new(racename: "FasterBoi", date: "11 / 30 / 2023", trackname: "Hare");
Race race3 = new(racename: "FastestBoi", date: "12 / 02 / 2023", trackname: "Godzilla");
//Console.WriteLine(race1.Date);
var racesCalendar = new Queue<string>();
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race1.RaceName} Date: {race1.Date} Trackname: {race1.TrackName}'");
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race2.RaceName} Date: {race2.Date} Trackname: {race2.TrackName}'");
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race3.RaceName} Date: {race3.Date} Trackname: {race3.TrackName}'");

race1.AddDriver();

while (racesCalendar.Count > 0)
{
    var raceCalender = racesCalendar.Dequeue();
    Console.WriteLine(raceCalender);
}
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
    public void AddDriver()
    {
        var NewDriver = new Queue<string>();
        NewDriver.Enqueue("Zack");
        foreach (var driver in NewDriver)
        {
            Console.WriteLine(driver);
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