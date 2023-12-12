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
//     public Race(string name, string date, string trackname)
//     {
//         Name = name;
//         Date = date;
//         TrackName = trackname;
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
int[] array1 = new int[4];
array1[0] = 2;
array1[1] = 9;
array1[2] = 12;
array1[3] = 90;

Console.WriteLine(array1[0]);

//
var array2 = new int[] { 2, 9, 12, 90 };

Console.WriteLine(array2[0]);

//
int[] array3 = { 2, 9, 12, 90 };
Console.WriteLine(array3[0]);

Person[] persons = new Person[9];
persons[0] = new Person("Dad");
persons[1] = new Person("Daniel");
persons[2] = new Person("Zack");
persons[3] = new Person("Kyle");
persons[4] = new Person("Nicole");

try
{
    foreach (Person person in persons)
    {
        Console.WriteLine(person.Name);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Catch Block successful");
}
public class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}