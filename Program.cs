Race race1 = new("FastBoi", 11 / 22 / 2023, "Turtle");
//Console.WriteLine();


var racesCalendar = new Queue<string>();
racesCalendar.Enqueue($"Race scheduled: Race Name: {race1.Name} Date: {race1.Date} Trackname: {race1.TrackName}");
racesCalendar.Enqueue("Race scheduled: November 30th @ 7:00pm");
racesCalendar.Enqueue("Race scheduled: December 2nd @ 9:00am");





public class Race
{
    public Race(string name, int date, string trackName)
    {
        Name = name;
        Date = date;
        TrackName = trackName;
    }
    public string Name { get; set; }
    public int Date { get; set; }
    public string TrackName { get; set; }
}