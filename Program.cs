Race race1 = new("FastBoi", date: "11 / 24 / 2023", trackname: "Turtle");
Race race2 = new("FasterBoi", "11 / 30 / 2023", "Hare");
Race race3 = new("FastestBoi", "12 / 02 / 2023", "Godzilla");
//Console.WriteLine(race1.Date);
var racesCalendar = new Queue<string>();
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race1.RaceName} Date: {race1.Date} Trackname: {race1.TrackName}'");
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race2.RaceName} Date: {race2.Date} Trackname: {race2.TrackName}'");
racesCalendar.Enqueue($"Race scheduled 'Race Name: {race3.RaceName} Date: {race3.Date} Trackname: {race3.TrackName}'");

Driver d1 = new("Zack");
Driver d2 = new("Kyle");
Driver d3 = new("Daniel");
Driver d4 = new("Dad");
Driver d5 = new("Nicole");
Driver d6 = new("Donnie");
Driver d7 = new("Janna");
Driver d8 = new("Kylie");
Driver d9 = new("Cazz");
Driver d10 = new("Meme");
Driver d11 = new("Emma");
Driver d12 = new("Matao");
Driver d13 = new("Abby");
Driver d14 = new("Logan");
Driver d15 = new("Nargy");
Driver d16 = new("Cade");
Driver d17 = new("Katie");
Driver d18 = new("Joseph");
Driver d19 = new("Tristan");
Driver d20 = new("Blair");
Driver d21 = new("Lance");
Driver d22 = new("Tim");
Driver d23 = new("Tom");
//23 drivers
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
    public int AddDriver()
    {
        int Drivers = 0;
        while (Drivers <= 20)
        {
            Drivers += 1;
        }
        return Drivers;
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