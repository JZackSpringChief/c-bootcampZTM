
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
Driver d3 = new("Kyle");
Driver d4 = new("Donnie");
Driver d5 = new("Mo");
Driver d6 = new("Janna");
Driver d7 = new("Meme");
Driver d8 = new("Kylie");
Driver d9 = new("Logan");
Driver d10 = new("Emma");
Driver d11 = new("Chloe");
Driver d12 = new("Shane");
Driver d13 = new("Rich");
Driver d14 = new("Devin");
Driver d15 = new("Panther");
Driver d16 = new("Tigar");
Driver d17 = new("Cat");
Driver d18 = new("Lion");
Driver d19 = new("Wolf");
Driver d20 = new("OgiBoggie");
Driver d21 = new("Dr D");
Driver d22 = new("Dr A");
Driver d23 = new("Nurse Joy");
race1.AddDriver(d1.Name);
race1.AddDriver(d2.Name);
race1.AddDriver(d3.Name);
race1.AddDriver(d4.Name);
race1.AddDriver(d5.Name);
race1.AddDriver(d6.Name);
race1.AddDriver(d7.Name);
race1.AddDriver(d8.Name);
race1.AddDriver(d9.Name);
race1.AddDriver(d10.Name);
race1.AddDriver(d11.Name);
race1.AddDriver(d12.Name);
race1.AddDriver(d13.Name);
race1.AddDriver(d14.Name);
race1.AddDriver(d15.Name);
race1.AddDriver(d16.Name);
race1.AddDriver(d17.Name);
race1.AddDriver(d18.Name);
race1.AddDriver(d19.Name);
race1.AddDriver(d20.Name);
race1.AddDriver(d21.Name);
race1.AddDriver(d22.Name);
race1.AddDriver(d23.Name);

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
    public Queue<string> driverQueue = new Queue<string>();
    public Queue<string> waitingQueue = new Queue<string>();
    public int drivercount = 0;
    public int waitingcount = 0;
    public void AddDriver(string name)
    {
        driverQueue.Enqueue(name);
        drivercount++;
        if (drivercount >= 21)
        {
            Console.WriteLine($"{name} cannot enter the race, added to new queue");
            waitingQueue.Enqueue(name);
            while (waitingQueue.Count > 0)
            {
                var waiting = waitingQueue.Dequeue();
                Console.WriteLine(waiting);
                waitingcount++;
                Console.WriteLine(waitingcount);
            }
        }
        else
        {
            Console.WriteLine($"{name} was added to the race: {RaceName}, which is held on the {Date}. Good luck in the {TrackName} race!");
            Console.WriteLine(drivercount);
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