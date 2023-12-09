// Race race1 = new("FastBoi", date: "11 / 24 / 2023", trackName: "Turtle");
// Race race2 = new("FasterBoi", "11 / 30 / 2023", "Hare");
// Race race3 = new("FastestBoi", "12 / 02 / 2023", "Godzilla");
// //Console.WriteLine(race1.Date);


// var racesCalendar = new Queue<string>();
// racesCalendar.Enqueue($"Race scheduled 'Race Name: {race1.Name} Date: {race1.Date} Trackname: {race1.TrackName}'");
// racesCalendar.Enqueue($"Race scheduled 'Race Name: {race2.Name} Date: {race2.Date} Trackname: {race2.TrackName}'");
// racesCalendar.Enqueue($"Race scheduled 'Race Name: {race3.Name} Date: {race3.Date} Trackname: {race3.TrackName}'");

// while (racesCalendar.Count > 0)
// {
//     var raceCalender = racesCalendar.Dequeue();
//     Console.WriteLine(raceCalender);
// }

// public class Race
// {
//     public Race(string name, string date, string trackName)
//     {
//         Name = name;
//         Date = date;
//         TrackName = trackName;
//     }
//     public string Name { get; set; }
//     public string Date { get; set; }
//     public string TrackName { get; set; }
//     public void AddDriver()
//     {
//         int Drivers = 0;
//         while (Drivers <= 20)
//         {
//             Drivers += 1;
//         }
//     }
// }

// public class Driver
// {
//     public Driver(string name)
//     {
//         Name = name;
//     }
//     string Name { get; set; }
// }
var temperature = new Temperature(TempuratureUnit.Celcius, 112.6m);
Console.WriteLine($"Tempurature: {temperature.ValueInCelcius.ToString("0.0")}C");
enum TempuratureUnit
{
    Celcius,
    Fahrenheit,
    Kelvin
}

class Temperature
{
    public Temperature(TempuratureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }
    public TempuratureUnit Unit { get; set; }
    public decimal Value { get; set; }
    public decimal ValueInCelcius
    {
        get
        {
            return Unit switch
            {
                TempuratureUnit.Celcius when Value > 100 => Math.Round(Value, 0), //guard clause
                TempuratureUnit.Celcius => Value,
                TempuratureUnit.Fahrenheit => (Value - 32) * 5 / 9,
                TempuratureUnit.Kelvin => Value - 273.5m,
                _ => 0
            };
            // switch (Unit)
            // {
            //     case TempuratureUnit.Celcius:
            //         return Value;
            //     case TempuratureUnit.Fahrenheit:
            //         return (Value - 32) * 5 / 9;
            //     case TempuratureUnit.Kelvin:
            //         return Value - 273.5m;
            //     default:
            //         return 0;
            // }
        }
    }
}