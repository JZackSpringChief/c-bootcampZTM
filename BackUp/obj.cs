// Hero h1 = new("Blair", 9999, 9999);
// p1.PrintGreeting();
// string greeting = p1.GetGreeting();
// Math add = new();
// int result = add.Sum(10, 77);
// Console.WriteLine(result);
// Console.WriteLine($"Hero Name: {h1.Name}. Hero's Attack: OVER {h1.Attack}. Hero's Defense: {h1.Defense}.");
// class Person
// {
//     public Person(string name, int age, bool inschool)
//     {
//         Name = name;
//         Age = age;
//         InSchool = inschool;
//     }

//     public string Name { get; private set; }
//     public int Age { get; private set; }
//     public bool InSchool { get; private set; }

//     public void PrintGreeting()
//     {
//         Console.WriteLine($"Hello, {Name}");
//     }
//     public string GetGreeting()
//     {
//         return $"Hello, {Name}";
//     }
// }
// class Hero
// {
//     public Hero(string name, int attack, int defense)
//     {
//         Name = name;
//         Attack = attack;
//         Defense = defense;
//     }
//     public string Name { get; set; }
//     public int Attack { get; set; }
//     public int Defense { get; set; }
// }
// public class Math
// {
//     public int Sum(int a, int b)
//     {
//         return a + b;
//     }

// }
// public class House
// {
//     int currentYear = 2023;
//     public House(int yearbuilt, int housesize)
//     {
//         YearBuilt = yearbuilt;
//         HouseSize = housesize;
//     }
//     public int YearBuilt { get; set; }
//     public int HouseSize { get; set; }
//     private int HowOld()
//     {
//         return currentYear - YearBuilt;
//     }
//     public bool CanBeSold()
//     {
//         if (HowOld() >= 15)
//         {
//             return true;
//         }
//         return false;
//     }
// }